using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBulkLoader
{
    public partial class formBulkLoad : Form
    {
        SQLBulkLoad SqlLoader;
        SQLBulkLoadConfig SqlBulkLoadConfig;
        long sourceStartCount;
        long startCount;
        long endCount;
        long diffCount;
        double diffTime;
        int loadNo = 0;

        public void Configure()
        {
            SqlBulkLoadConfig = new SQLBulkLoadConfig();
               cmbxSourceConnectionString.DataSource = SqlBulkLoadConfig.dropDownSourceConnectionString();

        }
     

        public formBulkLoad()
        {
            InitializeComponent();
             txtSourceConnString.Text = @"Integrated Security=SSPI;Persist Security Info=False;database=NORTHWND;Data Source=GRIFF-PC\SQLEXPRESS2014";
            txtDestConnString.Text =  txtSourceConnString.Text ;
            Configure();
         
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SqlLoader = new SQLBulkLoad();
            SqlLoader.DoSQLBulkLoad(txtSourceConnString.Text, txtDestConnString.Text, txtSourceObject.Text, txtDestObject.Text, true, 60);
            sourceStartCount = SqlLoader.countStartSource;
            startCount = SqlLoader.countStart;
            endCount = SqlLoader.countEnd;
            diffCount = SqlLoader.diffCount;
            diffTime = SqlLoader.diffTime;
            setLastLoadLabel();
        }

        private void setLastLoadLabel()
        {
            loadNo++;
            lblLastLoad.Text = lblLastLoad.Text+"\n"
               + "Load No " + loadNo.ToString() + ": Duration: " + diffTime.ToString() + " seconds. " + sourceStartCount.ToString() + " rows transferred. "
               +"(" + txtSourceObject.Text+" to "+txtDestObject.Text+")";
                
        }

    }
}
