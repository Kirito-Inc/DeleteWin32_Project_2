namespace DeleteWin32___Project_2
{
    partial class GameForm
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
            this.controlPanel = new System.Windows.Forms.Panel();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timerTitleLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreTitleLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.diffGroupBox = new System.Windows.Forms.GroupBox();
            this.hardRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.easyRadioButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.gameField = new System.Windows.Forms.Panel();
            this.gameObject = new System.Windows.Forms.PictureBox();
            this.controlPanel.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            this.diffGroupBox.SuspendLayout();
            this.gameField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameObject)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.controlPanel.Controls.Add(this.infoGroupBox);
            this.controlPanel.Controls.Add(this.diffGroupBox);
            this.controlPanel.Controls.Add(this.startButton);
            this.controlPanel.Controls.Add(this.welcomeLabel);
            this.controlPanel.ForeColor = System.Drawing.Color.Black;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(200, 861);
            this.controlPanel.TabIndex = 0;
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.timerLabel);
            this.infoGroupBox.Controls.Add(this.timerTitleLabel);
            this.infoGroupBox.Controls.Add(this.scoreLabel);
            this.infoGroupBox.Controls.Add(this.scoreTitleLabel);
            this.infoGroupBox.Controls.Add(this.exitButton);
            this.infoGroupBox.Location = new System.Drawing.Point(21, 453);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(156, 396);
            this.infoGroupBox.TabIndex = 11;
            this.infoGroupBox.TabStop = false;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.Location = new System.Drawing.Point(55, 220);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(32, 33);
            this.timerLabel.TabIndex = 9;
            this.timerLabel.Text = "0";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerTitleLabel
            // 
            this.timerTitleLabel.AutoSize = true;
            this.timerTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerTitleLabel.Location = new System.Drawing.Point(46, 165);
            this.timerTitleLabel.Name = "timerTitleLabel";
            this.timerTitleLabel.Size = new System.Drawing.Size(63, 25);
            this.timerTitleLabel.TabIndex = 8;
            this.timerTitleLabel.Text = "Time";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.Location = new System.Drawing.Point(55, 92);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(32, 33);
            this.scoreLabel.TabIndex = 7;
            this.scoreLabel.Text = "0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreTitleLabel
            // 
            this.scoreTitleLabel.AutoSize = true;
            this.scoreTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreTitleLabel.Location = new System.Drawing.Point(37, 42);
            this.scoreTitleLabel.Name = "scoreTitleLabel";
            this.scoreTitleLabel.Size = new System.Drawing.Size(82, 29);
            this.scoreTitleLabel.TabIndex = 6;
            this.scoreTitleLabel.Text = "Score";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(6, 322);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 68);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // diffGroupBox
            // 
            this.diffGroupBox.Controls.Add(this.hardRadioButton);
            this.diffGroupBox.Controls.Add(this.mediumRadioButton);
            this.diffGroupBox.Controls.Add(this.easyRadioButton);
            this.diffGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diffGroupBox.Location = new System.Drawing.Point(21, 178);
            this.diffGroupBox.Name = "diffGroupBox";
            this.diffGroupBox.Size = new System.Drawing.Size(156, 269);
            this.diffGroupBox.TabIndex = 10;
            this.diffGroupBox.TabStop = false;
            this.diffGroupBox.Text = "Difficulty";
            // 
            // hardRadioButton
            // 
            this.hardRadioButton.AutoSize = true;
            this.hardRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hardRadioButton.Location = new System.Drawing.Point(18, 193);
            this.hardRadioButton.Name = "hardRadioButton";
            this.hardRadioButton.Size = new System.Drawing.Size(80, 29);
            this.hardRadioButton.TabIndex = 5;
            this.hardRadioButton.TabStop = true;
            this.hardRadioButton.Text = "Hard";
            this.hardRadioButton.UseVisualStyleBackColor = true;
            this.hardRadioButton.CheckedChanged += new System.EventHandler(this.HardRadioButtonOnCheck);
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mediumRadioButton.Location = new System.Drawing.Point(18, 123);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(112, 29);
            this.mediumRadioButton.TabIndex = 4;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Medium";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            this.mediumRadioButton.CheckedChanged += new System.EventHandler(this.MediumRadioButtonOnCheck);
            // 
            // easyRadioButton
            // 
            this.easyRadioButton.AutoSize = true;
            this.easyRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.easyRadioButton.Location = new System.Drawing.Point(18, 56);
            this.easyRadioButton.Name = "easyRadioButton";
            this.easyRadioButton.Size = new System.Drawing.Size(82, 29);
            this.easyRadioButton.TabIndex = 3;
            this.easyRadioButton.TabStop = true;
            this.easyRadioButton.Text = "Easy";
            this.easyRadioButton.UseVisualStyleBackColor = true;
            this.easyRadioButton.CheckedChanged += new System.EventHandler(this.EasyRadioButtonOnCheck);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(35, 110);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(116, 44);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabel.Location = new System.Drawing.Point(17, 9);
            this.welcomeLabel.MaximumSize = new System.Drawing.Size(160, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(160, 80);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcomeasdasdaasdasdasdasdasdasdasdasdsdasdasdasdasd";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameField
            // 
            this.gameField.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gameField.Controls.Add(this.gameObject);
            this.gameField.Location = new System.Drawing.Point(604, 258);
            this.gameField.Name = "gameField";
            this.gameField.Size = new System.Drawing.Size(341, 257);
            this.gameField.TabIndex = 1;
            // 
            // gameObject
            // 
            this.gameObject.Location = new System.Drawing.Point(85, 92);
            this.gameObject.Name = "gameObject";
            this.gameObject.Size = new System.Drawing.Size(100, 50);
            this.gameObject.TabIndex = 0;
            this.gameObject.TabStop = false;
            this.gameObject.Visible = false;
            this.gameObject.Click += new System.EventHandler(this.gameObject_Click);
            // 
            // GameForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.gameField);
            this.Controls.Add(this.controlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.diffGroupBox.ResumeLayout(false);
            this.diffGroupBox.PerformLayout();
            this.gameField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameObject)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label timerTitleLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreTitleLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox diffGroupBox;
        private System.Windows.Forms.RadioButton hardRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton easyRadioButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Panel gameField;
        private System.Windows.Forms.PictureBox gameObject;
    }
}

