using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deadlock___Banker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BT_continue_Click(object sender, EventArgs e)
        {
            int totalProcesses = int.Parse(TB_totalProcess.Text);
            int totalResourceType = int.Parse(TB_totalResourceType.Text);
            DataTable table = new DataTable();

            table.Columns.Add("Process", typeof(string));
            //create column
            for (int res = 0; res < totalResourceType; res++)
            {
                string resourceColumnName = "" + (char) (65+res);
                table.Columns.Add(resourceColumnName, typeof(int));
            }
            //add pre data
            for (int pro = 1; pro <= totalProcesses; pro++)
            {
                table.Rows.Add("Pos " + pro);
            }
            //dataGridView1.ColumnAdded
        }
    }
}
