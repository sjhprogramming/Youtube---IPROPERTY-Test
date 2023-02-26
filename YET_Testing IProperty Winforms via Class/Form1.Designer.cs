namespace YET_Testing_IProperty_Winforms_via_Class
{
    partial class Form1
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
            LblTitle = new Label();
            LblTextChange = new Label();
            TextBoxText = new TextBox();
            menuStrip1 = new MenuStrip();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LblTitle
            // 
            LblTitle.AutoSize = true;
            LblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblTitle.Location = new Point(61, 185);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(137, 25);
            LblTitle.TabIndex = 5;
            LblTitle.Text = "Text to Change";
            // 
            // LblTextChange
            // 
            LblTextChange.BorderStyle = BorderStyle.Fixed3D;
            LblTextChange.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblTextChange.Location = new Point(61, 59);
            LblTextChange.Name = "LblTextChange";
            LblTextChange.Size = new Size(518, 72);
            LblTextChange.TabIndex = 4;
            LblTextChange.Text = "label1";
            LblTextChange.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBoxText
            // 
            TextBoxText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxText.Location = new Point(204, 182);
            TextBoxText.Name = "TextBoxText";
            TextBoxText.Size = new Size(375, 33);
            TextBoxText.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(648, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 293);
            Controls.Add(LblTitle);
            Controls.Add(LblTextChange);
            Controls.Add(TextBoxText);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTitle;
        private Label LblTextChange;
        private TextBox TextBoxText;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}