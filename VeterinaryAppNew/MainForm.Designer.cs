namespace VeterinaryAppNew
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            ContentPanel = new Panel();
            sidebarButton1 = new VeterinaryApp.Components.SidebarButton();
            panel1.SuspendLayout();
            ContentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 40);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 809);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Image = Resources.AppResource.appointment3;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 12);
            button1.Margin = new Padding(3, 60, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(194, 45);
            button1.TabIndex = 0;
            button1.Text = " Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(sidebarButton1);
            ContentPanel.Location = new Point(203, 0);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(1128, 809);
            ContentPanel.TabIndex = 1;
            // 
            // sidebarButton1
            // 
            sidebarButton1.BackColor = Color.FromArgb(30, 30, 40);
            sidebarButton1.ButtonText = "";
            sidebarButton1.DefaultColor = Color.FromArgb(30, 30, 40);
            sidebarButton1.Dock = DockStyle.Top;
            sidebarButton1.HoverColor = Color.FromArgb(50, 50, 70);
            sidebarButton1.Icon = null;
            sidebarButton1.Location = new Point(0, 0);
            sidebarButton1.Name = "sidebarButton1";
            sidebarButton1.Size = new Size(1128, 8);
            sidebarButton1.TabIndex = 0;
            sidebarButton1.Text = "sidebarButton1";
            sidebarButton1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 809);
            Controls.Add(ContentPanel);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "MainForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ContentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel ContentPanel;
        private VeterinaryApp.Components.SidebarButton sidebarButton1;
    }
}
