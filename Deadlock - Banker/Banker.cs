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
        private List <int> total, safeList, available;

        public Banker() {
            max =       new List<List<int>>();
            allocate =  new List<List<int>>();
            need =      new List<List<int>>();
            total =     new List<int>();
            available = new List<int>();
            safeList =  new List<int>();
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
        }
        public void setAllocate(DataGridView allocate)
        {
            this.allocate = dataGridTo2DList(allocate);
        }
        public void setTotal(DataGridView total)
        {
            this.total = dataGridTo1DList(total);
        }
        public List<List<int>> getNeed()
        {
            return need;
        }
        public string getSafeList()
        {
            string s = "";
            for(int i = 0; i < safeList.Count; i++)
            {
                s += "P" + safeList[i];
                if(i != safeList.Count-1) s += " -> ";
            }
            return s;
        }
        public bool safeCheck()
        {
            int process = 0;
            bool deadlock = true;
            List<int> work = new List<int>();
            List<bool> finish = new List<bool>();
            for (int j = 0; j < totalResourceType; j++)
            {
                work.Add(available[j]);
            }
            safeList.Clear();
            for (int i = 0; i < totalProcesses; i++)
            {
                finish.Add(false);
            }
            while (safeList.Count < totalProcesses)
            {
                if (process == totalProcesses)
                {
                    if (deadlock) return false;
                    else
                    {
                        deadlock = true;
                        process = 0;
                        continue;
                    }
                }
                if (finish[process] == false && isGreaterThan(work, need[process]))
                {
                    for (int j = 0; j < work.Count; j++)
                    {
                        work[j] += allocate[process][j];
                    }
                    
                    finish[process] = true;
                    safeList.Add(process+1);
                    deadlock = false;
                }
                process++;
            }
            return true;
        }
        public bool requestCheck(int process, List<int> resources)
        {
            List<int> save_available = new List<int>();
            List<List<int>> save_allocate = new List<List<int>>();
            List<List<int>> save_need = new List<List<int>>();

            for (int i = 0; i< totalProcesses; i++)
            {
                List<int> row_alloc = new List<int>();
                List<int> row_need = new List<int>();
                for (int j = 0; j < totalResourceType; j++)
                {
                    row_alloc.Add(allocate[i][j]);
                    row_need.Add(need[i][j]);
                }
                save_allocate.Add(row_alloc);
                save_need.Add(row_need);
            }
            for (int j = 0; j < totalResourceType; j++)
            {
                save_available.Add(available[j]);
            }

            if (isGreaterThan(resources, need[process])) return false;
            if (isGreaterThan(resources, available)) return false;

            for (int i = 0; i < totalResourceType; i++)
            {
                available[i] -= resources[i];
                allocate[process][i] += resources[i];
                need[process][i] -= resources[i];
            }

            bool result = safeCheck();

            available.Clear();
            allocate.Clear();
            need.Clear();  
            available = save_available;
            allocate = save_allocate;
            need = save_need;

            return result;
        }
        public bool calculateAvailable()
        {
            List<int> temp = new List<int>();
            List<int> temp_available = new List<int>();
            for (int i = 0; i < totalResourceType; i++)
            {
                int sum = 0;
                for(int j = 0; j < totalProcesses; j++)
                {
                    sum += allocate[j][i];
                }
                temp.Add(sum);
            }
            
            temp_available = total;
            for (int i = 0; i < totalResourceType; i++)
            {
                temp_available[i] -= temp[i];
                if (temp_available[i] < 0)
                {
                    MessageBox.Show("Tài nguyên của Allocate lớn hơn Tài nguyên của Total. Vui lòng nhập lại", "Lỗi");
                    return false;
                }
            }
            available = temp_available;
            
            return true;
        }

        public bool isNeedTableSave()
        {
            calculateNeed();
            return checkNeedTable(need);
        }
        private bool checkNeedTable(List<List<int>> need)
        {
            for (int i = 0; i < need.Count; i++)
            {
                for (int j = 0; j < need[i].Count; j++)
                {
                    if (need[i][j] < 0)
                    {
                        MessageBox.Show("Tài nguyên của Allocate đã lớn Max !");
                        return false;
                    }
                }
            }
            return true;
        }
        private void calculateNeed()
        {
            if (max.Count > 0 && allocate.Count > 0)
            {
                need = max;
                for (int i = 0; i < max.Count; i++)
                {
                    for (int j = 0; j < max[i].Count; j++)
                    {
                        need[i][j] -= allocate[i][j];
                    }
                }
            }
            else
            {
                MessageBox.Show("Không thể tính bảng Need");
            }
        }

        public void clear()
        {
            //totalProcesses = 0;
            //totalResourceType = 0;
            max.Clear();
            allocate.Clear();
            need.Clear();
            total.Clear();
            available.Clear();
            safeList.Clear();
        }

        //==========================================================================
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
        private bool isGreaterThan(List<int> a, List<int> b)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] < b[i]) return false;
            }
            return true;
        }
        private void check(string name, List<int> list)
        {
            string s = name + ": ";
            for (int i = 0; i < list.Count; i++)
            {
                s += list[i].ToString() + " ";
            }
            MessageBox.Show(s);
        }
        private void check(string name, List<List<int>> list)
        {
            string s = name + ": ";
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[0].Count; j++)
                {
                    s += list[i][j].ToString() + " ";
                }
                s += "- ";
            }
            MessageBox.Show(s);
        }
    }
}
