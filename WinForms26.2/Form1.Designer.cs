namespace WinForms26._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbsum = new CheckBox();
            cbsub = new CheckBox();
            bt = new Button();
            tbfirst = new TextBox();
            tbsecond = new TextBox();
            tbres = new TextBox();
            btclear = new Button();
            SuspendLayout();
            // 
            // cbsum
            // 
            cbsum.AutoSize = true;
            cbsum.Location = new Point(255, 37);
            cbsum.Margin = new Padding(5, 6, 5, 6);
            cbsum.Name = "cbsum";
            cbsum.Size = new Size(130, 34);
            cbsum.TabIndex = 0;
            cbsum.Text = "Сложение";
            cbsum.UseVisualStyleBackColor = true;
            cbsum.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // cbsub
            // 
            cbsub.AutoSize = true;
            cbsub.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbsub.Location = new Point(255, 78);
            cbsub.Margin = new Padding(5, 6, 5, 6);
            cbsub.Name = "cbsub";
            cbsub.Size = new Size(138, 34);
            cbsub.TabIndex = 1;
            cbsub.Text = "Вычитание";
            cbsub.UseVisualStyleBackColor = true;
            cbsub.CheckedChanged += cbsub_CheckedChanged;
            // 
            // bt
            // 
            bt.Location = new Point(37, 185);
            bt.Margin = new Padding(5, 6, 5, 6);
            bt.Name = "bt";
            bt.Size = new Size(159, 46);
            bt.TabIndex = 2;
            bt.Text = "Посчитать";
            bt.UseVisualStyleBackColor = true;
            bt.Click += bt_Click;
            // 
            // tbfirst
            // 
            tbfirst.Font = new Font("Segoe UI", 15.75F);
            tbfirst.Location = new Point(37, 37);
            tbfirst.Margin = new Padding(5, 6, 5, 6);
            tbfirst.Name = "tbfirst";
            tbfirst.Size = new Size(58, 35);
            tbfirst.TabIndex = 3;
            tbfirst.TextChanged += tbfirst_TextChanged;
            // 
            // tbsecond
            // 
            tbsecond.Font = new Font("Segoe UI", 15.75F);
            tbsecond.Location = new Point(138, 37);
            tbsecond.Margin = new Padding(5, 6, 5, 6);
            tbsecond.Name = "tbsecond";
            tbsecond.Size = new Size(58, 35);
            tbsecond.TabIndex = 4;
            // 
            // tbres
            // 
            tbres.Anchor = AnchorStyles.None;
            tbres.Font = new Font("Segoe UI", 15.75F);
            tbres.Location = new Point(29, 114);
            tbres.Margin = new Padding(5, 6, 5, 6);
            tbres.Name = "tbres";
            tbres.Size = new Size(356, 35);
            tbres.TabIndex = 5;
            tbres.TextChanged += textBox3_TextChanged;
            // 
            // btclear
            // 
            btclear.Location = new Point(255, 185);
            btclear.Name = "btclear";
            btclear.Size = new Size(113, 46);
            btclear.TabIndex = 6;
            btclear.Text = "Очистить";
            btclear.UseVisualStyleBackColor = true;
            btclear.Click += btclear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 250);
            Controls.Add(btclear);
            Controls.Add(tbres);
            Controls.Add(tbsecond);
            Controls.Add(tbfirst);
            Controls.Add(bt);
            Controls.Add(cbsub);
            Controls.Add(cbsum);
            Font = new Font("Segoe UI", 15.75F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbsum;
        private CheckBox cbsub;
        private Button bt;
        private TextBox tbfirst;
        private TextBox tbsecond;
        private TextBox tbres;
        private Button btclear;
    }
}
