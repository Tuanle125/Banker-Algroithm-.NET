﻿using System;
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
            calculateNeed();
            return need;
        }

        public bool safeCheck()
        {
            calculateAvailable();
            int process = 0;
            bool deadlock = true;
            List<int> work = available;
            List<bool> finish = new List<bool>();

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
                bool found = false;
                for (int i = 0; i < totalProcesses; i++)
                {
                    if (finish[i] == false && isGreaterThan(work, need[i]))
                    {
                        found = true;
                        process = i;
                        break;
                    }
                }
                if (!found)
                {
                    process++;
                    continue;
                }
                if (finish[process] == false)
                {
                    for (int j = 0; j < work.Count; j++)
                    {
                        work[j] += allocate[process][j];
                    }
                    finish[process] = true;
                    safeList.Add(process);
                    deadlock = false;
                }
                process++;
            }
            return true;
        }
   
        private void calculateAvailable()
        {
            List<int> temp = new List<int>();
            for(int i = 0; i < totalResourceType; i++)
            {
                int sum = 0;
                for(int j = 0; j < totalProcesses; j++)
                {
                    sum += allocate[j][i];
                }
                temp.Add(sum);
            }
            available = total;
            for (int i = 0; i < totalResourceType; i++)
            {
                available[i] -= temp[i];
                if (available[i] < 0)
                {
                    MessageBox.Show("Lỗi tính toán. Giá trị của available không được âm. Vui lòng nhập lại", "Lỗi");
                    return;
                }
            }
        }
        private bool checkNeedTable(List<List<int>> need)
        {
            for (int i = 0; i < need.Count; i++)
            {
                for (int j = 0; j < need[i].Count; j++)
                {
                    if (need[i][j] < 0)
                    {
                        MessageBox.Show("Need table contains negative values");
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
                if (checkNeedTable(need))
                {
                    MessageBox.Show("Need table created");
                }
            }
            else
            {
                MessageBox.Show("Can't calculate Need table");
            }
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
        private bool isGreaterThan(List<int> a, List<int> b)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] < b[i]) return false;
            }
            return true;
        }
        private void check(List<int> list)
        {
            string s = "";
            for (int i = 0; i < totalResourceType; i++)
            {
                s += list[i].ToString() + " ";
            }
            MessageBox.Show(s);
        }
    }
}
