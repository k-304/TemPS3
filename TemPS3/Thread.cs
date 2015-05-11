using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemPS3
{
    class Thread
    {
        private System.Threading.ThreadStart threadStart;

        public Thread(System.Threading.ThreadStart threadStart)
        {
            // TODO: Complete member initialization
            this.threadStart = threadStart;
        }
    }
}
