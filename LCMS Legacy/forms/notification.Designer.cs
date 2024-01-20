namespace LCMS_Legacy.forms
{
    partial class notification
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
            label2 = new Label();
            confirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 29);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // confirm
            // 
            confirm.BackColor = Color.Silver;
            confirm.FlatAppearance.BorderSize = 0;
            confirm.FlatStyle = FlatStyle.Flat;
            confirm.Location = new Point(12, 74);
            confirm.Name = "confirm";
            confirm.Size = new Size(294, 37);
            confirm.TabIndex = 2;
            confirm.Text = "button1";
            confirm.UseVisualStyleBackColor = false;
            // 
            // notification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 123);
            Controls.Add(confirm);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "notification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "notification_title";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button confirm;
    }
}