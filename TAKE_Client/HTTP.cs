using System;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace TAKE_Client
{
    static class HTTP
    {
        static string server = "http://localhost:8080/take/surveyization/";

        static string DoPost(string url, XElement XMLrequest)
        {
            WebRequest request = WebRequest.Create(server + url);
            request.Method = "POST";
            request.ContentType = "application/xml";
            byte[] bytes = Encoding.UTF8.GetBytes(XMLrequest.ToString());
            request.ContentLength = bytes.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(bytes, 0, bytes.Length);
            dataStream.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string textResponse = response.StatusDescription;
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            textResponse += Environment.NewLine + reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return textResponse;
        }

        static string DoGet(string url)
        {
            WebRequest request = WebRequest.Create(server + url);
            request.Method = "GET";
            request.ContentType = "application/xml";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string textResponse = reader.ReadToEnd();
            reader.Close();
            response.Close();
            return textResponse;
        }

        public static string NewTeacher(string name, string surname)
        {
            XElement request =
                    new XElement("teacher",
                        new XElement("firstName", name),
                        new XElement("lastName", surname)
                    );
            return DoPost("teacher", request);
        }

        public static string NewSurvey(string date, string description, string[] questions)
        {
            XElement request =
                new XElement("survey",
                    new XElement("date", date),
                    new XElement("descritpion", description)
                    );
            foreach (string question in questions)
                request.Add(new XElement("questions", new XElement("text", question)));
            return DoPost("survey", request);
        }

        public static string GetTeachers()
        {
            StringBuilder output = new StringBuilder();

            String xmlString = DoGet("teacher");
            // Create an XmlReader
            using (XmlReader reader = XmlReader.Create(new StringReader(xmlString)))
            {
                XmlWriterSettings ws = new XmlWriterSettings();
                ws.Indent = true;
                ws.OmitXmlDeclaration = true;
                using (XmlWriter writer = XmlWriter.Create(output, ws))
                {

                    // Parse the file and display each of the nodes.
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element:
                                //writer.WriteStartElement(reader.Name);      
                                writer.WriteStartElement(reader.Name + reader.GetAttribute("idt"));
                                break;
                            case XmlNodeType.Text:
                                writer.WriteString(reader.Value);
                                break;
                            case XmlNodeType.XmlDeclaration:
                            case XmlNodeType.ProcessingInstruction:
                                writer.WriteProcessingInstruction(reader.Name, reader.Value);
                                break;
                            case XmlNodeType.Comment:
                                writer.WriteComment(reader.Value);
                                break;
                            case XmlNodeType.EndElement:
                                writer.WriteFullEndElement();
                                break;
                        }
                    }

                }
            }
            return output.ToString();
        }
    }
}
