using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace lesson10homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //вот так мне не оч нравится. как лучше доставать директорию проекта?
            //уменьшив на 2 слэша от AppDomain.CurrentDomain.BaseDirectory - не вариант, то-же самое получается
            string text = File.ReadAllText(@"..\..\flowCards.Card.xml"); 
            XElement[] contactValues = XElement.Parse(text).Element("Contacts").Elements().ToArray();

            try
            {
                using (StreamWriter promoContactsFile = new StreamWriter(@"..\..\promo:Contacts"))
                using (StreamWriter usualContactsFile = new StreamWriter(@"..\..\usualContacts"))
                {
                    foreach (XElement contactValue in contactValues)
                    {
                        if (contactValue.Attribute("IsPromotional").Value == "true")
                        {
                            promoContactsFile.WriteLine(contactValue.Attribute("Value").Value + " [" + (contactValue.Attribute("Description") == null ? "" : contactValue.Attribute("Description").Value.ToString()) + "]");
                        }
                        else
                        {
                            usualContactsFile.WriteLine(contactValue.Attribute("Value").Value + " [" + (contactValue.Attribute("Description") == null ? "" : contactValue.Attribute("Description").Value.ToString()) + "]");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Не смог записать в один из файлов");
                Console.ReadKey();
            }
            // как бы вот так правильно try|catch. ну если мне не нужно сообщать что-то, пока не закрыл открытое.
            // но как понять в каком файле проблема? или печально делить на 2 шага? сначала писать в файло рекламные, 
            // потом в другом using - обычные?
        }
    }
}
