namespace TranslationWinForm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.withComboBox = new System.Windows.Forms.ComboBox();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.withTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // withComboBox
            // 
            this.withComboBox.FormattingEnabled = true;
            this.withComboBox.Location = new System.Drawing.Point(147, 65);
            this.withComboBox.Name = "withComboBox";
            this.withComboBox.Size = new System.Drawing.Size(121, 24);
            this.withComboBox.TabIndex = 0;
            // 
            // toComboBox
            // 
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Location = new System.Drawing.Point(303, 65);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(121, 24);
            this.toComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Translate from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(274, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "to";
            // 
            // withTextBox
            // 
            this.withTextBox.Location = new System.Drawing.Point(24, 125);
            this.withTextBox.Multiline = true;
            this.withTextBox.Name = "withTextBox";
            this.withTextBox.Size = new System.Drawing.Size(192, 292);
            this.withTextBox.TabIndex = 4;
            this.withTextBox.TextChanged += new System.EventHandler(this.withTextBox_TextChanged);
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(249, 125);
            this.toTextBox.Multiline = true;
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(192, 292);
            this.toTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(84, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Google Translate";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 445);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.withTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toComboBox);
            this.Controls.Add(this.withComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Translation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox withComboBox;
        private System.Windows.Forms.ComboBox toComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox withTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label label3;
    }
}

