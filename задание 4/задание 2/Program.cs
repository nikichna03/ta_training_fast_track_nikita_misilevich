using System;
using System.Linq;
using System.Xml;

namespace задание_4
{
    class Program
    {
        public static void Main()
        {
            Шасси авто = new Шасси(0, 0, 9.9, 0, "***", "***", 9.9, 9.9, true, "***");
            Шасси грузовик = new Шасси(1, 1, 1.1, 1, "+++", "+++", 1.1, 1.1, false, "+++");
            Шасси автобус = new Шасси(2, 2, 2.2, 2, "---", "---", 2.2, 2.2, true, "---");
            Шасси Скутер = new Шасси(3, 3, 3.3, 3, "000", "000", 3.3, 3.3, false, "000");
            Шасси[] avto = { авто, грузовик, автобус, Скутер };

            Console.WriteLine("--------------------------------------\nавто");
            avto[0].Text();

            Console.WriteLine("--------------------------------------\nгрузовик");
            avto[1].Text();

            Console.WriteLine("--------------------------------------\nавтобус");
            avto[2].Text();

            Console.WriteLine("--------------------------------------\nСкутер");
            avto[3].Text();

            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("avto");
            xmlDoc.AppendChild(rootNode);

            for (int i = 0; i < avto.Length; i++)
                if (avto[i].size >= 1.5)
                {
                    ff(avto[i], i, xmlDoc, rootNode);
                    xmlDoc.Save("XMLFile1.xml");
                }

            XmlDocument xmlDoc1 = new XmlDocument();
            XmlNode rootNode1 = xmlDoc1.CreateElement("avtoо");
            xmlDoc1.AppendChild(rootNode1);
            for (int i = 2; i < 3; i++)
                ff(avto[i], i, xmlDoc1, rootNode1);
            xmlDoc1.Save("XMLFile.xml");


            XmlDocument xmlDoc2 = new XmlDocument();
            XmlNode rootNode2 = xmlDoc2.CreateElement("avt0");
            xmlDoc2.AppendChild(rootNode2);
            for (int i = 0; i < avto.Length; i++)
                ff(avto[i], i, xmlDoc2, rootNode2);
            xmlDoc2.Save("XMLFile2.xml");
        }
        public static void ff(Шасси avto, int i, XmlDocument xmlDoc, XmlNode rootNode)
        {
            XmlNode userNode = xmlDoc.CreateElement("avto" + (i + 1));
            ///двигатель
            XmlAttribute attribute = xmlDoc.CreateAttribute("мощность");
            attribute.Value = avto.power.ToString();
            userNode.Attributes.Append(attribute);
            XmlAttribute attribute1 = xmlDoc.CreateAttribute("обьем");
            attribute1.Value = avto.size.ToString();
            userNode.Attributes.Append(attribute1);
            XmlAttribute attribute2 = xmlDoc.CreateAttribute("тип_дв");
            attribute2.Value = avto.type.ToString();
            userNode.Attributes.Append(attribute2);
            XmlAttribute attribute3 = xmlDoc.CreateAttribute("номер_серии");
            attribute3.Value = avto.id.ToString();
            userNode.Attributes.Append(attribute3);
            ///трансмиссия
            XmlAttribute attribute4 = xmlDoc.CreateAttribute("тип_трнсм");
            attribute4.Value = avto.broadcast.ToString();
            userNode.Attributes.Append(attribute4);
            XmlAttribute attribute5 = xmlDoc.CreateAttribute("передачи");
            attribute5.Value = avto.typ.ToString();
            userNode.Attributes.Append(attribute5);
            XmlAttribute attribute6 = xmlDoc.CreateAttribute("производитель");
            attribute6.Value = avto.manufacturer.ToString();
            userNode.Attributes.Append(attribute6);
            ///Шасси
            XmlAttribute attribute7 = xmlDoc.CreateAttribute("количество_колес");
            attribute7.Value = avto.wheel.ToString();
            userNode.Attributes.Append(attribute7);
            XmlAttribute attribute8 = xmlDoc.CreateAttribute("номер");
            attribute8.Value = avto.numer.ToString();
            userNode.Attributes.Append(attribute8);
            XmlAttribute attribute9 = xmlDoc.CreateAttribute("нагрузка");
            attribute9.Value = avto.load.ToString();
            userNode.Attributes.Append(attribute9);
            rootNode.AppendChild(userNode);
        }
    }
}