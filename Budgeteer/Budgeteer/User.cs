using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgeteer
{
    public static class User
    {
        private static String userName;
        public static String UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        private static String newItemString;
        public static String NewItemString
        {
            get
            {
                return newItemString;
            }
            set
            {
                newItemString = value;
            }
        }

        private static String newItemCategory;
        public static String NewItemCategory
        {
            get
            {
                return newItemCategory;
            }
            set
            {
                newItemCategory = value;
            }
        }

        private static String theDate;
        public static String TheDate
        {
            get
            {
                return theDate;
            }
            set
            {
                theDate = value;
            }
        }

        static public void LoadBudget()
        {
            if (File.Exists("savedBudget.txt"))
            {
                string[] savedData = File.ReadAllLines("savedBudget.txt");
            }
            else
            {
                var fileStream = new FileStream("savedBudget.txt", FileMode.Create);
                try
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(User.NewItemCategory + ";" + User.NewItemString);
                    fileStream.Write(bytes, 0, bytes.Length);
                }
                finally
                {
                    fileStream.Close();
                }
            }
        }
    }
}
