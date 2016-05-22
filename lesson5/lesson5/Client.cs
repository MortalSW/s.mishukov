using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class Client
    {
        public Guid identifier { get; private set; }
        public Phone phone { get; set; }
        public uint summOfOrder { get; set; }

        public Client()
        {
            identifier = Guid.NewGuid();
        }


    }
}
