using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using gbxRecode.gbx;
using gbxRecode.gbx.Program;

namespace gbxRecode
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e){ Process.GetCurrentProcess().Kill(); }

        private void minimize_Click(object sender, EventArgs e){ WindowState = FormWindowState.Minimized; }

        int buttonOffset = 22;
        int programButOffset = 3;


        public void Main_Load(object sender, EventArgs e)
        {
            // load gaber
            gbxC.setupPrograms();

            foreach (Category cat in gbxC.categories)
            {

                // fix program button offset
                programButOffset = 3;


                // da panel
                Panel panel = new Panel();
                panel.Location = new Point(147, 22);
                panel.Size = new Size(670, 428);
                panel.AutoScroll = true;


                // da button
                Guna.UI2.WinForms.Guna2Button button = new Guna.UI2.WinForms.Guna2Button();
                button.CheckedState.Parent = button;
                button.CustomImages.Parent = button;
                button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
                button.Font = new System.Drawing.Font("Segoe UI", 9F);
                button.ForeColor = System.Drawing.Color.White;
                button.HoverState.Parent = button;
                button.Location = new System.Drawing.Point(0, buttonOffset);
                buttonOffset += 45;
                button.ShadowDecoration.Parent = button;
                button.Size = new System.Drawing.Size(141, 45);
                button.TabIndex = 1;
                button.Text = cat.name;
                button.Animated = true;
                button.MouseDown += (sender2, EventArgs) => { panelClick(sender, EventArgs, panel); };

                // add them to form
                this.Controls.Add(panel);
                this.Controls.Add(button);

                // add buttons
                foreach (App application in cat.programs)
                {
                    // da label
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Font = new System.Drawing.Font("Yu Gothic UI Light", 19.75F);
                    label.ForeColor = System.Drawing.Color.White;
                    label.Location = new System.Drawing.Point(2, programButOffset);
                    label.Size = new System.Drawing.Size(184, 37);
                    label.TabIndex = 4;
                    label.Text = application.name;

                    // da description label
                    Label label2 = new Label();
                    label2.AutoSize = true;
                    label2.Font = new System.Drawing.Font("Yu Gothic UI Light", 12.75F);
                    label2.ForeColor = System.Drawing.Color.White;
                    label2.Location = new System.Drawing.Point(6, programButOffset + 37);
                    label2.Size = new System.Drawing.Size(158, 23);
                    label2.TabIndex = 5;
                    label2.Text = application.description;


                    // da button
                    Guna.UI2.WinForms.Guna2Button button2 = new Guna.UI2.WinForms.Guna2Button();
                    button2.CheckedState.Parent = button2;
                    button2.CustomImages.Parent = button2;
                    button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
                    button2.Font = new System.Drawing.Font("Segoe UI", 9F);
                    button2.ForeColor = System.Drawing.Color.White;
                    button2.HoverState.Parent = button2;
                    button2.Location = new System.Drawing.Point(500, programButOffset + 15);
                    button2.ShadowDecoration.Parent = button2;
                    button2.Size = new System.Drawing.Size(141, 45);
                    button2.TabIndex = 1;
                    button2.Text = "Install";
                    button2.Animated = true;

                    // assign
                    application.button = button2;

                    // da events
                    button2.MouseDown += (sender2, EventArgs) => { buttonClick(sender, EventArgs, application); };

                    // add
                    panel.Controls.Add(label);
                    panel.Controls.Add(label2);
                    panel.Controls.Add(button2);

                    // button offset
                    programButOffset += 60;
                }
            }
        }

        // button click event
        void buttonClick(object sender, MouseEventArgs e, gbxRecode.gbx.Program.App app)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (app.type)
                {
                    case AppTypes.Type.Exe:
                        gbxCore.downloadExe(app.path, app.link);
                        break;

                    case AppTypes.Type.Zip:
                        gbxCore.downloadZip(app.path, app.link, app.finalPath);
                        break;
                }
            }
        }


        // panel click event
        void panelClick(object sender, MouseEventArgs e, Panel pan)
        {
            if (e.Button == MouseButtons.Left)
            {
                pan.BringToFront();
            }
        }
    }
}
