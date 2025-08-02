namespace PrImage.JsonBlueprints
{
    partial class FormPassword
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
            tableLayoutPanel1 = new TableLayoutPanel();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            buttonConfirm = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(labelPassword, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxPassword, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonConfirm, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(600, 180);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Dock = DockStyle.Fill;
            labelPassword.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelPassword.Location = new Point(20, 10);
            labelPassword.Margin = new Padding(20, 10, 3, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(577, 30);
            labelPassword.TabIndex = 0;
            labelPassword.Text = "Enter the Password to decrypt your library";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Location = new Point(30, 50);
            textBoxPassword.Margin = new Padding(30, 10, 50, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(520, 37);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonConfirm.AutoSize = true;
            buttonConfirm.Location = new Point(484, 125);
            buttonConfirm.Margin = new Padding(3, 1, 15, 15);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(101, 40);
            buttonConfirm.TabIndex = 2;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // FormPassword
            // 
            AcceptButton = buttonConfirm;
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(600, 180);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(600, 180);
            Name = "FormPassword";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enter Password";
            TopMost = true;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonConfirm;
    }
}