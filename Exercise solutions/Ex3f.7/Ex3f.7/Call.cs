using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3f._7
{
    //for exercise 3f.A
    class Call
    {

        DateTime callStarted;
        TimeSpan callDuration;

        public Call(DateTime callStarted, TimeSpan callDuration)
        {
            this.callStarted = callStarted;
            this.callDuration = callDuration;
        }
    }
}
