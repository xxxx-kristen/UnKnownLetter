using System;
using Smobiler.Core;
namespace SmobilerApplication2
{
    partial class SmobilerForm4 : Smobiler.Core.Controls.MobileForm
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
            this.label1 = new Smobiler.Core.Controls.Label();
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.button1 = new Smobiler.Core.Controls.Button();
            // 
            // label1
            // 
            this.label1.Bold = true;
            this.label1.FontSize = 40F;
            this.label1.Location = new System.Drawing.Point(320, 615);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 80);
            this.label1.Text = "他/她的回答是:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.FontSize = 72F;
            this.textBox1.Location = new System.Drawing.Point(201, 775);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
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
            // SmobilerForm4
            // 
            this.BackgroundImage = "write1";
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1,
            this.textBox1,
            this.button1});
            this.Size = new System.Drawing.Size(1080, 1920);
            this.Wrap = Smobiler.Core.Controls.LayoutWrap.Wrap;
            this.Load += new System.EventHandler(this.SmobilerForm4_Load);
            this.Name = "SmobilerForm4";

        }
        #endregion

        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Button button1;
    }
}