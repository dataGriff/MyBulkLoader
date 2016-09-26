using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyBulkLoader
{
    class SQLBulkLoadConfig
    {
        private string configConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;database=ConfigLoad;Data Source=GRIFF-PC\SQLEXPRESS2014";
        
        public IList<string> dropDownSourceConnectionString()
            {

                using (SqlConnection configConnection = new SqlConnection(configConnectionString))
                {
                    IList<string> list = new List<string> { };

                    //Opens the source connection based on source connection string supplied
                    configConnection.Open();

                    //Gets source connection strings
                    SqlCommand commandSourceData = new SqlCommand("EXEC  dbo.pr_DropDownSourceConnectionString", configConnection);
                    SqlDataReader reader = commandSourceData.ExecuteReader();

                    while (reader.Read())
                    {
                        list.Add(reader[0].ToString());
                    }

                    configConnection.Close();

                    return list;
                }

                  
        }
    }
}
