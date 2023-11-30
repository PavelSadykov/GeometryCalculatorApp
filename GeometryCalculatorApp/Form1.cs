using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary3;

namespace GeometryCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(sideLengthTextBox.Text, out double sideLength) &&
                double.TryParse(lengthTextBox.Text, out double length) &&
                double.TryParse(widthTextBox.Text, out double width) &&
                double.TryParse(baseLengthTextBox.Text, out double baseLength) &&
                double.TryParse(heightTextBox.Text, out double height))
            {
                double squareArea = GeometryCalculator.CalculateSquareArea(sideLength);
                double rectangleArea = GeometryCalculator.CalculateRectangleArea(length, width);
                double triangleArea = GeometryCalculator.CalculateTriangleeArea(baseLength, height);
               
                squareAreaLabele.Text = $"Площадь квадрата: {squareArea}";
                rectangleAreaLabel.Text = $"Площадь прямоугольника: {rectangleArea}";
                triangleAreaLabel.Text = $"Площадь треугольника: {triangleArea}";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения для длин сторон.");
            }
        }
    }
}
