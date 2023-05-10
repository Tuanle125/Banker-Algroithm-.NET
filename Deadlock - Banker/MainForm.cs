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

            createEmptyData(dataGridView_Max, totalResourceType, totalProcesses);
            createEmptyData(dataGridView_Allocation, totalResourceType, totalProcesses);
        

        }

        private void createEmptyData(DataGridView dataGridView, int column, int row)
        {
            dataGridView.ColumnCount = column + 1;

            dataGridView.Columns[0].Name = "Process";
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns[0].ReadOnly = true;
            // create all Resource collumn 
            for (int res = 1; res <= column; res++)
            {
                string resourceColumnName = "" + (char)(64 + res);
                dataGridView.Columns[res].Name = resourceColumnName;
                dataGridView.Columns[res].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // add space for fill Process's resource
            for (int pro = 1; pro <= row; pro++)
            {
                dataGridView.Rows.Add("Pos" + pro);
            }
        }
    }
}
