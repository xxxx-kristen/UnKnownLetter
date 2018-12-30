using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SmobilerApplication2
{
    public class DatabaseService
    {
        public int getLength()  //获取数据库的总行数
        {
            using (var db = new EFDbContext())
            {
                return db.Users.Count();
            }
        }

        public int randomRow()  //生成一个在表的行数范围内的随机数
        {

            //  Thread.Sleep(300);  //Random()以当前时间作为随机数种子，为防止演示时生成太快导致生成的随机数相同可以加入此句。

            Random random = new Random();
            return random.Next(getLength()) + 1;
        }

        public void Add(User user)  //向数据库中添加一条记录
        {
            using (var db = new EFDbContext())
            {
              //  user.UserID = db.Users.Count();
                db.Users.Add(user);     //此处引起的异常通过修改.config修复
                db.SaveChanges();
            }
        }

        public int Search(string name)  //返回数据库中userName值为name的记录的行号（userID），若没有找到则返回-1
        {
            using (var db = new EFDbContext())
            {
                User user = db.Users.SingleOrDefault(o => o.UserName == name);
                if (user == null) { return -1; }
                else return user.UserID;
            }
        }

        public void Edit(User user) //将user.userID所在行的数据更新为user
        {
            using (var db = new EFDbContext())
            {
                db.Users.Attach(user);
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public User Find(int row)  //返回数据库中第row行(userID为row)的对象
        {
            using (var db = new EFDbContext())
            {
                return db.Users.SingleOrDefault(o => o.UserID == row);
            }
        }

        //public static void Main()
        //{
        //    //using (var context = new EFDbContext())
        //    // {
        //    //     /*
        //    //     context.Set<user>().Add(new user
        //    //     { UserID = 1, UserName = "冯文翰", UserSend = false,
        //    //         UserLetter1="a",UserLetter2="b",UserLetter3="c",UserLetter4="d",UserLetter5="e", UserProcess=5});

        //    //     */
        //    //     User user1 = new User(1, "冯文翰", "a", "b", "c", "d", "e", 5, true);
        //    //     context.Set<User>().Add(user1);
        //    //     context.SaveChanges();
        //    //     List<User> users = context.Set<User>().ToList();
        //    //     foreach(User p in users)
        //    //     {
        //    //         Console.WriteLine("" + p.UserID + p.UserName);
        //    //     }
        //    // }
        //    DatabaseService databaseService = new DatabaseService();
        //     User user1 = new User(4, "陈志鹏", "a", "b", "c", "d", "e", 5, true);
        //    databaseService.Edit(user1);
        //    //databaseService.Add(user1);
        //   // int a = databaseService.Search("陈志鹏");
        //    User user2 = databaseService.Find(2);
        //    int b = databaseService.getLength();
        //    int c = databaseService.randomRow();
        //    Console.WriteLine(c);
        //    Thread.Sleep(100);
        //    c = databaseService.randomRow();
        //    Console.WriteLine(c);
        //    Thread.Sleep(100);
        //    c = databaseService.randomRow();
        //    Console.WriteLine(c);


        // }
    }
}
