namespace LCMS_Legacy
{
    partial class main
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
            profilesBox = new ListBox();
            label1 = new Label();
            startModded = new Button();
            startVanilla = new Button();
            settings = new Button();
            updateProfiles = new Button();
            panel1 = new Panel();
            minimizeApp = new Button();
            closeApp = new Button();
            label2 = new Label();
            panel2 = new Panel();
            selectedProfileText = new Label();
            labelProfile = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // profilesBox
            // 
            profilesBox.BackColor = Color.FromArgb(68, 68, 117);
            profilesBox.BorderStyle = BorderStyle.None;
            profilesBox.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            profilesBox.ForeColor = Color.White;
            profilesBox.FormattingEnabled = true;
            profilesBox.ItemHeight = 17;
            profilesBox.Location = new Point(10, 58);
            profilesBox.Name = "profilesBox";
            profilesBox.Size = new Size(151, 136);
            profilesBox.Sorted = true;
            profilesBox.TabIndex = 0;
            profilesBox.SelectedIndexChanged += profilesBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(129, 129, 212);
            label1.Location = new Point(8, 38);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 1;
            label1.Text = "Профили";
            // 
            // startModded
            // 
            startModded.BackColor = Color.FromArgb(129, 129, 212);
            startModded.FlatAppearance.BorderColor = Color.FromArgb(133, 156, 219);
            startModded.FlatAppearance.BorderSize = 0;
            startModded.FlatStyle = FlatStyle.Flat;
            startModded.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            startModded.ForeColor = Color.White;
            startModded.Location = new Point(167, 58);
            startModded.Name = "startModded";
            startModded.Size = new Size(151, 36);
            startModded.TabIndex = 2;
            startModded.Text = "Запуск [Modded]";
            startModded.UseVisualStyleBackColor = false;
            startModded.Click += startModded_Click;
            // 
            // startVanilla
            // 
            startVanilla.BackColor = Color.FromArgb(68, 68, 117);
            startVanilla.FlatAppearance.BorderColor = Color.FromArgb(133, 156, 219);
            startVanilla.FlatAppearance.BorderSize = 0;
            startVanilla.FlatStyle = FlatStyle.Flat;
            startVanilla.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            startVanilla.ForeColor = Color.White;
            startVanilla.Location = new Point(167, 100);
            startVanilla.Name = "startVanilla";
            startVanilla.Size = new Size(151, 36);
            startVanilla.TabIndex = 3;
            startVanilla.Text = "Запуск [Vanilla]";
            startVanilla.UseVisualStyleBackColor = false;
            startVanilla.Click += startVanilla_Click;
            // 
            // settings
            // 
            settings.BackColor = Color.FromArgb(68, 68, 117);
            settings.FlatAppearance.BorderColor = Color.FromArgb(133, 156, 219);
            settings.FlatAppearance.BorderSize = 0;
            settings.FlatStyle = FlatStyle.Flat;
            settings.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            settings.ForeColor = Color.White;
            settings.Location = new Point(167, 142);
            settings.Name = "settings";
            settings.Size = new Size(151, 36);
            settings.TabIndex = 4;
            settings.Text = "Настройки";
            settings.UseVisualStyleBackColor = false;
            settings.Click += settings_Click;
            // 
            // updateProfiles
            // 
            updateProfiles.BackColor = Color.FromArgb(68, 68, 117);
            updateProfiles.FlatAppearance.BorderColor = Color.FromArgb(133, 156, 219);
            updateProfiles.FlatAppearance.BorderSize = 0;
            updateProfiles.FlatStyle = FlatStyle.Flat;
            updateProfiles.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            updateProfiles.ForeColor = Color.White;
            updateProfiles.Location = new Point(10, 259);
            updateProfiles.Name = "updateProfiles";
            updateProfiles.Size = new Size(151, 36);
            updateProfiles.TabIndex = 5;
            updateProfiles.Text = "Обновить";
            updateProfiles.UseVisualStyleBackColor = false;
            updateProfiles.Click += updateProfiles_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(129, 129, 212);
            panel1.Controls.Add(minimizeApp);
            panel1.Controls.Add(closeApp);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 35);
            panel1.TabIndex = 6;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // minimizeApp
            // 
            minimizeApp.BackColor = Color.FromArgb(129, 129, 212);
            minimizeApp.FlatAppearance.BorderColor = Color.FromArgb(133, 156, 219);
            minimizeApp.FlatAppearance.BorderSize = 0;
            minimizeApp.FlatStyle = FlatStyle.Flat;
            minimizeApp.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            minimizeApp.ForeColor = Color.White;
            minimizeApp.Location = new Point(257, 0);
            minimizeApp.Name = "minimizeApp";
            minimizeApp.Size = new Size(35, 35);
            minimizeApp.TabIndex = 4;
            minimizeApp.Text = "_";
            minimizeApp.UseVisualStyleBackColor = false;
            minimizeApp.Click += minimizeApp_Click;
            // 
            // closeApp
            // 
            closeApp.BackColor = Color.FromArgb(129, 129, 212);
            closeApp.FlatAppearance.BorderColor = Color.FromArgb(133, 156, 219);
            closeApp.FlatAppearance.BorderSize = 0;
            closeApp.FlatStyle = FlatStyle.Flat;
            closeApp.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeApp.ForeColor = Color.White;
            closeApp.Location = new Point(294, 0);
            closeApp.Name = "closeApp";
            closeApp.Size = new Size(35, 35);
            closeApp.TabIndex = 3;
            closeApp.Text = "x";
            closeApp.UseVisualStyleBackColor = false;
            closeApp.Click += closeApp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(7, 7);
            label2.Name = "label2";
            label2.Size = new Size(57, 22);
            label2.TabIndex = 2;
            label2.Text = "LCMS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(68, 68, 117);
            panel2.Controls.Add(selectedProfileText);
            panel2.Location = new Point(10, 217);
            panel2.Name = "panel2";
            panel2.Size = new Size(151, 36);
            panel2.TabIndex = 7;
            // 
            // selectedProfileText
            // 
            selectedProfileText.AutoSize = true;
            selectedProfileText.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            selectedProfileText.ForeColor = Color.White;
            selectedProfileText.Location = new Point(3, 10);
            selectedProfileText.Name = "selectedProfileText";
            selectedProfileText.Size = new Size(48, 17);
            selectedProfileText.TabIndex = 0;
            selectedProfileText.Text = "label3";
            // 
            // labelProfile
            // 
            labelProfile.AutoSize = true;
            labelProfile.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelProfile.ForeColor = Color.FromArgb(129, 129, 212);
            labelProfile.Location = new Point(10, 197);
            labelProfile.Name = "labelProfile";
            labelProfile.Size = new Size(62, 17);
            labelProfile.TabIndex = 8;
            labelProfile.Text = "Выбран";
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 52, 85);
            ClientSize = new Size(329, 308);
            Controls.Add(labelProfile);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(updateProfiles);
            Controls.Add(settings);
            Controls.Add(label1);
            Controls.Add(startVanilla);
            Controls.Add(startModded);
            Controls.Add(profilesBox);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LCMS Legacy";
            Load += main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox profilesBox;
        private Label label1;
        private Button startModded;
        private Button startVanilla;
        private Button settings;
        private Button updateProfiles;
        private Panel panel1;
        private Button minimizeApp;
        private Button closeApp;
        private Label label2;
        private Panel panel2;
        private Label labelProfile;
        private Label selectedProfileText;
    }
}