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
            profilesBox.BackColor = Color.Silver;
            profilesBox.BorderStyle = BorderStyle.None;
            profilesBox.FormattingEnabled = true;
            profilesBox.ItemHeight = 20;
            profilesBox.Location = new Point(14, 36);
            profilesBox.Margin = new Padding(3, 4, 3, 4);
            profilesBox.Name = "profilesBox";
            profilesBox.Size = new Size(173, 260);
            profilesBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 12);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "Профили";
            // 
            // startModded
            // 
            startModded.BackColor = Color.Silver;
            startModded.FlatAppearance.BorderSize = 0;
            startModded.FlatStyle = FlatStyle.Flat;
            startModded.Location = new Point(193, 36);
            startModded.Margin = new Padding(3, 4, 3, 4);
            startModded.Name = "startModded";
            startModded.Size = new Size(173, 48);
            startModded.TabIndex = 2;
            startModded.Text = "Запуск [Modded]";
            startModded.UseVisualStyleBackColor = false;
            // 
            // startVanilla
            // 
            startVanilla.BackColor = Color.Silver;
            startVanilla.FlatAppearance.BorderSize = 0;
            startVanilla.FlatStyle = FlatStyle.Flat;
            startVanilla.Location = new Point(193, 92);
            startVanilla.Margin = new Padding(3, 4, 3, 4);
            startVanilla.Name = "startVanilla";
            startVanilla.Size = new Size(173, 48);
            startVanilla.TabIndex = 3;
            startVanilla.Text = "Запуск [Vanilla]";
            startVanilla.UseVisualStyleBackColor = false;
            // 
            // settings
            // 
            settings.BackColor = Color.Silver;
            settings.FlatAppearance.BorderSize = 0;
            settings.FlatStyle = FlatStyle.Flat;
            settings.Location = new Point(193, 148);
            settings.Margin = new Padding(3, 4, 3, 4);
            settings.Name = "settings";
            settings.Size = new Size(173, 48);
            settings.TabIndex = 4;
            settings.Text = "Настройки";
            settings.UseVisualStyleBackColor = false;
            settings.Click += settings_Click;
            // 
            // updateProfiles
            // 
            updateProfiles.BackColor = Color.Silver;
            updateProfiles.FlatAppearance.BorderSize = 0;
            updateProfiles.FlatStyle = FlatStyle.Flat;
            updateProfiles.Location = new Point(14, 304);
            updateProfiles.Margin = new Padding(3, 4, 3, 4);
            updateProfiles.Name = "updateProfiles";
            updateProfiles.Size = new Size(173, 48);
            updateProfiles.TabIndex = 5;
            updateProfiles.Text = "Обновить";
            updateProfiles.UseVisualStyleBackColor = false;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 369);
            Controls.Add(updateProfiles);
            Controls.Add(settings);
            Controls.Add(startVanilla);
            Controls.Add(startModded);
            Controls.Add(label1);
            Controls.Add(profilesBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "main";
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