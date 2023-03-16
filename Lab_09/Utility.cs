using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09
{
    internal class Utility
    {
        internal static List<User> users= new List<User>();

        public static void load_users()
        {
            string path = $@"E:\Visual Studio\SWE_4202_210042137\Lab_09\userid.txt";
            StreamReader srr = new StreamReader(path);

            var strr = srr.ReadLine();

            while (strr != null)
            {

                string[] k = null;
                k = strr.Split(',');
                string user_name = k[0];
                string pass = k[1];
                string name = k[2];

                User u = new User(user_name, pass, name);
                users.Add(u);
                strr = srr.ReadLine();
                srr.Close();
            }
            srr.Close();
        }
    }
}
