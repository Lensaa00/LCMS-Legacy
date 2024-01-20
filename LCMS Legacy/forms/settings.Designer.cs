namespace LCMS_Legacy.forms
{
    partial class settings
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
            groupBox1 = new GroupBox();
            profilesButton = new Button();
            gameButton = new Button();
            profilesPathTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gamePathTextBox = new TextBox();
            saveSettingsButton = new Button();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            closeOnGameStart = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(profilesButton);
            groupBox1.Controls.Add(gameButton);
            groupBox1.Controls.Add(profilesPathTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(gamePathTextBox);
            groupBox1.Location = new Point(273, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 146);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пути";
            // 
            // profilesButton
            // 
            profilesButton.BackColor = Color.Silver;
            profilesButton.FlatAppearance.BorderSize = 0;
            profilesButton.FlatStyle = FlatStyle.Flat;
            profilesButton.Location = new Point(233, 98);
            profilesButton.Name = "profilesButton";
            profilesButton.Size = new Size(100, 34);
            profilesButton.TabIndex = 5;
            profilesButton.Text = "Открыть";
            profilesButton.UseVisualStyleBackColor = false;
            profilesButton.Click += profilesButton_Click;
            // 
            // gameButton
            // 
            gameButton.BackColor = Color.Silver;
            gameButton.FlatAppearance.BorderSize = 0;
            gameButton.FlatStyle = FlatStyle.Flat;
            gameButton.Location = new Point(233, 37);
            gameButton.Name = "gameButton";
            gameButton.Size = new Size(100, 34);
            gameButton.TabIndex = 4;
            gameButton.Text = "Открыть";
            gameButton.UseVisualStyleBackColor = false;
            gameButton.Click += gameButton_Click;
            // 
            // profilesPathTextBox
            // 
            profilesPathTextBox.BackColor = Color.Silver;
            profilesPathTextBox.BorderStyle = BorderStyle.None;
            profilesPathTextBox.Location = new Point(10, 98);
            profilesPathTextBox.Multiline = true;
            profilesPathTextBox.Name = "profilesPathTextBox";
            profilesPathTextBox.ReadOnly = true;
            profilesPathTextBox.Size = new Size(217, 34);
            profilesPathTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 74);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 2;
            label2.Text = "Путь к профилям";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 19);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "Путь к игре";
            // 
            // gamePathTextBox
            // 
            gamePathTextBox.BackColor = Color.Silver;
            gamePathTextBox.BorderStyle = BorderStyle.None;
            gamePathTextBox.Location = new Point(10, 37);
            gamePathTextBox.Multiline = true;
            gamePathTextBox.Name = "gamePathTextBox";
            gamePathTextBox.ReadOnly = true;
            gamePathTextBox.Size = new Size(217, 34);
            gamePathTextBox.TabIndex = 0;
            // 
            // saveSettingsButton
            // 
            saveSettingsButton.BackColor = Color.Silver;
            saveSettingsButton.FlatAppearance.BorderSize = 0;
            saveSettingsButton.FlatStyle = FlatStyle.Flat;
            saveSettingsButton.Location = new Point(255, 151);
            saveSettingsButton.Name = "saveSettingsButton";
            saveSettingsButton.Size = new Size(343, 34);
            saveSettingsButton.TabIndex = 1;
            saveSettingsButton.Text = "Сохранить";
            saveSettingsButton.UseVisualStyleBackColor = false;
            saveSettingsButton.Click += saveSettingsButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(saveSettingsButton);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(604, 191);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Авторы";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(8, 55);
            label5.Name = "label5";
            label5.Size = new Size(149, 15);
            label5.TabIndex = 2;
            label5.Text = "By Lensaa00, Belekov Aden";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 40);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 1;
            label4.Text = "Version 1.0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 0;
            label3.Text = "LCMS Legacy";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(closeOnGameStart);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(255, 146);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Приложение";
            // 
            // closeOnGameStart
            // 
            closeOnGameStart.AutoSize = true;
            closeOnGameStart.Location = new Point(8, 22);
            closeOnGameStart.Name = "closeOnGameStart";
            closeOnGameStart.Size = new Size(196, 19);
            closeOnGameStart.TabIndex = 0;
            closeOnGameStart.Text = "Закрывать после запуска игры";
            closeOnGameStart.UseVisualStyleBackColor = true;
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 368);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки";
            Load += settings_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button profilesButton;
        private Button gameButton;
        private TextBox profilesPathTextBox;
        private Label label2;
        private Label label1;
        private TextBox gamePathTextBox;
        private Button saveSettingsButton;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label5;
        private GroupBox groupBox3;
        private CheckBox closeOnGameStart;
    }
}