using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _8._6._4
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Введите данные абонента");
			Console.WriteLine("ФИО: ");
			string name = Console.ReadLine();
			Console.WriteLine("Улица: ");
			string street = Console.ReadLine();
            Console.WriteLine("Номер дома: ");
            string houseNumber = Console.ReadLine();
            Console.WriteLine("Номер квартиры: ");
            string apartmentNumber = Console.ReadLine();
            Console.WriteLine("Мобильный телефон: ");
            string mobilePhone = Console.ReadLine();
            Console.WriteLine("Домашний телефон: ");
            string homePhone = Console.ReadLine();


            XElement personElement = new XElement("Abonent",
                new XAttribute("name", name),
                new XElement("Address",
                    new XElement("Stree", street),
                    new XElement("HouseNumber", houseNumber),
                    new XElement("ApartamentNumber", apartmentNumber)
                    ),
                new XElement("Phones",
                    new XElement("MobilePhone", mobilePhone),
                    new XElement("HomePhone", homePhone)
                    )
                );
            XDocument xmlDoc = new XDocument();
            xmlDoc.Save("Abonents.xml");
            Console.WriteLine("Абонент созранен в файл Abonents.xml");
            Console.ReadKey();
        }
	}
}
