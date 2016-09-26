using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyBulkLoader
{
    class CSVBulkLoad
    {
        /*
         * 
         * 
         * http://www.codeproject.com/Articles/9258/A-Fast-CSV-Reader
        StreamReader file = new StreamReader(bulk_data_filename);
        CsvReader csv = new CsvReader(file, true,',');
        SqlBulkCopy copy = new SqlBulkCopy(conn);
        copy.DestinationTableName = tablename;
        copy.WriteToServer(csv);
         * */
    }
}
