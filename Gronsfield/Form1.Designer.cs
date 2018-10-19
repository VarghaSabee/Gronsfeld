namespace Gronsfield
{
    partial class Form1
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
            System.Windows.Forms.RadioButton radioen;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioua = new System.Windows.Forms.RadioButton();
            this.KeytextBox = new System.Windows.Forms.TextBox();
            this.MsgTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ModecomboBox = new System.Windows.Forms.ComboBox();
            radioen = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(189, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Алфавіт";
            // 
            // radioen
            // 
            radioen.AutoSize = true;
            radioen.Checked = true;
            radioen.Cursor = System.Windows.Forms.Cursors.Hand;
            radioen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            radioen.Location = new System.Drawing.Point(168, 5);
            radioen.Name = "radioen";
            radioen.Size = new System.Drawing.Size(133, 28);
            radioen.TabIndex = 2;
            radioen.TabStop = true;
            radioen.Text = "английська";
            radioen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            radioen.UseVisualStyleBackColor = true;
            // 
            // radioua
            // 
            this.radioua.AutoSize = true;
            this.radioua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioua.Location = new System.Drawing.Point(319, 5);
            this.radioua.Name = "radioua";
            this.radioua.Size = new System.Drawing.Size(125, 28);
            this.radioua.TabIndex = 3;
            this.radioua.Text = "українська";
            this.radioua.UseVisualStyleBackColor = true;
            // 
            // KeytextBox
            // 
            this.KeytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeytextBox.Location = new System.Drawing.Point(168, 114);
            this.KeytextBox.Name = "KeytextBox";
            this.KeytextBox.Size = new System.Drawing.Size(347, 28);
            this.KeytextBox.TabIndex = 4;
            // 
            // MsgTextBox
            // 
            this.MsgTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MsgTextBox.Location = new System.Drawing.Point(168, 163);
            this.MsgTextBox.Name = "MsgTextBox";
            this.MsgTextBox.Size = new System.Drawing.Size(347, 87);
            this.MsgTextBox.TabIndex = 5;
            this.MsgTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Режим";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ключ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Повідомлення";
            // 
            // ModecomboBox
            // 
            this.ModecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModecomboBox.FormattingEnabled = true;
            this.ModecomboBox.Items.AddRange(new object[] {
            "Шифрувати",
            "Розшифрувати"});
            this.ModecomboBox.Location = new System.Drawing.Point(168, 51);
            this.ModecomboBox.Name = "ModecomboBox";
            this.ModecomboBox.Size = new System.Drawing.Size(232, 30);
            this.ModecomboBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 329);
            this.Controls.Add(this.ModecomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MsgTextBox);
            this.Controls.Add(this.KeytextBox);
            this.Controls.Add(this.radioua);
            this.Controls.Add(radioen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gronsfeld";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioua;
        private System.Windows.Forms.TextBox KeytextBox;
        private System.Windows.Forms.RichTextBox MsgTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ModecomboBox;
    }
}

