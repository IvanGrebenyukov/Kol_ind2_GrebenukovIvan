
namespace Practice15_Grebenukov
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
            this.comboBoxOperations = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxComplexNumber = new System.Windows.Forms.ListBox();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.textBoxNumber1 = new System.Windows.Forms.TextBox();
            this.textBoxNumber2 = new System.Windows.Forms.TextBox();
            this.OperationsButton = new System.Windows.Forms.Button();
            this.OperationsButtonFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNumber3 = new System.Windows.Forms.TextBox();
            this.textBoxNumber4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxOperations
            // 
            this.comboBoxOperations.FormattingEnabled = true;
            this.comboBoxOperations.Items.AddRange(new object[] {
            "Сложение",
            "Умножение",
            "Вычитание"});
            this.comboBoxOperations.Location = new System.Drawing.Point(8, 49);
            this.comboBoxOperations.Name = "comboBoxOperations";
            this.comboBoxOperations.Size = new System.Drawing.Size(884, 23);
            this.comboBoxOperations.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите какую операцию хотите првоести над комплексными числами";
            // 
            // listBoxComplexNumber
            // 
            this.listBoxComplexNumber.FormattingEnabled = true;
            this.listBoxComplexNumber.ItemHeight = 15;
            this.listBoxComplexNumber.Location = new System.Drawing.Point(478, 120);
            this.listBoxComplexNumber.Name = "listBoxComplexNumber";
            this.listBoxComplexNumber.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxComplexNumber.Size = new System.Drawing.Size(414, 109);
            this.listBoxComplexNumber.TabIndex = 2;
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Location = new System.Drawing.Point(478, 91);
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(129, 23);
            this.buttonLoadFile.TabIndex = 3;
            this.buttonLoadFile.Text = "Загрузить из файла";
            this.buttonLoadFile.UseVisualStyleBackColor = true;
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // textBoxNumber1
            // 
            this.textBoxNumber1.Location = new System.Drawing.Point(8, 109);
            this.textBoxNumber1.Name = "textBoxNumber1";
            this.textBoxNumber1.Size = new System.Drawing.Size(221, 23);
            this.textBoxNumber1.TabIndex = 4;
            // 
            // textBoxNumber2
            // 
            this.textBoxNumber2.Location = new System.Drawing.Point(246, 109);
            this.textBoxNumber2.Name = "textBoxNumber2";
            this.textBoxNumber2.Size = new System.Drawing.Size(221, 23);
            this.textBoxNumber2.TabIndex = 5;
            // 
            // OperationsButton
            // 
            this.OperationsButton.Location = new System.Drawing.Point(188, 201);
            this.OperationsButton.Name = "OperationsButton";
            this.OperationsButton.Size = new System.Drawing.Size(107, 23);
            this.OperationsButton.TabIndex = 6;
            this.OperationsButton.Text = "Рассчитать";
            this.OperationsButton.UseVisualStyleBackColor = true;
            this.OperationsButton.Click += new System.EventHandler(this.OperationsButton_Click);
            // 
            // OperationsButtonFile
            // 
            this.OperationsButtonFile.Location = new System.Drawing.Point(593, 235);
            this.OperationsButtonFile.Name = "OperationsButtonFile";
            this.OperationsButtonFile.Size = new System.Drawing.Size(167, 23);
            this.OperationsButtonFile.TabIndex = 7;
            this.OperationsButtonFile.Text = "Рассчитать из файла";
            this.OperationsButtonFile.UseVisualStyleBackColor = true;
            this.OperationsButtonFile.Click += new System.EventHandler(this.OperationsButtonFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите действительную часть числа 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Введите мнимую часть числа 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Введите действительную часть числа 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Введите мнимую часть числа 2";
            // 
            // textBoxNumber3
            // 
            this.textBoxNumber3.Location = new System.Drawing.Point(8, 172);
            this.textBoxNumber3.Name = "textBoxNumber3";
            this.textBoxNumber3.Size = new System.Drawing.Size(221, 23);
            this.textBoxNumber3.TabIndex = 12;
            // 
            // textBoxNumber4
            // 
            this.textBoxNumber4.Location = new System.Drawing.Point(246, 172);
            this.textBoxNumber4.Name = "textBoxNumber4";
            this.textBoxNumber4.Size = new System.Drawing.Size(221, 23);
            this.textBoxNumber4.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.textBoxNumber4);
            this.Controls.Add(this.textBoxNumber3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OperationsButtonFile);
            this.Controls.Add(this.OperationsButton);
            this.Controls.Add(this.textBoxNumber2);
            this.Controls.Add(this.textBoxNumber1);
            this.Controls.Add(this.buttonLoadFile);
            this.Controls.Add(this.listBoxComplexNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxOperations);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOperations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxComplexNumber;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.TextBox textBoxNumber1;
        private System.Windows.Forms.TextBox textBoxNumber2;
        private System.Windows.Forms.Button OperationsButton;
        private System.Windows.Forms.Button OperationsButtonFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNumber3;
        private System.Windows.Forms.TextBox textBoxNumber4;
    }
}

