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
        private static void rethrowEx(string fileName, Exception ex)
        {
            Console.WriteLine("Cannot open " + fileName);
            Console.WriteLine("Exception: " + ex.Message);
        }
        static void Main(string[] args)
        {
            string cardFile = @"..\..\flowCards.Card.xml";
            XElement[] contactValues;
            try
            {
                string text = File.ReadAllText(cardFile);
                contactValues = XElement.Parse(text).Element("Contacts").Elements().ToArray();

                string promoFileName = @"..\..\promoContacts";
                string usualFileName = @"..\..\usualContacts";
                try
                {
                    using (StreamWriter promoContactsFile = new StreamWriter(promoFileName))
                    try
                    {
                        using (StreamWriter usualContactsFile = new StreamWriter(usualFileName))
                        {
                            foreach (XElement contactValue in contactValues)
                            {
                                if (Convert.ToBoolean(contactValue.Attribute("IsPromotional").Value))
                                {
                                    promoContactsFile.WriteLine(contactValue.Attribute("Value").Value + " [" +
                                        (contactValue.Attribute("Description") == null ? "" : contactValue.Attribute("Description").Value) + "]");
                                }
                                else
                                {
                                    usualContactsFile.WriteLine(contactValue.Attribute("Value").Value + " [" +
                                        (contactValue.Attribute("Description") == null ? "" : contactValue.Attribute("Description").Value) + "]");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        rethrowEx(usualFileName, ex);
                    }
                }
                catch (Exception ex)
                {
                    rethrowEx(promoFileName, ex);
                }
            }
            catch (Exception ex)
            {
                rethrowEx(cardFile, ex);
            }

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
