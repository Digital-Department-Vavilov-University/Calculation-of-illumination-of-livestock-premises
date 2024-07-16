# Calculation-of-illumination-of-livestock-premises
Расчет освещенности животноводческих помещений
Приложение предназначено для вычисления освещенности внутри животноводческих помещений на основе введенных пользователем данных.

# Ввод данных
Пользователь должен ввести следующие данные:

- Длина помещения (метры): длина помещения, где планируется установка светильников.
- Ширина помещения (метры): ширина помещения.
- Высота помещения (метры): высота помещения.
- Количество светильников: количество светильников, установленных в помещении.
- Мощность одного светильника (ватт): мощность каждого светильника в ваттах.

# Логика расчета и код программы
Программа выполняет расчет освещенности следующим образом:

Площадь пола помещения: вычисляется как произведение длины и ширины помещения.
Суммарная мощность светильников: вычисляется как произведение количества светильников и мощности одного светильника.
Освещенность помещения: суммарная мощность светильников делится на площадь пола помещения, полученное значение отображается в люксах.

Программа включает базовую обработку ошибок. Если пользователь введет некорректные данные (например, буквы вместо чисел), будет отображено сообщение об ошибке с указанием причины.

'''

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
'''

# Вывод данных

После нажатия на кнопку "Рассчитать освещенность", программа выполняет расчет и отображает результат в метке "Результат".

![image](https://github.com/user-attachments/assets/28b704b1-6386-405e-a804-be92cf3832bb)

# Стек технологий
- C++
- WinForm
- .Net Framework
- CLI




