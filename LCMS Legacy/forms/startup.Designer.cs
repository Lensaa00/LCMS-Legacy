namespace LCMS_Legacy.forms
{
    partial class startup
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
            label1 = new Label();
            gamePathTextBox = new TextBox();
            profilesPathTextBox = new TextBox();
            label2 = new Label();
            gameButton = new Button();
            profilesButton = new Button();
            saveChangesButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Путь к игре";
            // 
            // gamePathTextBox
            // 
            gamePathTextBox.BackColor = Color.Silver;
            gamePathTextBox.BorderStyle = BorderStyle.None;
            gamePathTextBox.Location = new Point(12, 27);
            gamePathTextBox.Multiline = true;
            gamePathTextBox.Name = "gamePathTextBox";
            gamePathTextBox.Size = new Size(195, 34);
            gamePathTextBox.TabIndex = 1;
            // 
            // profilesPathTextBox
            // 
            profilesPathTextBox.BackColor = Color.Silver;
            profilesPathTextBox.BorderStyle = BorderStyle.None;
            profilesPathTextBox.Location = new Point(12, 82);
            profilesPathTextBox.Multiline = true;
            profilesPathTextBox.Name = "profilesPathTextBox";
            profilesPathTextBox.Size = new Size(195, 34);
            profilesPathTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 2;
            label2.Text = "Путь к профилям";
            // 
            // gameButton
            // 
            gameButton.BackColor = Color.Silver;
            gameButton.FlatAppearance.BorderSize = 0;
            gameButton.FlatStyle = FlatStyle.Flat;
            gameButton.Location = new Point(213, 27);
            gameButton.Name = "gameButton";
            gameButton.Size = new Size(103, 34);
            gameButton.TabIndex = 4;
            gameButton.Text = "Открыть";
            gameButton.UseVisualStyleBackColor = false;
            gameButton.Click += gameButton_Click;
            // 
            // profilesButton
            // 
            profilesButton.BackColor = Color.Silver;
            profilesButton.FlatAppearance.BorderSize = 0;
            profilesButton.FlatStyle = FlatStyle.Flat;
            profilesButton.Location = new Point(213, 82);
            profilesButton.Name = "profilesButton";
            profilesButton.Size = new Size(103, 34);
            profilesButton.TabIndex = 5;
            profilesButton.Text = "Открыть";
            profilesButton.UseVisualStyleBackColor = false;
            profilesButton.Click += profilesButton_Click;
            // 
            // saveChangesButton
            // 
            saveChangesButton.BackColor = Color.Silver;
            saveChangesButton.FlatAppearance.BorderSize = 0;
            saveChangesButton.FlatStyle = FlatStyle.Flat;
            saveChangesButton.Location = new Point(12, 122);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(304, 34);
            saveChangesButton.TabIndex = 6;
            saveChangesButton.Text = "Сохранить";
            saveChangesButton.UseVisualStyleBackColor = false;
            saveChangesButton.Click += button3_Click;
            // 
            // startup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 171);
            Controls.Add(saveChangesButton);
            Controls.Add(profilesButton);
            Controls.Add(gameButton);
            Controls.Add(profilesPathTextBox);
            Controls.Add(label2);
            Controls.Add(gamePathTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "startup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Первоначальная настройка";
            FormClosing += startup_FormClosing;
            FormClosed += startup_FormClosed;
            Load += startup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox gamePathTextBox;
        private TextBox profilesPathTextBox;
        private Label label2;
        private Button gameButton;
        private Button profilesButton;
        private Button saveChangesButton;
    }
}