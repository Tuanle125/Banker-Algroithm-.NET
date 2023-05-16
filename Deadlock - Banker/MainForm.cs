using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        private int totalProcesses;
        private int totalResourceType;
        private Banker banker;

        public MainForm()
        {
            InitializeComponent();
            banker = new Banker();
        }

        private void createEmptyData(DataGridView dataGridView, int column, int row, int type)
        {
            /**
             * Type 1 is for input resources of each processes
             * Type 0 is for input the number of resources available
            */
            if (type == 1)
            {
                dataGridView.ColumnCount = column + 1;

                dataGridView.Columns[0].Name = "Process";
                dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            else
            {
                dataGridView.ColumnCount = column;

                dataGridView.Columns[0].Name = "Type";
                dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView.Columns[0].ReadOnly = true;

                dataGridView.Columns[1].Name = "Have";
                dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int pro = 1; pro <= row; pro++)
                {
                    string resourceRowName = "" + (char)(64 + pro);
                    dataGridView.Rows.Add(resourceRowName, 0);
                }
            }
        }

        private void fillData(DataGridView dataGridView, List<List<int>> data)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridView.Columns.Count; j++)
                {
                    string number = data[i][j-1].ToString();
                    dataGridView.Rows[i].Cells[j].Value = number;
                }
            }
        }

        private void reset()
        {
            totalProcesses = 0;
            totalResourceType = 0;
            //TB_totalProcess.Text = "";
            //TB_totalResourceType.Text = "";
            TB_Output.Text = "";
            TB_ProcessRequest.Text = "";
            TB_ResourceRequest.Text = "";
            this.dataGridView_Allocation.DataSource = null;
            this.dataGridView_Allocation.Columns.Clear();
            this.dataGridView_Allocation.Rows.Clear();

            this.dataGridView_Total.DataSource = null;
            this.dataGridView_Total.Columns.Clear();
            this.dataGridView_Total.Rows.Clear();

            this.dataGridView_Max.DataSource = null;
            this.dataGridView_Max.Columns.Clear();
            this.dataGridView_Max.Rows.Clear();

            this.dataGridView_Need.DataSource = null;
            this.dataGridView_Need.Columns.Clear();
            this.dataGridView_Need.Rows.Clear();
        }

        private void check(DataGridView dataGridView)
        {
            String s = "";

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                for (int i = 1; i < row.Cells.Count; i++)
                {
                    string s_num = row.Cells[i].Value.ToString();

                    s += s_num + " ";
                }
                s += " - ";
            }
            MessageBox.Show(s);
        }

        private void BT_Create_Click(object sender, EventArgs e)
        {
            reset();
            //== raise error if user input character -> return; ==

            //
            totalProcesses = int.Parse(TB_totalProcess.Text);
            totalResourceType = int.Parse(TB_totalResourceType.Text);

            createEmptyData(dataGridView_Max, totalResourceType, totalProcesses, 1);
            createEmptyData(dataGridView_Allocation, totalResourceType, totalProcesses, 1);
            createEmptyData(dataGridView_Total, 2, totalResourceType, 0);
        }

        private void BT_Update_Click(object sender, EventArgs e)
        {
            //check max, allocation, available table

            // add data to banker
            banker.setTotalProcesses(totalProcesses);
            banker.setTotalResourceType(totalResourceType);
            banker.setMax(dataGridView_Max);
            banker.setAllocate(dataGridView_Allocation);
            banker.setTotal(dataGridView_Total);
            // clear Need table
            this.dataGridView_Need.DataSource = null;
            this.dataGridView_Need.Columns.Clear();
            this.dataGridView_Need.Rows.Clear();
            //banker calculate Need table and fill Need's data to datagridView
            createEmptyData(dataGridView_Need, totalResourceType, totalProcesses, 1);
            fillData(dataGridView_Need, banker.getNeed());
        }

        private void BT_SafeCheck_Click(object sender, EventArgs e)
        {
            banker.safeCheck();
        }

        private void dataGridView_Max_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_Max.EditingControl.Text = dataGridView_Max.CurrentCell.Value.ToString();
        }

        private void dataGridView_Allocation_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_Allocation.EditingControl.Text = dataGridView_Allocation.CurrentCell.Value.ToString();
        }

        private void dataGridView_Total_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_Total.EditingControl.Text = dataGridView_Total.CurrentCell.Value.ToString();
        }
    }
}
