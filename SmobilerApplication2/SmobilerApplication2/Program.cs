using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SmobilerApplication2;

static class Program
{
    /// <summary>
    /// 应用程序的主入口点。
    /// </summary>
    [STAThread]
    static void Main()
    {
        //DatabaseService a = new DatabaseService();
        //User user = a.Find(10);
        //user = new User();
        //user.UserID = 10;
        //a.Add(user);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new frmMain());
    }
}