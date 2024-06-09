using System;

namespace roots_of_quadratic_equation
{
    public partial class Form1 : Form
    {
        //глобальные переменные
        bool canCalc; // возможность произвести расчет
        string a, b, c; // значения коэфф-тов в виде строки
        double a_num, b_num, c_num; // значения коэфф-тов в виде double
        double d; //дискриминант
        double x1, x2; //корни

        public Form1()
        {
            InitializeComponent();
        }

        void PrintQuadraticEquation() // вывод отформатированного уравнения
        {
            canCalc = true; // инициализируем булевую переменную
            a = textBoxA.Text; // считываем текст из textBox в виде строк
            b = textBoxB.Text;
            c = textBoxC.Text;
            try
            {
                a_num = Convert.ToDouble(a); // пробуем конвертировать текст в число
                b_num = Convert.ToDouble(b);
                c_num = Convert.ToDouble(c);
                if (a_num == 0) // если коэфф a == 0
                {
                    canCalc = false; // расчет не возможен
                    PrintErrors("'a' не может быть равно 0"); // вывод информации в поле label5
                }
            }
            catch (Exception) // если не получилось сконвертировать текст в число
            {
                canCalc = false; // расчет не возможен
                PrintErrors("Не верный формат"); // вывод ошибки в поле label5
            }


            if (canCalc) // если расчет возможен
            {
                label5.ForeColor = Color.Black; //цвет текста меняем на черный
                label5.Text = $"({a})x² + ({b})x + ({c}) = 0"; //вывод уравнения с интерполяцией
            }
        }

        void PrintErrors(string message) // вывод ошибки в поле label5
        {
            label5.ForeColor = Color.Red; // цвет текста меняем на красный
            label5.Text = message; // текст ошибки
        }

        void CalculateDiscriminant() // считаем дискриминант
        {
            d = b_num * b_num - (4 * a_num * c_num);
            labelD.Text = $"D = {Convert.ToString(d)}"; // выводим дискриминант
            if (!canCalc) labelD.Text = "D = "; // если вычисление не возможно
        }

        void CalculateRoots() // считаем корни
        {
            x1 = (-1 * b_num + Math.Sqrt(d)) / (2 * a_num);
            x2 = (-1 * b_num - Math.Sqrt(d)) / (2 * a_num);
            labelX1.Text = $"x₁ = {Convert.ToString(x1)}";
            labelX2.Text = $"x₂ = {Convert.ToString(x2)}";

            if (!canCalc) // если вычисление не возможно
            {
                labelX1.Text = "x₁ = ";
                labelX2.Text = "x₂ = ";
            }
        }

        //Событие Load наступает после загрузки формы
        private void Form1_Load(object sender, EventArgs e)
        {
            PrintQuadraticEquation();
            CalculateDiscriminant();
            CalculateRoots();
        }

        //Событие TextChanged наступает после изменения текста
        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            PrintQuadraticEquation(); // вывод квадратного уравнения
            CalculateDiscriminant();  // вычисление дискриминанта
            CalculateRoots();         // вычисление корней 
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            PrintQuadraticEquation();
            CalculateDiscriminant();
            CalculateRoots();
        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {
            PrintQuadraticEquation();
            CalculateDiscriminant();
            CalculateRoots();
        }

    }
}
