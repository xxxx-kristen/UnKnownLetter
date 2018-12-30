using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerApplication2
{
    partial class SmobilerForm3 : Smobiler.Core.Controls.MobileForm
    {
        public User user;
        public SmobilerForm3() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }

        public SmobilerForm3(User _user):base()
        {
            user = _user;
            InitializeComponent();
        }

        private void button1_Press(object sender, EventArgs e)
        {
            switch (user.UserProcess)
            {
                case 0: user.UserLetter1 = textBox1.Text;break;
                case 1: user.UserLetter2 = textBox1.Text; break;
                case 2: user.UserLetter3 = textBox1.Text; break;
                case 3: user.UserLetter4 = textBox1.Text; break;
                case 4: user.UserLetter5 = textBox1.Text; break;
            }
            user.UserProcess++;
            if (user.UserProcess>=5)
            {
                DatabaseService databaseService = new DatabaseService();
                databaseService.Add(user);
                SmobilerForm4 smobilerForm4 = new SmobilerForm4();
                this.Form.Show(smobilerForm4);
            }
            else
            {
                SmobilerForm3 smobilerForm3 = new SmobilerForm3(user);
                smobilerForm3.BackgroundImage = "write" + (user.UserProcess + 1);
                this.Form.Show(smobilerForm3);
            }
        }

        private void SmobilerForm3_Load(object sender, EventArgs e)
        {
            //label1.Text = "第" + (user.UserProcess + 1) + "个问题";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}