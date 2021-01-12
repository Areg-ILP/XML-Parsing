using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Testing_XML
{
    public class XMLManager
    {        
        private XmlDocument xDoc;
        private XmlElement xRoot;
        private XmlElement userElem;
        private XmlAttribute attrId;        
        private XmlElement elementName;
        private XmlElement elementSurName;

        private string _path;        

        public XMLManager(string path)
        {
            _path = path;
            xDoc = new XmlDocument();             
            xDoc.Load(_path);
            xRoot = xDoc.DocumentElement;
        }

        public void AddNode(User user)
        {
            CreateNode();
            XmlText idText = xDoc.CreateTextNode(user.Id.ToString());
            XmlText nameText = xDoc.CreateTextNode(user.Name);
            XmlText surnameText = xDoc.CreateTextNode(user.SurName);
            
            attrId.AppendChild(idText);
            elementName.AppendChild(nameText);
            elementSurName.AppendChild(surnameText);

            userElem.Attributes.Append(attrId);
            userElem.AppendChild(elementName);
            userElem.AppendChild(elementSurName);

            xRoot.AppendChild(userElem);
            xDoc.Save(_path);
        }

        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            foreach (XmlNode xNode in xDoc.DocumentElement)            
                users.Add(new User(xNode["name"].InnerText, xNode["surname"].InnerText) { Id = xNode.Attributes[0].Value.ToString() });           
            return users;
        }

        public void Edit(User user)
        {
            foreach (XmlNode xNode in xDoc.DocumentElement)
            {
                if (xNode.Attributes[0].Value.ToString() == user.Id)
                {
                    xNode.FirstChild.InnerText = user.Name;
                    xNode.LastChild.InnerText = user.SurName;
                }
            }
            xDoc.Save(_path);
        }

        public void Delete(string id)
        {
            foreach(XmlNode xNode in xDoc.DocumentElement)
            {
                if (xNode.Attributes[0].Value.ToString() == id)
                    xRoot.RemoveChild(xNode);
            }
            xDoc.Save(_path);
        }

        public void DeleteRange(List<string> ids)
        {
            //mb
        }

        private void CreateNode()
        {
            userElem = xDoc.CreateElement("user");
            attrId = xDoc.CreateAttribute("id");
            elementName = xDoc.CreateElement("name");
            elementSurName = xDoc.CreateElement("surname");
        }
    }
}
