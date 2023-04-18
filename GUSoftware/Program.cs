using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GUSoftware
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XmlDocument config = new XmlDocument();
            config.Load("config.xml");

            string AuthDomain = config.DocumentElement.SelectSingleNode("/FireBase/AuthDomain").InnerText.Trim();
            string ApiKey = config.DocumentElement.SelectSingleNode("/FireBase/ApiKey").InnerText.Trim();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login(AuthDomain, ApiKey));
        }
    }
}
