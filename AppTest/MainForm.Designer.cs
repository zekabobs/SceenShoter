namespace AppTest
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTStripMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsTStripMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationTStripMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackTStripMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonInfo);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 119);
            this.panel1.TabIndex = 2;
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.Lavender;
            this.buttonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInfo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Bell MT", 27.75F, System.Drawing.FontStyle.Bold);
            this.buttonInfo.ForeColor = System.Drawing.Color.Black;
            this.buttonInfo.Location = new System.Drawing.Point(0, 59);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(196, 59);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "EXIT";
            this.buttonInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Lavender;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Bell MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.Black;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonHome.Size = new System.Drawing.Size(196, 59);
            this.buttonHome.TabIndex = 2;
            this.buttonHome.Text = "SHUT";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.btnCreateScreenShot_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTStripMItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(76, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuTStripMItem
            // 
            this.menuTStripMItem.BackColor = System.Drawing.Color.Lavender;
            this.menuTStripMItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsTStripMItem,
            this.informationTStripMItem,
            this.feedbackTStripMItem});
            this.menuTStripMItem.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTStripMItem.Name = "menuTStripMItem";
            this.menuTStripMItem.Size = new System.Drawing.Size(61, 21);
            this.menuTStripMItem.Text = "MENU";
            // 
            // settingsTStripMItem
            // 
            this.settingsTStripMItem.Name = "settingsTStripMItem";
            this.settingsTStripMItem.Size = new System.Drawing.Size(180, 22);
            this.settingsTStripMItem.Text = "Settings";
            this.settingsTStripMItem.Click += new System.EventHandler(this.settingsTStripMItem_Click);
            // 
            // informationTStripMItem
            // 
            this.informationTStripMItem.Name = "informationTStripMItem";
            this.informationTStripMItem.Size = new System.Drawing.Size(180, 22);
            this.informationTStripMItem.Text = "Information";
            this.informationTStripMItem.Click += new System.EventHandler(this.informationTStripMItem_Click);
            // 
            // feedbackTStripMItem
            // 
            this.feedbackTStripMItem.Name = "feedbackTStripMItem";
            this.feedbackTStripMItem.Size = new System.Drawing.Size(180, 22);
            this.feedbackTStripMItem.Text = "Feedback";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(196, 148);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(196, 148);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTStripMItem;
        private System.Windows.Forms.ToolStripMenuItem settingsTStripMItem;
        private System.Windows.Forms.ToolStripMenuItem informationTStripMItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackTStripMItem;
    }
}

