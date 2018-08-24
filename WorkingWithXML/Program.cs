using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WorkingWithXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Example01();

            Example02();
        }
        
        //Creating Xml document 
        static void Example01()
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlDeclaration declaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", "");
            xmlDoc.AppendChild(declaration);

            XmlElement root = xmlDoc.CreateElement("users");
            XmlElement user = xmlDoc.CreateElement("user");
            XmlElement email = xmlDoc.CreateElement("email");
            XmlElement surname = xmlDoc.CreateElement("surname");
            XmlElement name = xmlDoc.CreateElement("name"); //Creating attribute
            //XML view: <name></name>

            name.InnerText = "Matthew";
            surname.InnerText = "Reyes";
            email.InnerText = "matthew.reyes51@example.com";

            //Appending Xml nodes
            user.AppendChild(name);
            user.AppendChild(surname);
            user.AppendChild(email);

            root.AppendChild(user);

            //Finally adding all root to Xml document
            xmlDoc.AppendChild(root);

            //Saving Xml document in root your solution
            xmlDoc.Save("Guy.xml");
        }

        //Example of loading Xml document by link
        static void Example02()
        {
            XmlDocument document = new XmlDocument();
            document.Load("https://www.w3schools.com/xml/simple.xml");

            //Returning root of Xml document
            XmlElement root = document.DocumentElement; 

            //Getting all children(attributes) in Xml
            foreach(XmlNode chidren in root.ChildNodes)
            {
                Console.WriteLine(chidren.Name);
            }
        }
    }
}