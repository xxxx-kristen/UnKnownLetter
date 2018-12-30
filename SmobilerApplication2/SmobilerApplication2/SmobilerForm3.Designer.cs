using System;
using Smobiler.Core;
namespace SmobilerApplication2
{
    partial class SmobilerForm3 : Smobiler.Core.Controls.MobileForm
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
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.FontSize = 72F;
            this.textBox1.Location = new System.Drawing.Point(201, 775);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(726, 856);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(834, 1661);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 123);
            this.button1.Text = "确定";
            this.button1.ZIndex = 5;
            this.button1.Press += new System.EventHandler(this.button1_Press);
            // 
            // SmobilerForm3
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = "write1";
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.textBox1,
            this.button1});
            this.Size = new System.Drawing.Size(1080, 1920);
            this.Load += new System.EventHandler(this.SmobilerForm3_Load);
            this.Name = "SmobilerForm3";

        }
        #endregion

        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Button button1;
    }
}