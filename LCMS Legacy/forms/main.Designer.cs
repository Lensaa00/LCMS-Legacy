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
            SuspendLayout();
            // 
            // profilesBox
            // 
            profilesBox.BackColor = SystemColors.ActiveCaption;
            profilesBox.BorderStyle = BorderStyle.None;
            profilesBox.FormattingEnabled = true;
            profilesBox.ItemHeight = 15;
            profilesBox.Location = new Point(12, 27);
            profilesBox.Name = "profilesBox";
            profilesBox.Size = new Size(151, 195);
            profilesBox.TabIndex = 0;
            profilesBox.SelectedIndexChanged += profilesBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Профили";
            // 
            // startModded
            // 
            startModded.BackColor = SystemColors.ActiveCaption;
            startModded.FlatAppearance.BorderSize = 0;
            startModded.FlatStyle = FlatStyle.Flat;
            startModded.Location = new Point(169, 27);
            startModded.Name = "startModded";
            startModded.Size = new Size(151, 36);
            startModded.TabIndex = 2;
            startModded.Text = "Запуск [Modded]";
            startModded.UseVisualStyleBackColor = false;
            startModded.Click += startModded_Click;
            // 
            // startVanilla
            // 
            startVanilla.BackColor = SystemColors.ActiveCaption;
            startVanilla.FlatAppearance.BorderSize = 0;
            startVanilla.FlatStyle = FlatStyle.Flat;
            startVanilla.Location = new Point(169, 69);
            startVanilla.Name = "startVanilla";
            startVanilla.Size = new Size(151, 36);
            startVanilla.TabIndex = 3;
            startVanilla.Text = "Запуск [Vanilla]";
            startVanilla.UseVisualStyleBackColor = false;
            startVanilla.Click += startVanilla_Click;
            // 
            // settings
            // 
            settings.BackColor = SystemColors.ActiveCaption;
            settings.FlatAppearance.BorderSize = 0;
            settings.FlatStyle = FlatStyle.Flat;
            settings.Location = new Point(169, 111);
            settings.Name = "settings";
            settings.Size = new Size(151, 36);
            settings.TabIndex = 4;
            settings.Text = "Настройки";
            settings.UseVisualStyleBackColor = false;
            settings.Click += settings_Click;
            // 
            // updateProfiles
            // 
            updateProfiles.BackColor = SystemColors.ActiveCaption;
            updateProfiles.FlatAppearance.BorderSize = 0;
            updateProfiles.FlatStyle = FlatStyle.Flat;
            updateProfiles.Location = new Point(12, 228);
            updateProfiles.Name = "updateProfiles";
            updateProfiles.Size = new Size(151, 36);
            updateProfiles.TabIndex = 5;
            updateProfiles.Text = "Обновить";
            updateProfiles.UseVisualStyleBackColor = false;
            updateProfiles.Click += updateProfiles_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(329, 277);
            Controls.Add(updateProfiles);
            Controls.Add(settings);
            Controls.Add(startVanilla);
            Controls.Add(startModded);
            Controls.Add(label1);
            Controls.Add(profilesBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LCMS Legacy";
            Load += main_Load;
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
    }
}