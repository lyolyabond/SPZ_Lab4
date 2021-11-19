namespace SPZ_Lab4
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
            this.write_button = new System.Windows.Forms.Button();
            this.writeOutput_button = new System.Windows.Forms.Button();
            this.readOutput_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // write_button
            // 
            this.write_button.BackColor = System.Drawing.Color.Pink;
            this.write_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.write_button.Location = new System.Drawing.Point(51, 93);
            this.write_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.write_button.Name = "write_button";
            this.write_button.Size = new System.Drawing.Size(154, 82);
            this.write_button.TabIndex = 0;
            this.write_button.Text = "Выбрать файл для записи";
            this.write_button.UseVisualStyleBackColor = false;
            this.write_button.Click += new System.EventHandler(this.write_button_Click);
            // 
            // writeOutput_button
            // 
            this.writeOutput_button.BackColor = System.Drawing.Color.LightGreen;
            this.writeOutput_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writeOutput_button.Location = new System.Drawing.Point(400, 93);
            this.writeOutput_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.writeOutput_button.Name = "writeOutput_button";
            this.writeOutput_button.Size = new System.Drawing.Size(172, 82);
            this.writeOutput_button.TabIndex = 2;
            this.writeOutput_button.Text = "Выбрать файл для сохранения результата";
            this.writeOutput_button.UseVisualStyleBackColor = false;
            this.writeOutput_button.Click += new System.EventHandler(this.writeOutput_button_Click);
            // 
            // readOutput_button
            // 
            this.readOutput_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.readOutput_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readOutput_button.Location = new System.Drawing.Point(787, 93);
            this.readOutput_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.readOutput_button.Name = "readOutput_button";
            this.readOutput_button.Size = new System.Drawing.Size(149, 82);
            this.readOutput_button.TabIndex = 3;
            this.readOutput_button.Text = "Прочитать результат";
            this.readOutput_button.UseVisualStyleBackColor = false;
            this.readOutput_button.Click += new System.EventHandler(this.readOutput_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите исходный файл (.txt):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(378, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите файл (.out) \r\nдля результата вычислений:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(759, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "Прочитать содержимое \r\nрезультирующего файла:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1044, 250);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readOutput_button);
            this.Controls.Add(this.writeOutput_button);
            this.Controls.Add(this.write_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button write_button;
        private System.Windows.Forms.Button writeOutput_button;
        private System.Windows.Forms.Button readOutput_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

