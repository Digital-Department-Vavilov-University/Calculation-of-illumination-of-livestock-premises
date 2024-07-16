using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {


        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtNumLights = new System.Windows.Forms.TextBox();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина помещения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ширина помещения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Высота помещения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество светильников:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Мощность одного светильника:";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(191, 10);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 1;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(191, 36);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(191, 62);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 5;
            // 
            // txtNumLights
            // 
            this.txtNumLights.Location = new System.Drawing.Point(191, 88);
            this.txtNumLights.Name = "txtNumLights";
            this.txtNumLights.Size = new System.Drawing.Size(100, 20);
            this.txtNumLights.TabIndex = 7;
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(191, 114);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(100, 20);
            this.txtPower.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(36, 140);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(234, 23);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Рассчитать освещенность";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(33, 175);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 13);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Результат:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(368, 308);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPower);
            this.Controls.Add(this.txtNumLights);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Расчет освещенности";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

            private void btnCalculate_Click(object sender, EventArgs e)
            {
                try
                {
                    double length = double.Parse(txtLength.Text);
                    double width = double.Parse(txtWidth.Text);
                    double height = double.Parse(txtHeight.Text);
                    int numLights = int.Parse(txtNumLights.Text);
                    double power = double.Parse(txtPower.Text);

                    // Площадь пола помещения
                    double area = length * width;

                    // Суммарная мощность всех светильников
                    double totalPower = numLights * power;

                    // Освещенность помещения (примерная оценка)
                    double illuminance = totalPower / area;

                    lblResult.Text = $"Освещенность: {illuminance} люкс";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка ввода данных: {ex.Message}");
                }
            }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtLength;
        private TextBox txtWidth;
        private TextBox txtHeight;
        private TextBox txtNumLights;
        private TextBox txtPower;
        private Button btnCalculate;
        private Label lblResult;
    }
}
