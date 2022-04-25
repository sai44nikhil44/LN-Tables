using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace XMLGeneration
{
    class Program
    {
        public static string server = "";
        public static string user = "";
        public static string pwd = "";
        public static bool registered = false;
        public static void Generate(string server, string user, string pass, bool reg)
        {
            try
            {
                using (ResourceWriter rw = new ResourceWriter(@"UserData.xml"))
                {
                    rw.AddResource("Server", server);
                    rw.AddResource("User", user);
                    rw.AddResource("Password", pass);
                    rw.AddResource("Registered", reg);
                    Console.WriteLine("Successfully Created");

                    rw.Close();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void GetData()
        {
            try
            {
                //Console.WriteLine("Resources in ApplicationResources.resources:");
                ResourceReader res = new ResourceReader(@"UserData.xml");
                IDictionaryEnumerator dict = res.GetEnumerator();
                IDictionary<string, object> dt = new Dictionary<string, object>();
                while (dict.MoveNext())
                {
                    dt.Add((string)dict.Key, dict.Value);
                }
                server = (string)dt["Server"];
                Console.WriteLine(server);
                user = (string)dt["User"];
                Console.WriteLine(user);
                pwd = (string)dt["Password"];
                Console.WriteLine(pwd);
                registered = (bool)dt["Registered"];
                res.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            GetData();
            Generate("INHYNSTALLADA1", "sa", "sa", false);
            
            Console.ReadKey();
        }
    }
}
