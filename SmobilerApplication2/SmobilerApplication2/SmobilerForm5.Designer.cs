using System;
using Smobiler.Core;
namespace SmobilerApplication2
{
    partial class SmobilerForm5 : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.button1 = new Smobiler.Core.Controls.Button();
            this.button2 = new Smobiler.Core.Controls.Button();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(544, 888);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(404, 105);
            this.button1.Text = "button1";
            this.button1.ZIndex = 5;
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(132, 1070);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(816, 96);
            this.button2.Text = "button2";
            this.button2.ZIndex = 5;
            this.button2.Press += new System.EventHandler(this.button2_Press);
            // 
            // SmobilerForm5
            // 
            this.BackgroundImage = "final";
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.button1,
            this.button2});
            this.Size = new System.Drawing.Size(1080, 1920);
            this.Load += new System.EventHandler(this.SmobilerForm5_Load);
            this.Name = "SmobilerForm5";

        }
        #endregion

        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Button button2;
    }
}