using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerApplication2
{
    partial class SmobilerForm5 : Smobiler.Core.Controls.MobileForm
    {
        public User user;
        public SmobilerForm5() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        public SmobilerForm5(User _user)
        {
            user = _user;
            InitializeComponent();
        }
        private void button1_Press(object sender, EventArgs e)
        {
            MessageBox.Show("他/她的微信号是:"+user.UserName+"\n和他/她进一步交流吧！");
           // SmobilerForm1 smobilerForm1 = new SmobilerForm1();
           // smobilerForm1.Show(smobilerForm1);
        }

        private void button2_Press(object sender, EventArgs e)
        {
            DatabaseService databaseService = new DatabaseService();
            int i = databaseService.randomRow();
            SmobilerForm4 smobilerForm4 = new SmobilerForm4(databaseService.Find(i), 0);
            smobilerForm4.Show(smobilerForm4);
        }

        private void SmobilerForm5_Load(object sender, EventArgs e)
        {

        }
    }
}