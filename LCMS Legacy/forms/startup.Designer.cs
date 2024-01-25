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
            panel1 = new Panel();
            minimizeApp = new Button();
            closeApp = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(129, 129, 212);
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
            label1.TabIndex = 0;
            label1.Text = "Путь к игре";
            // 
            // gamePathTextBox
            // 
            gamePathTextBox.BackColor = Color.FromArgb(129, 129, 212);
            gamePathTextBox.BorderStyle = BorderStyle.None;
            gamePathTextBox.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gamePathTextBox.ForeColor = Color.White;
            gamePathTextBox.Location = new Point(12, 60);
            gamePathTextBox.Multiline = true;
            gamePathTextBox.Name = "gamePathTextBox";
            gamePathTextBox.ReadOnly = true;
            gamePathTextBox.Size = new Size(195, 34);
            gamePathTextBox.TabIndex = 1;
            // 
            // profilesPathTextBox
            // 
            profilesPathTextBox.BackColor = Color.FromArgb(129, 129, 212);
            profilesPathTextBox.BorderStyle = BorderStyle.None;
            profilesPathTextBox.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            profilesPathTextBox.ForeColor = Color.White;
            profilesPathTextBox.Location = new Point(12, 115);
            profilesPathTextBox.Multiline = true;
            profilesPathTextBox.Name = "profilesPathTextBox";
            profilesPathTextBox.ReadOnly = true;
            profilesPathTextBox.Size = new Size(195, 34);
            profilesPathTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(129, 129, 212);
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(126, 17);
            label2.TabIndex = 2;
            label2.Text = "Путь к профилям";
            // 
            // gameButton
            // 
            gameButton.BackColor = Color.FromArgb(129, 129, 212);
            gameButton.FlatAppearance.BorderSize = 0;
            gameButton.FlatStyle = FlatStyle.Flat;
            gameButton.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gameButton.ForeColor = Color.White;
            gameButton.Location = new Point(213, 60);
            gameButton.Name = "gameButton";
            gameButton.Size = new Size(103, 34);
            gameButton.TabIndex = 4;
            gameButton.Text = "Открыть";
            gameButton.UseVisualStyleBackColor = false;
            gameButton.Click += gameButton_Click;
            // 
            // profilesButton
            // 
            profilesButton.BackColor = Color.FromArgb(129, 129, 212);
            profilesButton.FlatAppearance.BorderSize = 0;
            profilesButton.FlatStyle = FlatStyle.Flat;
            profilesButton.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            profilesButton.ForeColor = Color.White;
            profilesButton.Location = new Point(213, 115);
            profilesButton.Name = "profilesButton";
            profilesButton.Size = new Size(103, 34);
            profilesButton.TabIndex = 5;
            profilesButton.Text = "Открыть";
            profilesButton.UseVisualStyleBackColor = false;
            profilesButton.Click += profilesButton_Click;
            // 
            // saveChangesButton
            // 
            saveChangesButton.BackColor = Color.FromArgb(129, 129, 212);
            saveChangesButton.FlatAppearance.BorderSize = 0;
            saveChangesButton.FlatStyle = FlatStyle.Flat;
            saveChangesButton.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            saveChangesButton.ForeColor = Color.White;
            saveChangesButton.Location = new Point(12, 155);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(304, 34);
            saveChangesButton.TabIndex = 6;
            saveChangesButton.Text = "Сохранить";
            saveChangesButton.UseVisualStyleBackColor = false;
            saveChangesButton.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(129, 129, 212);
            panel1.Controls.Add(minimizeApp);
            panel1.Controls.Add(closeApp);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 35);
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
            minimizeApp.Location = new Point(259, 0);
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
            closeApp.Location = new Point(296, 0);
            closeApp.Name = "closeApp";
            closeApp.Size = new Size(35, 35);
            closeApp.TabIndex = 3;
            closeApp.Text = "x";
            closeApp.UseVisualStyleBackColor = false;
            closeApp.Click += closeApp_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(7, 7);
            label3.Name = "label3";
            label3.Size = new Size(57, 22);
            label3.TabIndex = 2;
            label3.Text = "LCMS";
            // 
            // startup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 52, 85);
            ClientSize = new Size(331, 202);
            Controls.Add(panel1);
            Controls.Add(saveChangesButton);
            Controls.Add(profilesButton);
            Controls.Add(gameButton);
            Controls.Add(profilesPathTextBox);
            Controls.Add(label2);
            Controls.Add(gamePathTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "startup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Первоначальная настройка";
            FormClosing += startup_FormClosing;
            FormClosed += startup_FormClosed;
            Load += startup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Button minimizeApp;
        private Button closeApp;
        private Label label3;
    }
}