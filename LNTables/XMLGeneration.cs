using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LNTables
{
    class XMLGeneration
    {
        public static string server = "";
        public static string user = "";
        public static string pwd = "";
        public static bool registered = false;
        public static void Generate(string server, string user, string pass, bool reg)
        {
            try
            {
                using (ResourceWriter rw = new ResourceWriter(@".\UserData.xml"))
                {
                    rw.AddResource("Server", server);
                    rw.AddResource("User", user);
                    rw.AddResource("Password", pass);
                    rw.AddResource("Registered", reg);
                    MessageBox.Show("Successfully Created");
                    
                    rw.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void GetData()
        {
            try
            {
                //Console.WriteLine("Resources in ApplicationResources.resources:");
                ResourceReader res = new ResourceReader(@".\UserData.xml");
                IDictionaryEnumerator dict = res.GetEnumerator();
                IDictionary<string, object> dt = new Dictionary<string, object>();
                while(dict.MoveNext())
                {
                    dt.Add((string)dict.Key, dict.Value);
                }
                server = (string)dt["Server"];
                user = (string)dt["User"];
                pwd = (string)dt["Password"];
                registered = (bool)dt["Registered"];
                res.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
