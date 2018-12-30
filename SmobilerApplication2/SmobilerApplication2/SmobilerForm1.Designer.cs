using Smobiler.Core;

namespace SmobilerApplication2
{
    partial class SmobilerForm1 : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm Designer generated code "

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm Designer
        //It can be modified using the SmobilerForm Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.textBox1 = new Smobiler.Core.Controls.TextBox();
            this.button1 = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.FontSize = 70F;
            this.textBox1.Location = new System.Drawing.Point(135, 873);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(807, 106);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(135, 1039);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(807, 106);
            this.button1.Text = "button1";
            this.button1.ZIndex = 5;
            this.button1.Press += new System.EventHandler(this.button1_Press_1);
            // 
            // label1
            // 
            this.label1.FontSize = 40F;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(135, 846);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 56);
            this.label1.Text = "请输入微信号：";
            // 
            // SmobilerForm1
            // 
            this.BackgroundImage = "start";
            this.BackgroundImageSizeMode = Smobiler.Core.Controls.ImageSizeMode.Stretch;
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.textBox1,
            this.button1,
            this.label1});
            this.Size = new System.Drawing.Size(1080, 1920);
            this.Load += new System.EventHandler(this.SmobilerForm1_Load);
            this.Name = "SmobilerForm1";

        }
        #endregion

        private Smobiler.Core.Controls.TextBox textBox1;
        private Smobiler.Core.Controls.Button button1;
        private Smobiler.Core.Controls.Label label1;
    }
}