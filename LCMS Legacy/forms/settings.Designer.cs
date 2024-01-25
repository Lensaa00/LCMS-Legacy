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
            profilesButton = new Button();
            gameButton = new Button();
            profilesPathTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gamePathTextBox = new TextBox();
            saveSettingsButton = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            closeOnGameStart = new CheckBox();
            panel1 = new Panel();
            minimizeApp = new Button();
            closeApp = new Button();
            label6 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            panel4 = new Panel();
            appUpdateCheck = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // profilesButton
            // 
            profilesButton.BackColor = Color.FromArgb(129, 129, 212);
            profilesButton.FlatAppearance.BorderSize = 0;
            profilesButton.FlatStyle = FlatStyle.Flat;
            profilesButton.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            profilesButton.ForeColor = Color.White;
            profilesButton.Location = new Point(238, 85);
            profilesButton.Name = "profilesButton";
            profilesButton.Size = new Size(100, 34);
            profilesButton.TabIndex = 5;
            profilesButton.Text = "Открыть";
            profilesButton.UseVisualStyleBackColor = false;
            profilesButton.Click += profilesButton_Click;
            // 
            // gameButton
            // 
            gameButton.BackColor = Color.FromArgb(129, 129, 212);
            gameButton.FlatAppearance.BorderSize = 0;
            gameButton.FlatStyle = FlatStyle.Flat;
            gameButton.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gameButton.ForeColor = Color.White;
            gameButton.Location = new Point(238, 30);
            gameButton.Name = "gameButton";
            gameButton.Size = new Size(100, 34);
            gameButton.TabIndex = 4;
            gameButton.Text = "Открыть";
            gameButton.UseVisualStyleBackColor = false;
            gameButton.Click += gameButton_Click;
            // 
            // profilesPathTextBox
            // 
            profilesPathTextBox.BackColor = Color.FromArgb(129, 129, 212);
            profilesPathTextBox.BorderStyle = BorderStyle.None;
            profilesPathTextBox.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            profilesPathTextBox.ForeColor = Color.White;
            profilesPathTextBox.Location = new Point(15, 85);
            profilesPathTextBox.Multiline = true;
            profilesPathTextBox.Name = "profilesPathTextBox";
            profilesPathTextBox.ReadOnly = true;
            profilesPathTextBox.Size = new Size(217, 34);
            profilesPathTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(155, 155, 255);
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 2;
            label2.Text = "Путь к профилям";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(155, 155, 255);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 1;
            label1.Text = "Путь к игре";
            // 
            // gamePathTextBox
            // 
            gamePathTextBox.BackColor = Color.FromArgb(129, 129, 212);
            gamePathTextBox.BorderStyle = BorderStyle.None;
            gamePathTextBox.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gamePathTextBox.ForeColor = Color.White;
            gamePathTextBox.Location = new Point(15, 30);
            gamePathTextBox.Multiline = true;
            gamePathTextBox.Name = "gamePathTextBox";
            gamePathTextBox.ReadOnly = true;
            gamePathTextBox.Size = new Size(217, 34);
            gamePathTextBox.TabIndex = 0;
            // 
            // saveSettingsButton
            // 
            saveSettingsButton.BackColor = Color.FromArgb(129, 129, 212);
            saveSettingsButton.DialogResult = DialogResult.OK;
            saveSettingsButton.FlatAppearance.BorderSize = 0;
            saveSettingsButton.FlatStyle = FlatStyle.Flat;
            saveSettingsButton.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            saveSettingsButton.ForeColor = Color.White;
            saveSettingsButton.Location = new Point(248, 150);
            saveSettingsButton.Name = "saveSettingsButton";
            saveSettingsButton.Size = new Size(343, 34);
            saveSettingsButton.TabIndex = 1;
            saveSettingsButton.Text = "Сохранить";
            saveSettingsButton.UseVisualStyleBackColor = false;
            saveSettingsButton.Click += saveSettingsButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(155, 155, 255);
            label5.Location = new Point(6, 46);
            label5.Name = "label5";
            label5.Size = new Size(149, 15);
            label5.TabIndex = 2;
            label5.Text = "By Lensaa00, Belekov Aden";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(155, 155, 255);
            label4.Location = new Point(6, 28);
            label4.Name = "label4";
            label4.Size = new Size(92, 17);
            label4.TabIndex = 1;
            label4.Text = "Version 1.0.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(4, 7);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 0;
            label3.Text = "LCMS Legacy";
            // 
            // closeOnGameStart
            // 
            closeOnGameStart.AutoSize = true;
            closeOnGameStart.FlatAppearance.CheckedBackColor = Color.Silver;
            closeOnGameStart.Font = new Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            closeOnGameStart.ForeColor = Color.FromArgb(155, 155, 255);
            closeOnGameStart.Location = new Point(12, 11);
            closeOnGameStart.Name = "closeOnGameStart";
            closeOnGameStart.Size = new Size(220, 19);
            closeOnGameStart.TabIndex = 0;
            closeOnGameStart.Text = "Закрывать после запуска игры";
            closeOnGameStart.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(129, 129, 212);
            panel1.Controls.Add(minimizeApp);
            panel1.Controls.Add(closeApp);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(621, 35);
            panel1.TabIndex = 7;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // minimizeApp
            // 
            minimizeApp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeApp.BackColor = Color.FromArgb(129, 129, 212);
            minimizeApp.FlatAppearance.BorderColor = Color.FromArgb(133, 156, 219);
            minimizeApp.FlatAppearance.BorderSize = 0;
            minimizeApp.FlatStyle = FlatStyle.Flat;
            minimizeApp.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            minimizeApp.ForeColor = Color.White;
            minimizeApp.Location = new Point(549, 0);
            minimizeApp.Name = "minimizeApp";
            minimizeApp.Size = new Size(35, 35);
            minimizeApp.TabIndex = 4;
            minimizeApp.Text = "_";
            minimizeApp.UseVisualStyleBackColor = false;
            minimizeApp.Click += minimizeApp_Click;
            // 
            // closeApp
            // 
            closeApp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeApp.BackColor = Color.FromArgb(129, 129, 212);
            closeApp.FlatAppearance.BorderColor = Color.FromArgb(133, 156, 219);
            closeApp.FlatAppearance.BorderSize = 0;
            closeApp.FlatStyle = FlatStyle.Flat;
            closeApp.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeApp.ForeColor = Color.White;
            closeApp.Location = new Point(586, 0);
            closeApp.Name = "closeApp";
            closeApp.Size = new Size(35, 35);
            closeApp.TabIndex = 3;
            closeApp.Text = "x";
            closeApp.UseVisualStyleBackColor = false;
            closeApp.Click += closeApp_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(7, 7);
            label6.Name = "label6";
            label6.Size = new Size(164, 22);
            label6.TabIndex = 2;
            label6.Text = "LCMS | Настройки";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(71, 71, 110);
            panel2.Controls.Add(closeOnGameStart);
            panel2.Location = new Point(10, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 136);
            panel2.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(10, 44);
            label7.Name = "label7";
            label7.Size = new Size(103, 18);
            label7.TabIndex = 9;
            label7.Text = "Приложение";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(71, 71, 110);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(gamePathTextBox);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(profilesPathTextBox);
            panel3.Controls.Add(profilesButton);
            panel3.Controls.Add(gameButton);
            panel3.Location = new Point(258, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(351, 136);
            panel3.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(258, 44);
            label8.Name = "label8";
            label8.Size = new Size(43, 18);
            label8.TabIndex = 10;
            label8.Text = "Пути";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(71, 71, 110);
            panel4.Controls.Add(appUpdateCheck);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(saveSettingsButton);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(10, 207);
            panel4.Name = "panel4";
            panel4.Size = new Size(599, 193);
            panel4.TabIndex = 9;
            // 
            // appUpdateCheck
            // 
            appUpdateCheck.BackColor = Color.FromArgb(129, 129, 212);
            appUpdateCheck.FlatAppearance.BorderSize = 0;
            appUpdateCheck.FlatStyle = FlatStyle.Flat;
            appUpdateCheck.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            appUpdateCheck.ForeColor = Color.White;
            appUpdateCheck.Location = new Point(248, 110);
            appUpdateCheck.Name = "appUpdateCheck";
            appUpdateCheck.Size = new Size(343, 34);
            appUpdateCheck.TabIndex = 3;
            appUpdateCheck.Text = "Проверить обновления";
            appUpdateCheck.UseVisualStyleBackColor = false;
            appUpdateCheck.Click += appUpdateCheck_Click;
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 52, 85);
            ClientSize = new Size(621, 416);
            Controls.Add(panel4);
            Controls.Add(label8);
            Controls.Add(panel3);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки";
            Load += settings_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button profilesButton;
        private Button gameButton;
        private TextBox profilesPathTextBox;
        private Label label2;
        private Label label1;
        private TextBox gamePathTextBox;
        private Button saveSettingsButton;
        private Label label4;
        private Label label3;
        private Label label5;
        private CheckBox closeOnGameStart;
        private Panel panel1;
        private Button minimizeApp;
        private Button closeApp;
        private Label label6;
        private Panel panel2;
        private Label label7;
        private Panel panel3;
        private Label label8;
        private Panel panel4;
        private Button appUpdateCheck;
    }
}