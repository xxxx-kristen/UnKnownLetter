using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Smobiler.Core;
using Smobiler.Core.Controls;

namespace SmobilerApplication2
{
    partial class SmobilerForm2 : Smobiler.Core.Controls.MobileForm
    {
        public User user;
        public SmobilerForm2() : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();
        }
        public SmobilerForm2(User _user):base()
        {
            user = _user;
            InitializeComponent();
        }

        private void SmobilerForm2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Press(object sender, EventArgs e)
        {
            if (this.BackgroundImage == "introduction1")
            {
                SmobilerForm2 smobilerForm2 = new SmobilerForm2(user);
                smobilerForm2.BackgroundImage = "introduction2";
                smobilerForm2.Show(smobilerForm2);
            }else
            {
                SmobilerForm3 smobilerForm3 = new SmobilerForm3(user);
                smobilerForm3.Show(smobilerForm3);
            }
        }
    }
}