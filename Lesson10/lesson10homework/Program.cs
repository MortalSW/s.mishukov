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
        private static bool CanAccessFile(string FileName, FileAccess fileAccesMethod)
        {
            try
            {
                FileStream f = new FileInfo(FileName).Open(FileMode.Open, fileAccesMethod, FileShare.None);
                f.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot open " + FileName + " for "+fileAccesMethod);
                Console.WriteLine("Exception: " + ex.Message);
            }
            return false;
        }
        static void Main(string[] args)
        {
            //вот так мне не оч нравится. как лучше доставать директорию проекта?
            //уменьшив на 2 слэша от AppDomain.CurrentDomain.BaseDirectory - не вариант, то-же самое получается
            if (CanAccessFile(@"..\..\flowCards.Card.xml", FileAccess.Read))
            {
                string text = File.ReadAllText(@"..\..\flowCards.Card.xml");
                XElement[] contactValues = XElement.Parse(text).Element("Contacts").Elements().ToArray();
                
                if (CanAccessFile(@"..\..\p:romoContacts", FileAccess.Write) && 
                    CanAccessFile(@"..\..\usualContacts", FileAccess.Write))
                {
                
                    using (StreamWriter promoContactsFile = new StreamWriter(@"..\..\promoContacts"))
                    using (StreamWriter usualContactsFile = new StreamWriter(@"..\..\usualContacts"))
                    {
                        foreach (XElement contactValue in contactValues)
                        {
                            if (contactValue.Attribute("IsPromotional").Value == "true")
                            {
                                promoContactsFile.WriteLine(contactValue.Attribute("Value").Value + " [" + 
                                    (contactValue.Attribute("Description") == null ? "" : contactValue.Attribute("Description").Value.ToString()) + "]");
                            }
                            else
                            {
                                usualContactsFile.WriteLine(contactValue.Attribute("Value").Value + " [" + 
                                    (contactValue.Attribute("Description") == null ? "" : contactValue.Attribute("Description").Value.ToString()) + "]");
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
