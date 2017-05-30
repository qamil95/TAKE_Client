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

        public static string GetSurveys()
        {
            return DoGet("survey");
            
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
                    new XElement("description", description)
                    );
            foreach (string question in questions)
                request.Add(new XElement("questions", new XElement("text", question)));
            return DoPost("survey", request);
        }

        public static string GetTeachers()
        {
            return DoGet("teacher");          
        }
    }
}
