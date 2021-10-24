using System;
using System.Collections.Generic;
using System.Text;

namespace FristTestApp
{
    class Employee : IEmployee
    {
        public string currentStatus;

        public void run()
        {
            this.currentStatus = "Running";
        }
    }
}
