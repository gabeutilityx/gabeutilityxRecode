namespace gbxRecode
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragbar = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dragbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // dragbar
            // 
            this.dragbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dragbar.Controls.Add(this.panel1);
            this.dragbar.Controls.Add(this.minimize);
            this.dragbar.Controls.Add(this.close);
            this.dragbar.Controls.Add(this.title);
            this.dragbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragbar.Location = new System.Drawing.Point(0, 0);
            this.dragbar.Name = "dragbar";
            this.dragbar.Size = new System.Drawing.Size(800, 22);
            this.dragbar.TabIndex = 0;
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.minimize.Font = new System.Drawing.Font("Yu Gothic UI Light", 7.75F);
            this.minimize.ForeColor = System.Drawing.Color.Yellow;
            this.minimize.Location = new System.Drawing.Point(763, 4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(19, 13);
            this.minimize.TabIndex = 3;
            this.minimize.Text = "⚫";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Yu Gothic UI Light", 7.75F);
            this.close.ForeColor = System.Drawing.Color.Red;
            this.close.Location = new System.Drawing.Point(778, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(19, 13);
            this.close.TabIndex = 2;
            this.close.Text = "⚫";
            this.close.Click += new System.EventHandler(this.label1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Yu Gothic UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(4, 2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(70, 17);
            this.title.TabIndex = 1;
            this.title.Text = "gabeutilityx";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.dragbar;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(147, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 428);
            this.panel1.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dragbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "gabeutilityx";
            this.Load += new System.EventHandler(this.Main_Load);
            this.dragbar.ResumeLayout(false);
            this.dragbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Panel dragbar;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
    }
}

