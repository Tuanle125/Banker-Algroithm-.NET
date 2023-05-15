using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deadlock___Banker
{
    internal class Banker
    {
        private int totalProcesses;
        private int totalResourceType;

        private List< List<int> > max;
        private List< List<int> > allocate;
        private List< List<int> > need;

        private List <int> available;

        public Banker() {
            max = new List<List<int>>();
            allocate = new List<List<int>>();
            need = new List<List<int>>();
            available = new List<int>();
        }
        public void setTotalProcesses(int totalProcesses)
        {
            this.totalProcesses = totalProcesses;
        }
        public void setTotalResourceType(int totalResourceType)
        {
            this.totalResourceType = totalResourceType;
        }
        public void setMax(DataGridView max)
        {
            this.max = dataGridTo2DList(max);
            check(this.max);
        }
        public void setAllocate(DataGridView allocate)
        {
            this.allocate = dataGridTo2DList(allocate);
        }
        public void setAvailable(DataGridView available)
        {
            this.available = dataGridTo1DList(available);
        }

        public DataGridView getNeed()
        {
            calculateNeed();
            return ListToDataGrid(need);
        }
        private void calculateNeed()
        {
            if(max.Count > 0 && allocate.Count > 0)
            {
                for(int i = 0; i < max.Count; i++)
                {
                    for(int j = 0; j < max[i].Count; j++)
                    {
                        need[i][j] = max[i][j] - allocate[i][j];
                    }
                }
            }
        }
        
        private DataGridView ListToDataGrid(List<List<int>> list)
        {
            DataGridView dgv_list = new DataGridView();
            dgv_list.DataSource = list;
            return dgv_list;
        }
        private List<List<int>> dataGridTo2DList(DataGridView dataGridView)
        {
            List<List<int>> items = new List<List<int>>();
            
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                List<int> item = new List<int>();

                for (int i = 1; i < row.Cells.Count; i++)
                {
                    string s_num = row.Cells[i].Value.ToString();
                    int number = Int32.Parse(s_num);
                    item.Add(number);
                }
                items.Add(item);
            }
            
            return items;
        }
        private List<int> dataGridTo1DList(DataGridView dataGridView)
        {
            List<int> items = new List<int>();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                for (int i = 1; i < row.Cells.Count; i++)
                {
                    int number = Int32.Parse(row.Cells[i].Value.ToString());
                    items.Add(number);
                }
            }

            return items;
        }
        private void check(List<List<int>> list)
        {
            MessageBox.Show(list.Count + " - " + list[0].Count);
            
            String s = "";
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[0].Count; j++)
                {
                    s += list[i][j] + " ";
                }
                s += " - ";
            }
            MessageBox.Show(s);
        }
    }
}
