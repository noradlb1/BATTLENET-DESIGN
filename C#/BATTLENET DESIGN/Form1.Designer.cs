using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BATTLENET_DESIGN
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            Guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            Guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            Label1 = new Label();
            Label1.MouseMove += new MouseEventHandler(Label1_MouseMove);
            Guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            Guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            Guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            Guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            Guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Label2 = new Label();
            Guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            Guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            Guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            Guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            Guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            Guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            Guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            Guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            Guna2ImageCheckBox1 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            Guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Guna2Elipse1
            // 
            Guna2Elipse1.BorderRadius = 20;
            Guna2Elipse1.TargetControl = this;
            // 
            // Guna2DragControl1
            // 
            Guna2DragControl1.DockIndicatorTransparencyValue = 0.6d;
            Guna2DragControl1.TargetControl = Guna2Panel1;
            Guna2DragControl1.UseTransparentDrag = true;
            // 
            // Guna2Panel1
            // 
            Guna2Panel1.BackColor = Color.FromArgb(21, 23, 30);
            Guna2Panel1.Controls.Add(Guna2ImageCheckBox1);
            Guna2Panel1.Controls.Add(Guna2ControlBox1);
            Guna2Panel1.Controls.Add(Label2);
            Guna2Panel1.Controls.Add(Label1);
            Guna2Panel1.Controls.Add(Guna2Button8);
            Guna2Panel1.Controls.Add(Guna2TextBox2);
            Guna2Panel1.Controls.Add(Guna2Separator2);
            Guna2Panel1.Controls.Add(Guna2HtmlLabel2);
            Guna2Panel1.Controls.Add(Guna2Separator1);
            Guna2Panel1.Controls.Add(Guna2TextBox1);
            Guna2Panel1.Controls.Add(Guna2Button7);
            Guna2Panel1.Controls.Add(Guna2Button6);
            Guna2Panel1.Controls.Add(Guna2Button5);
            Guna2Panel1.Controls.Add(Guna2Button4);
            Guna2Panel1.Controls.Add(Guna2Button3);
            Guna2Panel1.Controls.Add(Guna2Button2);
            Guna2Panel1.Controls.Add(Guna2Button1);
            Guna2Panel1.Controls.Add(Guna2PictureBox1);
            Guna2Panel1.Controls.Add(Guna2HtmlLabel1);
            Guna2Panel1.Dock = DockStyle.Fill;
            Guna2Panel1.Location = new Point(0, 0);
            Guna2Panel1.Name = "Guna2Panel1";
            Guna2Panel1.Size = new Size(393, 561);
            Guna2Panel1.TabIndex = 0;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Cursor = Cursors.Hand;
            Label1.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.FromArgb(46, 152, 254);
            Label1.Location = new Point(79, 481);
            Label1.Name = "Label1";
            Label1.Size = new Size(222, 19);
            Label1.TabIndex = 16;
            Label1.Text = "Create a free Battle.net Account";
            // 
            // Guna2Button8
            // 
            Guna2Button8.BorderRadius = 6;
            Guna2Button8.DisabledState.BorderColor = Color.DarkGray;
            Guna2Button8.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2Button8.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2Button8.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2Button8.FillColor = Color.FromArgb(0, 116, 224);
            Guna2Button8.Font = new Font("Segoe UI", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guna2Button8.ForeColor = Color.White;
            Guna2Button8.Location = new Point(103, 418);
            Guna2Button8.Name = "Guna2Button8";
            Guna2Button8.Size = new Size(180, 29);
            Guna2Button8.TabIndex = 15;
            Guna2Button8.Text = "Log In";
            // 
            // Guna2TextBox2
            // 
            Guna2TextBox2.Animated = true;
            Guna2TextBox2.BackColor = Color.Transparent;
            Guna2TextBox2.BorderColor = Color.Gray;
            Guna2TextBox2.BorderRadius = 3;
            Guna2TextBox2.Cursor = Cursors.IBeam;
            Guna2TextBox2.DefaultText = "";
            Guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Guna2TextBox2.FillColor = Color.FromArgb(21, 23, 30);
            Guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Guna2TextBox2.Font = new Font("Segoe UI", 9.0f);
            Guna2TextBox2.ForeColor = Color.Gray;
            Guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Guna2TextBox2.Location = new Point(53, 371);
            Guna2TextBox2.Name = "Guna2TextBox2";
            Guna2TextBox2.PasswordChar = '\0';
            Guna2TextBox2.PlaceholderText = "Password";
            Guna2TextBox2.SelectedText = "";
            Guna2TextBox2.Size = new Size(283, 28);
            Guna2TextBox2.TabIndex = 14;
            // 
            // Guna2Separator2
            // 
            Guna2Separator2.FillColor = Color.Gray;
            Guna2Separator2.Location = new Point(240, 285);
            Guna2Separator2.Name = "Guna2Separator2";
            Guna2Separator2.Size = new Size(96, 10);
            Guna2Separator2.TabIndex = 13;
            // 
            // Guna2HtmlLabel2
            // 
            Guna2HtmlLabel2.BackColor = Color.Transparent;
            Guna2HtmlLabel2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guna2HtmlLabel2.ForeColor = Color.Gray;
            Guna2HtmlLabel2.Location = new Point(158, 280);
            Guna2HtmlLabel2.Name = "Guna2HtmlLabel2";
            Guna2HtmlLabel2.Size = new Size(78, 15);
            Guna2HtmlLabel2.TabIndex = 12;
            Guna2HtmlLabel2.Text = "Or log in with";
            // 
            // Guna2Separator1
            // 
            Guna2Separator1.FillColor = Color.Gray;
            Guna2Separator1.Location = new Point(53, 285);
            Guna2Separator1.Name = "Guna2Separator1";
            Guna2Separator1.Size = new Size(96, 10);
            Guna2Separator1.TabIndex = 11;
            // 
            // Guna2TextBox1
            // 
            Guna2TextBox1.Animated = true;
            Guna2TextBox1.BackColor = Color.Transparent;
            Guna2TextBox1.BorderColor = Color.Gray;
            Guna2TextBox1.BorderRadius = 3;
            Guna2TextBox1.Cursor = Cursors.IBeam;
            Guna2TextBox1.DefaultText = "";
            Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Guna2TextBox1.FillColor = Color.FromArgb(21, 23, 30);
            Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Guna2TextBox1.Font = new Font("Segoe UI", 9.0f);
            Guna2TextBox1.ForeColor = Color.Gray;
            Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Guna2TextBox1.Location = new Point(53, 320);
            Guna2TextBox1.Name = "Guna2TextBox1";
            Guna2TextBox1.PasswordChar = '\0';
            Guna2TextBox1.PlaceholderText = "Email or Phone";
            Guna2TextBox1.SelectedText = "";
            Guna2TextBox1.Size = new Size(283, 28);
            Guna2TextBox1.TabIndex = 10;
            // 
            // Guna2HtmlLabel1
            // 
            Guna2HtmlLabel1.BackColor = Color.Transparent;
            Guna2HtmlLabel1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Guna2HtmlLabel1.ForeColor = Color.White;
            Guna2HtmlLabel1.Location = new Point(168, 74);
            Guna2HtmlLabel1.Name = "Guna2HtmlLabel1";
            Guna2HtmlLabel1.Size = new Size(61, 26);
            Guna2HtmlLabel1.TabIndex = 0;
            Guna2HtmlLabel1.Text = "Log In";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Cursor = Cursors.Hand;
            Label2.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.FromArgb(46, 152, 254);
            Label2.Location = new Point(142, 516);
            Label2.Name = "Label2";
            Label2.Size = new Size(95, 19);
            Label2.TabIndex = 17;
            Label2.Text = "Can't log in? ";
            // 
            // Guna2ControlBox1
            // 
            Guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Guna2ControlBox1.BorderRadius = 3;
            Guna2ControlBox1.Cursor = Cursors.Hand;
            Guna2ControlBox1.FillColor = Color.Transparent;
            Guna2ControlBox1.IconColor = Color.White;
            Guna2ControlBox1.Location = new Point(360, 3);
            Guna2ControlBox1.Name = "Guna2ControlBox1";
            Guna2ControlBox1.Size = new Size(33, 19);
            Guna2ControlBox1.TabIndex = 18;
            // 
            // Guna2Button7
            // 
            Guna2Button7.Animated = true;
            Guna2Button7.BorderRadius = 3;
            Guna2Button7.Cursor = Cursors.Hand;
            Guna2Button7.DisabledState.BorderColor = Color.DarkGray;
            Guna2Button7.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2Button7.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2Button7.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2Button7.FillColor = Color.FromArgb(16, 124, 16);
            Guna2Button7.Font = new Font("Segoe UI", 9.0f);
            Guna2Button7.ForeColor = Color.White;
            Guna2Button7.Image = My.Resources.Resources.icons8_xbox2_50;
            Guna2Button7.Location = new Point(85, 207);
            Guna2Button7.Name = "Guna2Button7";
            Guna2Button7.Size = new Size(44, 43);
            Guna2Button7.TabIndex = 9;
            // 
            // Guna2Button6
            // 
            Guna2Button6.Animated = true;
            Guna2Button6.BorderRadius = 3;
            Guna2Button6.Cursor = Cursors.Hand;
            Guna2Button6.DisabledState.BorderColor = Color.DarkGray;
            Guna2Button6.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2Button6.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2Button6.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2Button6.FillColor = Color.FromArgb(0, 112, 204);
            Guna2Button6.Font = new Font("Segoe UI", 9.0f);
            Guna2Button6.ForeColor = Color.White;
            Guna2Button6.Image = My.Resources.Resources.icons8_playstation2_50;
            Guna2Button6.Location = new Point(146, 207);
            Guna2Button6.Name = "Guna2Button6";
            Guna2Button6.Size = new Size(44, 43);
            Guna2Button6.TabIndex = 8;
            // 
            // Guna2Button5
            // 
            Guna2Button5.Animated = true;
            Guna2Button5.BorderRadius = 3;
            Guna2Button5.Cursor = Cursors.Hand;
            Guna2Button5.DisabledState.BorderColor = Color.DarkGray;
            Guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2Button5.FillColor = Color.FromArgb(230, 0, 18);
            Guna2Button5.Font = new Font("Segoe UI", 9.0f);
            Guna2Button5.ForeColor = Color.White;
            Guna2Button5.Image = My.Resources.Resources.icons8_nintendo_switch_logo_50;
            Guna2Button5.Location = new Point(206, 207);
            Guna2Button5.Name = "Guna2Button5";
            Guna2Button5.Size = new Size(44, 43);
            Guna2Button5.TabIndex = 7;
            // 
            // Guna2Button4
            // 
            Guna2Button4.Animated = true;
            Guna2Button4.BorderRadius = 3;
            Guna2Button4.Cursor = Cursors.Hand;
            Guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            Guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2Button4.FillColor = Color.White;
            Guna2Button4.Font = new Font("Segoe UI", 9.0f);
            Guna2Button4.ForeColor = Color.White;
            Guna2Button4.Image = My.Resources.Resources.icons8_steam_50;
            Guna2Button4.Location = new Point(265, 207);
            Guna2Button4.Name = "Guna2Button4";
            Guna2Button4.Size = new Size(44, 43);
            Guna2Button4.TabIndex = 6;
            // 
            // Guna2Button3
            // 
            Guna2Button3.Animated = true;
            Guna2Button3.BorderRadius = 3;
            Guna2Button3.Cursor = Cursors.Hand;
            Guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            Guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2Button3.FillColor = Color.White;
            Guna2Button3.Font = new Font("Segoe UI", 9.0f);
            Guna2Button3.ForeColor = Color.White;
            Guna2Button3.Image = My.Resources.Resources.icons8_google_50;
            Guna2Button3.Location = new Point(118, 152);
            Guna2Button3.Name = "Guna2Button3";
            Guna2Button3.Size = new Size(44, 43);
            Guna2Button3.TabIndex = 5;
            // 
            // Guna2Button2
            // 
            Guna2Button2.Animated = true;
            Guna2Button2.BorderRadius = 3;
            Guna2Button2.Cursor = Cursors.Hand;
            Guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2Button2.FillColor = Color.FromArgb(24, 119, 242);
            Guna2Button2.Font = new Font("Segoe UI", 9.0f);
            Guna2Button2.ForeColor = Color.White;
            Guna2Button2.Image = My.Resources.Resources.icons8_facebook4_50;
            Guna2Button2.Location = new Point(175, 152);
            Guna2Button2.Name = "Guna2Button2";
            Guna2Button2.Size = new Size(44, 43);
            Guna2Button2.TabIndex = 4;
            // 
            // Guna2Button1
            // 
            Guna2Button1.Animated = true;
            Guna2Button1.BorderRadius = 3;
            Guna2Button1.Cursor = Cursors.Hand;
            Guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            Guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Guna2Button1.FillColor = Color.White;
            Guna2Button1.Font = new Font("Segoe UI", 9.0f);
            Guna2Button1.ForeColor = Color.White;
            Guna2Button1.Image = My.Resources.Resources.icons8_apple_50;
            Guna2Button1.Location = new Point(233, 152);
            Guna2Button1.Name = "Guna2Button1";
            Guna2Button1.Size = new Size(44, 43);
            Guna2Button1.TabIndex = 3;
            // 
            // Guna2PictureBox1
            // 
            Guna2PictureBox1.BackColor = Color.Transparent;
            Guna2PictureBox1.FillColor = Color.Transparent;
            Guna2PictureBox1.Image = My.Resources.Resources.CaptSSure_removebg_preview;
            Guna2PictureBox1.ImageRotate = 0f;
            Guna2PictureBox1.Location = new Point(64, 12);
            Guna2PictureBox1.Name = "Guna2PictureBox1";
            Guna2PictureBox1.Size = new Size(256, 46);
            Guna2PictureBox1.TabIndex = 2;
            Guna2PictureBox1.TabStop = false;
            // 
            // Guna2ImageCheckBox1
            // 
            Guna2ImageCheckBox1.CheckedState.Image = My.Resources.Resources.icons8_hide_15__1_;
            Guna2ImageCheckBox1.CheckedState.ImageSize = new Size(15, 15);
            Guna2ImageCheckBox1.Cursor = Cursors.Hand;
            Guna2ImageCheckBox1.Image = My.Resources.Resources.icons8_hide_15;
            Guna2ImageCheckBox1.ImageOffset = new Point(0, 0);
            Guna2ImageCheckBox1.ImageRotate = 0f;
            Guna2ImageCheckBox1.ImageSize = new Size(14, 14);
            Guna2ImageCheckBox1.Location = new Point(316, 378);
            Guna2ImageCheckBox1.Name = "Guna2ImageCheckBox1";
            Guna2ImageCheckBox1.PressedState.ImageSize = new Size(14, 14);
            Guna2ImageCheckBox1.ShadowDecoration.Depth = 14;
            Guna2ImageCheckBox1.Size = new Size(15, 15);
            Guna2ImageCheckBox1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 561);
            Controls.Add(Guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.85d;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Guna2Panel1.ResumeLayout(false);
            Guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Guna2PictureBox1).EndInit();
            MouseMove += new MouseEventHandler(Form1_MouseMove);
            ResumeLayout(false);

        }

        internal Guna.UI2.WinForms.Guna2Elipse Guna2Elipse1;
        internal Guna.UI2.WinForms.Guna2DragControl Guna2DragControl1;
        internal Guna.UI2.WinForms.Guna2Panel Guna2Panel1;
        internal Guna.UI2.WinForms.Guna2PictureBox Guna2PictureBox1;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel1;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button1;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button2;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button7;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button6;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button5;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button4;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button3;
        internal Guna.UI2.WinForms.Guna2Button Guna2Button8;
        internal Guna.UI2.WinForms.Guna2TextBox Guna2TextBox2;
        internal Guna.UI2.WinForms.Guna2Separator Guna2Separator2;
        internal Guna.UI2.WinForms.Guna2HtmlLabel Guna2HtmlLabel2;
        internal Guna.UI2.WinForms.Guna2Separator Guna2Separator1;
        internal Guna.UI2.WinForms.Guna2TextBox Guna2TextBox1;
        internal Label Label1;
        internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox1;
        internal Label Label2;
        internal Guna.UI2.WinForms.Guna2ImageCheckBox Guna2ImageCheckBox1;
    }
}