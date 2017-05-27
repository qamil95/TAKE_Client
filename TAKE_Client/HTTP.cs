using System;
using System.IO;
using System.Net;
using System.Text;
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

        public static string NewTeacher(string name, string surname)
        {
            XElement request =
                    new XElement("teacher",
                        new XElement("firstName", name),
                        new XElement("lastName", surname)
                    );
            return DoPost("teacher", request);
        }
    }
}
