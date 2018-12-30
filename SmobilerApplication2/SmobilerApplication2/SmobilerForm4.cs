using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerApplication2
{
    partial class SmobilerForm4 : Smobiler.Core.Controls.MobileForm
    {
        public User user;
        public int k;
        public SmobilerForm4() : base()
        {
            //This call is required by the SmobilerForm.
            k = 0;
            DatabaseService databaseService = new DatabaseService();
            int a = databaseService.randomRow();
            user = databaseService.Find(a);
            InitializeComponent();   
        }
        public SmobilerForm4(User _user,int _k):base()
        {
            user = _user;
            k = _k;
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SmobilerForm4_Load(object sender, EventArgs e)
        {
           
           // Console.WriteLine(user.UserLetter1);
            // textBox1.Text = "这是一封信\n" + "第一个回答" + "\n" + user.UserLetter1 + "\n第二个回答\n" + user.UserLetter2
            //  + "\n第三个回答\n" + user.UserLetter3 + "\n第四个回答\n" + user.UserLetter4 + "\n第五个回答\n" + user.UserLetter5;     
            this.BackgroundImage = "write" + (k + 1);
            switch (k)
            {
                case 0:textBox1.Text = user.UserLetter1;break;
                case 1: textBox1.Text = user.UserLetter2; break;
                case 2: textBox1.Text = user.UserLetter3; break;
                case 3: textBox1.Text = user.UserLetter4; break;
                case 4: textBox1.Text = user.UserLetter5; break;
            }
        }

        private void button1_Press(object sender, EventArgs e)
        {
            k++;
            if(k<5)
            {
                SmobilerForm4 smobilerForm4 = new SmobilerForm4(user, k);
                smobilerForm4.Show(smobilerForm4);
            }else
            {
                SmobilerForm5 smobilerForm5 = new SmobilerForm5(user);
                smobilerForm5.Show(smobilerForm5);
            }
        }
    }
}