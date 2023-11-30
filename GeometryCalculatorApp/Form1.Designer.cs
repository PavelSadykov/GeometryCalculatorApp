namespace GeometryCalculatorApp
{
    partial class Form1
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
            this.sideLengthTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.baseLengthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.squareAreaLabel = new System.Windows.Forms.Label();
            this.rectangleAreaLabel = new System.Windows.Forms.Label();
            this.triangleAreaLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.squareAreaLabele = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sideLengthTextBox
            // 
            this.sideLengthTextBox.Location = new System.Drawing.Point(23, 39);
            this.sideLengthTextBox.Name = "sideLengthTextBox";
            this.sideLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.sideLengthTextBox.TabIndex = 0;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(243, 39);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTextBox.TabIndex = 1;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(243, 90);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 2;
            // 
            // baseLengthTextBox
            // 
            this.baseLengthTextBox.Location = new System.Drawing.Point(555, 39);
            this.baseLengthTextBox.Name = "baseLengthTextBox";
            this.baseLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.baseLengthTextBox.TabIndex = 3;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(555, 90);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 4;
            // 
            // squareAreaLabel
            // 
            this.squareAreaLabel.AutoSize = true;
            this.squareAreaLabel.Location = new System.Drawing.Point(31, 33);
            this.squareAreaLabel.Name = "squareAreaLabel";
            this.squareAreaLabel.Size = new System.Drawing.Size(0, 13);
            this.squareAreaLabel.TabIndex = 5;
            // 
            // rectangleAreaLabel
            // 
            this.rectangleAreaLabel.AutoSize = true;
            this.rectangleAreaLabel.Location = new System.Drawing.Point(240, 146);
            this.rectangleAreaLabel.Name = "rectangleAreaLabel";
            this.rectangleAreaLabel.Size = new System.Drawing.Size(22, 13);
            this.rectangleAreaLabel.TabIndex = 6;
            this.rectangleAreaLabel.Text = ".....";
            // 
            // triangleAreaLabel
            // 
            this.triangleAreaLabel.AutoSize = true;
            this.triangleAreaLabel.Location = new System.Drawing.Point(552, 146);
            this.triangleAreaLabel.Name = "triangleAreaLabel";
            this.triangleAreaLabel.Size = new System.Drawing.Size(22, 13);
            this.triangleAreaLabel.TabIndex = 7;
            this.triangleAreaLabel.Text = ".....";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(23, 257);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(145, 46);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // squareAreaLabele
            // 
            this.squareAreaLabele.AutoSize = true;
            this.squareAreaLabele.Location = new System.Drawing.Point(20, 146);
            this.squareAreaLabele.Name = "squareAreaLabele";
            this.squareAreaLabele.Size = new System.Drawing.Size(22, 13);
            this.squareAreaLabele.TabIndex = 9;
            this.squareAreaLabele.Text = ".....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "1) Введите длину стороны квадрата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "2) Введите длину  стороны прямоугольника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = " Введите длину  ширину стороны прямоугольника";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "3) Введите основание треугольника";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Введите  высоту треугольника";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.squareAreaLabele);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.triangleAreaLabel);
            this.Controls.Add(this.rectangleAreaLabel);
            this.Controls.Add(this.squareAreaLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.baseLengthTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.sideLengthTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sideLengthTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox baseLengthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label squareAreaLabel;
        private System.Windows.Forms.Label rectangleAreaLabel;
        private System.Windows.Forms.Label triangleAreaLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label squareAreaLabele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

