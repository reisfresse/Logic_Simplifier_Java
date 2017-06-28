namespace LogicSimplifier
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.KVtoQMC = new System.Windows.Forms.Button();
            this.DNFtoQMC = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KVtoQMC
            // 
            this.KVtoQMC.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.KVtoQMC.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.KVtoQMC, "KVtoQMC");
            this.KVtoQMC.Name = "KVtoQMC";
            this.KVtoQMC.UseVisualStyleBackColor = false;
            this.KVtoQMC.Click += new System.EventHandler(this.KVtoQMC_Click);
            // 
            // DNFtoQMC
            // 
            this.DNFtoQMC.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DNFtoQMC.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.DNFtoQMC, "DNFtoQMC");
            this.DNFtoQMC.Name = "DNFtoQMC";
            this.DNFtoQMC.UseVisualStyleBackColor = false;
            this.DNFtoQMC.Click += new System.EventHandler(this.DNFtoQMC_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.about.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.about, "about");
            this.about.Name = "about";
            this.about.UseVisualStyleBackColor = false;
            this.about.MouseUp += new System.Windows.Forms.MouseEventHandler(this.about_MouseUp);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.exit, "exit");
            this.exit.Name = "exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::LogicSimplifier.Properties.Resources.Background;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.about);
            this.Controls.Add(this.DNFtoQMC);
            this.Controls.Add(this.KVtoQMC);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKey);

        }

        #endregion

        private System.Windows.Forms.Button KVtoQMC;
        private System.Windows.Forms.Button DNFtoQMC;
        public System.Windows.Forms.Button about;
        private System.Windows.Forms.Button exit;
    }
}

