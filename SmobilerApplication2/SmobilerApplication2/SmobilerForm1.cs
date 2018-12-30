using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerApplication2
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        public SmobilerForm1() : base()
        {
            InitializeComponent();
        }

        private void SmobilerForm1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Press(object sender, EventArgs e)
        {

            //User user = new User();
            //user.UserName = textBox1.Text;
            //SmobilerForm3 smobilerForm3 = new SmobilerForm3(user);
            //this.Form.Show(smobilerForm3);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Press_1(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = textBox1.Text;
            SmobilerForm2 smobilerForm2 = new SmobilerForm2(user);
            this.Form.Show(smobilerForm2);
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}