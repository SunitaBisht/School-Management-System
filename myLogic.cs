using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class myLogic
    {
        public static String getid()
        {
            String c_data = DateTime.Now.ToString();
            String id = "";
            foreach (char ch in c_data)
            {
                if (ch >= '0' && ch <= '9')
                {
                    id = id + ch;
                }
            }
            if (id.Length == 12)
            {
                id = id.Remove(3, 4);
            }
            else if (id.Length == 13)
            {
                id = id.Remove(4, 4);
            }
            return (id);
        }
        public static string getRandom()
        {
            Random rd = new Random();

            string r_num = rd.Next(1, 5000).ToString();
            return (r_num);
        }
    }
}
