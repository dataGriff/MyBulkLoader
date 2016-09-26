using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyBulkLoader
{
    class SQLBulkLoad
    {
        public long countStartSource;
        public long countStart;
        public long countEnd;
        public DateTime dateStart;
        public DateTime dateEnd;
        public long diffCount { get { return countEnd - countStart; } }
        public double diffTime { get { return (dateEnd - dateStart).TotalSeconds; } }

            public void DoSQLBulkLoad(string sourceConnectionString, string destinationConnectionString, string sourceTable, string destinationTable, bool truncate, int timeout)
            {

                using (SqlConnection sourceConnection = new SqlConnection(sourceConnectionString))
                {
                    //Opens the source connection based on source connection string supplied
                    sourceConnection.Open();

                    //Creates row count of source at the start
                    SqlCommand commandRowCountSource = new SqlCommand(
                        "SELECT COUNT (*) FROM " + sourceTable, sourceConnection);
                    countStartSource = System.Convert.ToInt32(commandRowCountSource.ExecuteScalar());

                    //Creates data to transfer from source based on the source table supplied
                    SqlCommand commandSourceData = new SqlCommand("SELECT * FROM " + sourceTable, sourceConnection);
                    SqlDataReader reader = commandSourceData.ExecuteReader();

                    
                    using (SqlConnection destinationConnection = new SqlConnection(destinationConnectionString))
                    {
                        //Opens destination connection
                        destinationConnection.Open();

                        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(destinationConnection))
                        {
                            //Sets bulk copy destination table 
                            bulkCopy.DestinationTableName = destinationTable;

                            //Creates row count of destination at the start
                            SqlCommand commandRowCount = new SqlCommand(
                               "SELECT COUNT (*) FROM " + destinationTable, destinationConnection);
                            countStart = System.Convert.ToInt32(commandRowCount.ExecuteScalar());


                            // Set the timeout.
                            bulkCopy.BulkCopyTimeout = timeout;

                            //attempts to copy the data, capturing the start and end times
                            try
                            {
                                dateStart = DateTime.Now;
                                //Truncates destinaiton table if requested
                                if(truncate == true)
                                {
                                    SqlCommand truncateDestination = new SqlCommand(
                                        "TRUNCATE TABLE " + destinationTable, destinationConnection);
                                    truncateDestination.ExecuteNonQuery();
                                }
                                bulkCopy.WriteToServer(reader);
                                dateEnd = DateTime.Now;
                            }
                            //Produces an error if something goes wrong
                            catch (Exception ex)
                            {
                                System.Windows.Forms.MessageBox.Show("Error : " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                reader.Close();
                            }

                            //Sets the count of rows at the end
                            countEnd = System.Convert.ToInt32(commandRowCount.ExecuteScalar());
                        }
               
                        
                    }

                }

            }
        }

}

/*
 * 
 * 
 **/
