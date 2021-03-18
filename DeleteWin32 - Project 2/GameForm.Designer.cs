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

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.contolPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeTitleLable = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.scoreTitleLable = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.difGroupBox = new System.Windows.Forms.GroupBox();
            this.hardLevel = new System.Windows.Forms.RadioButton();
            this.mediumLevel = new System.Windows.Forms.RadioButton();
            this.eazyLevel = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.gamingField = new System.Windows.Forms.Panel();
            this.gameObject = new System.Windows.Forms.PictureBox();
            this.contolPanel.SuspendLayout();
            this.infoGroupBox.SuspendLayout();
            this.difGroupBox.SuspendLayout();
            this.gamingField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameObject)).BeginInit();
            this.SuspendLayout();
            // 
            // contolPanel
            // 
            this.contolPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.contolPanel.Controls.Add(this.label1);
            this.contolPanel.Controls.Add(this.infoGroupBox);
            this.contolPanel.Controls.Add(this.difGroupBox);
            this.contolPanel.Controls.Add(this.startButton);
            this.contolPanel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.contolPanel.Location = new System.Drawing.Point(0, 0);
            this.contolPanel.Name = "contolPanel";
            this.contolPanel.Size = new System.Drawing.Size(240, 861);
            this.contolPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.timeLabel);
            this.infoGroupBox.Controls.Add(this.timeTitleLable);
            this.infoGroupBox.Controls.Add(this.exitButton);
            this.infoGroupBox.Controls.Add(this.scoreTitleLable);
            this.infoGroupBox.Controls.Add(this.scoreLabel);
            this.infoGroupBox.Location = new System.Drawing.Point(12, 363);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(156, 210);
            this.infoGroupBox.TabIndex = 12;
            this.infoGroupBox.TabStop = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Black;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.timeLabel.Location = new System.Drawing.Point(50, 116);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(16, 18);
            this.timeLabel.TabIndex = 11;
            this.timeLabel.Text = "0";
            // 
            // timeTitleLable
            // 
            this.timeTitleLable.AutoSize = true;
            this.timeTitleLable.BackColor = System.Drawing.Color.Black;
            this.timeTitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeTitleLable.ForeColor = System.Drawing.Color.DarkOrange;
            this.timeTitleLable.Location = new System.Drawing.Point(5, 80);
            this.timeTitleLable.Name = "timeTitleLable";
            this.timeTitleLable.Size = new System.Drawing.Size(47, 20);
            this.timeTitleLable.TabIndex = 10;
            this.timeTitleLable.Text = "Time:";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkOrange;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.Navy;
            this.exitButton.Location = new System.Drawing.Point(0, 160);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 29);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // scoreTitleLable
            // 
            this.scoreTitleLable.AutoSize = true;
            this.scoreTitleLable.BackColor = System.Drawing.Color.Black;
            this.scoreTitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreTitleLable.ForeColor = System.Drawing.Color.DarkOrange;
            this.scoreTitleLable.Location = new System.Drawing.Point(5, 8);
            this.scoreTitleLable.Name = "scoreTitleLable";
            this.scoreTitleLable.Size = new System.Drawing.Size(55, 20);
            this.scoreTitleLable.TabIndex = 8;
            this.scoreTitleLable.Text = "Score:";
            this.scoreTitleLable.Click += new System.EventHandler(this.label3_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Black;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.scoreLabel.Location = new System.Drawing.Point(50, 45);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(16, 18);
            this.scoreLabel.TabIndex = 7;
            this.scoreLabel.Text = "0";
            // 
            // difGroupBox
            // 
            this.difGroupBox.BackColor = System.Drawing.Color.DarkOrange;
            this.difGroupBox.Controls.Add(this.hardLevel);
            this.difGroupBox.Controls.Add(this.mediumLevel);
            this.difGroupBox.Controls.Add(this.eazyLevel);
            this.difGroupBox.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.difGroupBox.Location = new System.Drawing.Point(12, 153);
            this.difGroupBox.Name = "difGroupBox";
            this.difGroupBox.Size = new System.Drawing.Size(118, 150);
            this.difGroupBox.TabIndex = 5;
            this.difGroupBox.TabStop = false;
            this.difGroupBox.Text = "Difficulty";
            // 
            // hardLevel
            // 
            this.hardLevel.AutoSize = true;
            this.hardLevel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hardLevel.Location = new System.Drawing.Point(0, 102);
            this.hardLevel.Name = "hardLevel";
            this.hardLevel.Size = new System.Drawing.Size(56, 21);
            this.hardLevel.TabIndex = 4;
            this.hardLevel.TabStop = true;
            this.hardLevel.Text = "Hard";
            this.hardLevel.UseVisualStyleBackColor = true;
            // 
            // mediumLevel
            // 
            this.mediumLevel.AutoSize = true;
            this.mediumLevel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mediumLevel.Location = new System.Drawing.Point(0, 64);
            this.mediumLevel.Name = "mediumLevel";
            this.mediumLevel.Size = new System.Drawing.Size(74, 21);
            this.mediumLevel.TabIndex = 3;
            this.mediumLevel.TabStop = true;
            this.mediumLevel.Text = "Medium";
            this.mediumLevel.UseVisualStyleBackColor = true;
            // 
            // eazyLevel
            // 
            this.eazyLevel.AutoSize = true;
            this.eazyLevel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eazyLevel.Location = new System.Drawing.Point(0, 26);
            this.eazyLevel.Name = "eazyLevel";
            this.eazyLevel.Size = new System.Drawing.Size(55, 21);
            this.eazyLevel.TabIndex = 2;
            this.eazyLevel.TabStop = true;
            this.eazyLevel.Text = "Eazy";
            this.eazyLevel.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Orange;
            this.startButton.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.startButton.Location = new System.Drawing.Point(21, 72);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(95, 35);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            // 
            // gamingField
            // 
            this.gamingField.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.gamingField.Controls.Add(this.gameObject);
            this.gamingField.Location = new System.Drawing.Point(235, 0);
            this.gamingField.Name = "gamingField";
            this.gamingField.Size = new System.Drawing.Size(1009, 601);
            this.gamingField.TabIndex = 1;
            // 
            // gameObject
            // 
            this.gameObject.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gameObject.Image = ((System.Drawing.Image)(resources.GetObject("gameObject.Image")));
            this.gameObject.InitialImage = null;
            this.gameObject.Location = new System.Drawing.Point(364, 118);
            this.gameObject.Name = "gameObject";
            this.gameObject.Size = new System.Drawing.Size(339, 234);
            this.gameObject.TabIndex = 0;
            this.gameObject.TabStop = false;
            // 
            // GameForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.gamingField);
            this.Controls.Add(this.contolPanel);
            this.Name = "GameForm";
            this.contolPanel.ResumeLayout(false);
            this.contolPanel.PerformLayout();
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.difGroupBox.ResumeLayout(false);
            this.difGroupBox.PerformLayout();
            this.gamingField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameObject)).EndInit();

            this.SuspendLayout();
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(942, 552);
            this.Name = "Form1";

            this.ResumeLayout(false);

        }

        #endregion

  
    }
}

