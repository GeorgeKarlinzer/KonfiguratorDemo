namespace KonfiguratorDemo
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
            this.headerTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.primaryPanel = new System.Windows.Forms.Panel();
            this.mainComboBox = new System.Windows.Forms.ComboBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.ComboBox();
            this.headerBot = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.param1Panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.param1Box = new System.Windows.Forms.ComboBox();
            this.param2Panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.param2Box = new System.Windows.Forms.ComboBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerTop.SuspendLayout();
            this.primaryPanel.SuspendLayout();
            this.colorPanel.SuspendLayout();
            this.headerBot.SuspendLayout();
            this.param1Panel.SuspendLayout();
            this.param2Panel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerTop
            // 
            this.headerTop.BackColor = System.Drawing.Color.Silver;
            this.headerTop.Controls.Add(this.label1);
            this.headerTop.Location = new System.Drawing.Point(34, 138);
            this.headerTop.Name = "headerTop";
            this.headerTop.Size = new System.Drawing.Size(1189, 29);
            this.headerTop.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARAMETRY OGÓLNE";
            // 
            // primaryPanel
            // 
            this.primaryPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.primaryPanel.Controls.Add(this.mainComboBox);
            this.primaryPanel.Controls.Add(this.modelLabel);
            this.primaryPanel.Location = new System.Drawing.Point(34, 165);
            this.primaryPanel.Name = "primaryPanel";
            this.primaryPanel.Size = new System.Drawing.Size(1189, 100);
            this.primaryPanel.TabIndex = 9;
            // 
            // mainComboBox
            // 
            this.mainComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainComboBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainComboBox.FormattingEnabled = true;
            this.mainComboBox.Location = new System.Drawing.Point(59, 49);
            this.mainComboBox.Name = "mainComboBox";
            this.mainComboBox.Size = new System.Drawing.Size(121, 23);
            this.mainComboBox.TabIndex = 1;
            this.mainComboBox.SelectedIndexChanged += new System.EventHandler(this.MainComboBox_SelectedIndexChanged);
            this.mainComboBox.DropDownClosed += new System.EventHandler(this.ComboBox_DropDownClosed);
            // 
            // modelLabel
            // 
            this.modelLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(55, 14);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(121, 32);
            this.modelLabel.TabIndex = 0;
            this.modelLabel.Text = "Model rolety";
            this.modelLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.colorPanel.Controls.Add(this.label4);
            this.colorPanel.Controls.Add(this.colorBox);
            this.colorPanel.Location = new System.Drawing.Point(34, 402);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(151, 100);
            this.colorPanel.TabIndex = 7;
            this.colorPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // colorBox
            // 
            this.colorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorBox.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Location = new System.Drawing.Point(18, 54);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(121, 23);
            this.colorBox.TabIndex = 3;
            this.colorBox.DropDownClosed += new System.EventHandler(this.ComboBox_DropDownClosed);
            // 
            // headerBot
            // 
            this.headerBot.BackColor = System.Drawing.Color.Silver;
            this.headerBot.Controls.Add(this.label3);
            this.headerBot.Location = new System.Drawing.Point(34, 367);
            this.headerBot.Name = "headerBot";
            this.headerBot.Size = new System.Drawing.Size(1189, 29);
            this.headerBot.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "PARAMETRY SZCZEGÓŁOWE";
            // 
            // param1Panel
            // 
            this.param1Panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.param1Panel.Controls.Add(this.label2);
            this.param1Panel.Controls.Add(this.param1Box);
            this.param1Panel.Location = new System.Drawing.Point(191, 402);
            this.param1Panel.Name = "param1Panel";
            this.param1Panel.Size = new System.Drawing.Size(151, 100);
            this.param1Panel.TabIndex = 8;
            this.param1Panel.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Param 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // param1Box
            // 
            this.param1Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.param1Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.param1Box.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param1Box.FormattingEnabled = true;
            this.param1Box.Location = new System.Drawing.Point(18, 54);
            this.param1Box.Name = "param1Box";
            this.param1Box.Size = new System.Drawing.Size(121, 23);
            this.param1Box.TabIndex = 3;
            this.param1Box.DropDownClosed += new System.EventHandler(this.ComboBox_DropDownClosed);
            // 
            // param2Panel
            // 
            this.param2Panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.param2Panel.Controls.Add(this.label5);
            this.param2Panel.Controls.Add(this.param2Box);
            this.param2Panel.Location = new System.Drawing.Point(348, 402);
            this.param2Panel.Name = "param2Panel";
            this.param2Panel.Size = new System.Drawing.Size(151, 100);
            this.param2Panel.TabIndex = 9;
            this.param2Panel.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Param 2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // param2Box
            // 
            this.param2Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.param2Box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.param2Box.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param2Box.FormattingEnabled = true;
            this.param2Box.Location = new System.Drawing.Point(18, 54);
            this.param2Box.Name = "param2Box";
            this.param2Box.Size = new System.Drawing.Size(121, 23);
            this.param2Box.TabIndex = 3;
            this.param2Box.DropDownClosed += new System.EventHandler(this.ComboBox_DropDownClosed);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(1230, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(29, 28);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1259, 28);
            this.topPanel.TabIndex = 7;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::KonfiguratorDemo.Properties.Resources.iconfinder_191_Kickstarter_logo_logos_4373990;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 714);
            this.Controls.Add(this.param2Panel);
            this.Controls.Add(this.param1Panel);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.headerBot);
            this.Controls.Add(this.primaryPanel);
            this.Controls.Add(this.headerTop);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainProgram";
            this.headerTop.ResumeLayout(false);
            this.primaryPanel.ResumeLayout(false);
            this.colorPanel.ResumeLayout(false);
            this.headerBot.ResumeLayout(false);
            this.param1Panel.ResumeLayout(false);
            this.param2Panel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel headerTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel primaryPanel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Panel headerBot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox mainComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox colorBox;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Panel param1Panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox param1Box;
        private System.Windows.Forms.Panel param2Panel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox param2Box;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}