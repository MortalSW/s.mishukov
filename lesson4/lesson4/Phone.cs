using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Phone
    {
        private int cityCode = -1;
        private int phone;

        public Phone(int cityCode,int phone)
        {
            this.cityCode = cityCode;
            this.phone = phone;
        }
        public Phone(int phone)
        {
            this.cityCode = -1;
            this.phone = phone;
        }

        public override string ToString()
        {
            string result = "";
            if (cityCode != -1)
            {
                result = $"({cityCode}) {phone}";
            }
            else {
                result = $"{phone}";
            }
            return result;
        }

    }
}
