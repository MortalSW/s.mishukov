using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class Phone
    {
        private int cityCode = -1;
        private uint phone;

        public Phone(int cityCode, uint phone)
        {
            this.cityCode = cityCode;
            this.phone = phone;
        }
        public Phone(uint phone)
        {
            this.cityCode = -1;
            this.phone = phone;
        }

        public override string ToString()
        {
            if (cityCode != -1)
            {
                return $"({cityCode}) {phone}";
            }
            else {
                return $"{phone}";
            }

        }

    }
}
