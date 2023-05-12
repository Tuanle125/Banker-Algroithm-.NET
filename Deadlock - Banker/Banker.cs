using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public setTotalProcesses(int totalProcesses)
        {
            this.totalProcesses = totalProcesses;
        }
        public setTotalResourceType(int totalResourceType)
        {
            this.totalResourceType = totalResourceType;
        }

        /*
        public Banker(int totalProcesses, int totalResourceType, List<List<int>> max, List<List<int>> allocate, List<int> available)
        {
            this.totalProcesses = totalProcesses;
            this.totalResourceType = totalResourceType;
            this.max = max;
            this.allocate = allocate;
            this.need = need;
            this.available = available;
        }
        */



    }
}
