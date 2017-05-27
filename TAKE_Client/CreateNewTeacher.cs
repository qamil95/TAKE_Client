using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml.Linq;
using System.IO;

namespace TAKE_Client
{
    public partial class CreateNewTeacher : UserControl
    {
        public CreateNewTeacher()
        {
            InitializeComponent();
        }

        private void buttonCreateTeacher_Click(object sender, EventArgs e)
        {
            if ((textBoxName.Text != String.Empty) && (textBoxSurname.Text !=String.Empty))
            {
                WebRequest request = WebRequest.Create("http://localhost:8080/take/surveyization/teacher");
                request.Method = "POST";
                request.ContentType = "application/xml";
                XElement requestXML =
                    new XElement("teacher",
                        new XElement("firstName", textBoxName.Text),
                        new XElement("lastName", textBoxSurname.Text)
                    );
                byte[] bytes = Encoding.UTF8.GetBytes(requestXML.ToString());
                request.ContentLength = bytes.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(bytes, 0, bytes.Length);
                dataStream.Close();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string textResponse = reader.ReadToEnd();
                MessageBox.Show(response.StatusDescription + Environment.NewLine + textResponse);
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            else
            {
                MessageBox.Show("Enter name and surname!");
            }            
        }
    }
}
