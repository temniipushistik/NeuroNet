namespace NeuronsPet
{
    partial class NeiroGUI
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
            this.vodkaCheckBox = new System.Windows.Forms.CheckBox();
            this.RainCheckBox = new System.Windows.Forms.CheckBox();
            this.bestFriendCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vodkaCheckBox
            // 
            this.vodkaCheckBox.AutoSize = true;
            this.vodkaCheckBox.Location = new System.Drawing.Point(29, 40);
            this.vodkaCheckBox.Name = "vodkaCheckBox";
            this.vodkaCheckBox.Size = new System.Drawing.Size(70, 21);
            this.vodkaCheckBox.TabIndex = 0;
            this.vodkaCheckBox.Text = "Водка";
            this.vodkaCheckBox.UseVisualStyleBackColor = true;
            this.vodkaCheckBox.CheckedChanged += new System.EventHandler(this.VodkaCheckBox_CheckedChanged);
            // 
            // RainCheckBox
            // 
            this.RainCheckBox.AutoSize = true;
            this.RainCheckBox.Location = new System.Drawing.Point(29, 95);
            this.RainCheckBox.Name = "RainCheckBox";
            this.RainCheckBox.Size = new System.Drawing.Size(73, 21);
            this.RainCheckBox.TabIndex = 1;
            this.RainCheckBox.Text = "Дождь";
            this.RainCheckBox.UseVisualStyleBackColor = true;
            this.RainCheckBox.CheckedChanged += new System.EventHandler(this.RainCheckBox_CheckedChanged);
            // 
            // bestFriendCheckBox
            // 
            this.bestFriendCheckBox.AutoSize = true;
            this.bestFriendCheckBox.Location = new System.Drawing.Point(29, 149);
            this.bestFriendCheckBox.Name = "bestFriendCheckBox";
            this.bestFriendCheckBox.Size = new System.Drawing.Size(106, 21);
            this.bestFriendCheckBox.TabIndex = 1;
            this.bestFriendCheckBox.Text = "Луший друг";
            this.bestFriendCheckBox.UseVisualStyleBackColor = true;
            this.bestFriendCheckBox.CheckedChanged += new System.EventHandler(this.BestFriendCheckBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Идти на вечеринку?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(528, 83);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(229, 17);
            this.result.TabIndex = 3;
            this.result.Text = "Выбирай условия и тыкай кнопку";
            // 
            // NeiroGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 210);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bestFriendCheckBox);
            this.Controls.Add(this.RainCheckBox);
            this.Controls.Add(this.vodkaCheckBox);
            this.Name = "NeiroGUI";
            this.Text = "NeiroCulc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox vodkaCheckBox;
        private System.Windows.Forms.CheckBox RainCheckBox;
        private System.Windows.Forms.CheckBox bestFriendCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label result;
    }
}

