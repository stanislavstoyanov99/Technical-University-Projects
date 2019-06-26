using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class MyFirstClass
    {
        private int SizeA { get; set; }
        private int SizeB { get; set; }

        private void CalculateArea(int sizeA, int sizeB)
        {
            int area = sizeA * sizeB;
            MessageBox.Show($"Лицето е: {area.ToString()}");
        }

        public void CalculatePerimer(double sizeA, double sizeB)
        {
            double perimeter = (sizeA * sizeB) / 2;
            MessageBox.Show($"Периметърът е: {perimeter.ToString()}");
        }
    }

    public class Dog
    {
        // TODO
    }

    internal class Animal
    {
        // TODO
    }
}
