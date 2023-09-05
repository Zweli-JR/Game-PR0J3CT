namespace PR0J3CT
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
            this.headingContainer = new System.Windows.Forms.Panel();
            this.headingPB = new System.Windows.Forms.PictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.incorretsLable = new System.Windows.Forms.Label();
            this.incorrectList = new System.Windows.Forms.ListBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.highscoreLable = new System.Windows.Forms.Label();
            this.highscoreList = new System.Windows.Forms.ListBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.wordLable = new System.Windows.Forms.Label();
            this.centrePanel = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.quitBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.mainPB = new System.Windows.Forms.PictureBox();
            this.gameStatusPB = new System.Windows.Forms.PictureBox();
            this.headingContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headingPB)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.centrePanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStatusPB)).BeginInit();
            this.SuspendLayout();
            // 
            // headingContainer
            // 
            this.headingContainer.Controls.Add(this.headingPB);
            this.headingContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.headingContainer.Location = new System.Drawing.Point(174, 0);
            this.headingContainer.Name = "headingContainer";
            this.headingContainer.Size = new System.Drawing.Size(385, 100);
            this.headingContainer.TabIndex = 0;
            // 
            // headingPB
            // 
            this.headingPB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headingPB.Image = global::PR0J3CT.Properties.Resources.Capture;
            this.headingPB.Location = new System.Drawing.Point(3, 3);
            this.headingPB.Name = "headingPB";
            this.headingPB.Size = new System.Drawing.Size(379, 94);
            this.headingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headingPB.TabIndex = 1;
            this.headingPB.TabStop = false;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.incorretsLable);
            this.leftPanel.Controls.Add(this.incorrectList);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(174, 450);
            this.leftPanel.TabIndex = 1;
            // 
            // incorretsLable
            // 
            this.incorretsLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incorretsLable.AutoSize = true;
            this.incorretsLable.Font = new System.Drawing.Font("Snap ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incorretsLable.Location = new System.Drawing.Point(12, 115);
            this.incorretsLable.Name = "incorretsLable";
            this.incorretsLable.Size = new System.Drawing.Size(21, 27);
            this.incorretsLable.TabIndex = 1;
            this.incorretsLable.Text = " ";
            // 
            // incorrectList
            // 
            this.incorrectList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incorrectList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.incorrectList.Font = new System.Drawing.Font("Snap ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incorrectList.FormattingEnabled = true;
            this.incorrectList.ItemHeight = 27;
            this.incorrectList.Location = new System.Drawing.Point(77, 149);
            this.incorrectList.Name = "incorrectList";
            this.incorrectList.Size = new System.Drawing.Size(91, 270);
            this.incorrectList.Sorted = true;
            this.incorrectList.TabIndex = 1;
            this.incorrectList.TabStop = false;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.highscoreLable);
            this.rightPanel.Controls.Add(this.highscoreList);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(559, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(241, 450);
            this.rightPanel.TabIndex = 2;
            // 
            // highscoreLable
            // 
            this.highscoreLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.highscoreLable.AutoSize = true;
            this.highscoreLable.Font = new System.Drawing.Font("Snap ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.highscoreLable.Location = new System.Drawing.Point(64, 123);
            this.highscoreLable.Name = "highscoreLable";
            this.highscoreLable.Size = new System.Drawing.Size(21, 27);
            this.highscoreLable.TabIndex = 3;
            this.highscoreLable.Text = " ";
            // 
            // highscoreList
            // 
            this.highscoreList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.highscoreList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.highscoreList.Font = new System.Drawing.Font("Snap ITC", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.highscoreList.FormattingEnabled = true;
            this.highscoreList.ItemHeight = 27;
            this.highscoreList.Location = new System.Drawing.Point(6, 153);
            this.highscoreList.Name = "highscoreList";
            this.highscoreList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.highscoreList.Size = new System.Drawing.Size(223, 270);
            this.highscoreList.Sorted = true;
            this.highscoreList.TabIndex = 2;
            this.highscoreList.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.wordLable);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(174, 350);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(385, 100);
            this.bottomPanel.TabIndex = 3;
            // 
            // wordLable
            // 
            this.wordLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordLable.AutoSize = true;
            this.wordLable.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wordLable.Location = new System.Drawing.Point(17, 17);
            this.wordLable.Name = "wordLable";
            this.wordLable.Size = new System.Drawing.Size(27, 35);
            this.wordLable.TabIndex = 0;
            this.wordLable.Text = " ";
            // 
            // centrePanel
            // 
            this.centrePanel.Controls.Add(this.buttonPanel);
            this.centrePanel.Controls.Add(this.mainPB);
            this.centrePanel.Controls.Add(this.gameStatusPB);
            this.centrePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centrePanel.Location = new System.Drawing.Point(174, 100);
            this.centrePanel.Name = "centrePanel";
            this.centrePanel.Size = new System.Drawing.Size(385, 250);
            this.centrePanel.TabIndex = 4;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPanel.Controls.Add(this.quitBtn);
            this.buttonPanel.Controls.Add(this.startBtn);
            this.buttonPanel.Location = new System.Drawing.Point(149, 125);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(97, 58);
            this.buttonPanel.TabIndex = 2;
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quitBtn.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quitBtn.Location = new System.Drawing.Point(3, 32);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(91, 23);
            this.quitBtn.TabIndex = 1;
            this.quitBtn.Text = "QUIT";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startBtn.Location = new System.Drawing.Point(3, 3);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(91, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // mainPB
            // 
            this.mainPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPB.Location = new System.Drawing.Point(0, 44);
            this.mainPB.Name = "mainPB";
            this.mainPB.Size = new System.Drawing.Size(385, 206);
            this.mainPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPB.TabIndex = 1;
            this.mainPB.TabStop = false;
            // 
            // gameStatusPB
            // 
            this.gameStatusPB.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameStatusPB.Image = global::PR0J3CT.Properties.Resources.blank;
            this.gameStatusPB.Location = new System.Drawing.Point(0, 0);
            this.gameStatusPB.Name = "gameStatusPB";
            this.gameStatusPB.Size = new System.Drawing.Size(385, 44);
            this.gameStatusPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameStatusPB.TabIndex = 0;
            this.gameStatusPB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.centrePanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.headingContainer);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.headingContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headingPB)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.centrePanel.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameStatusPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel headingContainer;
        private PictureBox headingPB;
        private Panel leftPanel;
        private Label incorretsLable;
        private ListBox incorrectList;
        private Panel rightPanel;
        private Label highscoreLable;
        private ListBox highscoreList;
        private Panel bottomPanel;
        private Label wordLable;
        private Panel centrePanel;
        private PictureBox mainPB;
        private PictureBox gameStatusPB;
        private Panel buttonPanel;
        private Button quitBtn;
        private Button startBtn;
    }
}