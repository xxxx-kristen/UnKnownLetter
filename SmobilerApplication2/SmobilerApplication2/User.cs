using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace SmobilerApplication2
{
    public class User
    {
        [Key]
        public int UserID { set; get; }
        public string UserName { set; get; }
        public string UserLetter1 { get; set; }
        public string UserLetter2 { get; set; }
        public string UserLetter3 { get; set; }
        public string UserLetter4 { get; set; }
        public string UserLetter5 { get; set; }
        public int UserProcess { set; get; }
        public bool UserSend { set; get; }
        public User()
        {
        }
        public User(int userID, string userName,
            string userLetter1, string userLetter2, string userLetter3, string userLetter4, string userLetter5,
            int userProcess, bool userSend)
        {
            this.UserID = userID;
            this.UserName = userName;
            this.UserLetter1 = userLetter1;
            this.UserLetter2 = userLetter2;
            this.UserLetter3 = userLetter3;
            this.UserLetter4 = userLetter4;
            this.UserLetter5 = userLetter5;
            this.UserProcess = userProcess;
            this.UserSend = userSend;
        }
        ~User()
        {
        }
        void setletter(int i)
        {

        }
        public void showUser()
        {
            Console.WriteLine("" + UserID);
            Console.WriteLine(UserName);
            Console.WriteLine(UserLetter1);
            Console.WriteLine(UserLetter2);
            Console.WriteLine(UserLetter3);
            Console.WriteLine(UserLetter4);
            Console.WriteLine(UserLetter5);
            Console.WriteLine("" + UserProcess);
            Console.WriteLine(UserSend);
        }

    }
}
