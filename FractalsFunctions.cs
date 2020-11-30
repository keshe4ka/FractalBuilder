using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalBuilder
{
    public partial class MainForm
    {
        private Graphics g;
        private static readonly Random rnd = new Random();

        /// <summary>
        /// Рисует фрактальное дерево
        /// </summary>
        /// <param name="x">координата x</param>
        /// <param name="y">координата y</param>
        /// <param name="length">длина ветви</param>
        /// <param name="angle">угол поворота дерева</param>
        private void DrawFractalTree(int x, int y, int length, double angle)
        {
            double x1, y1;
            x1 = x + length * Math.Sin(angle * Math.PI * 2 / 360.0);
            y1 = y + length * Math.Cos(angle * Math.PI * 2 / 360.0);
            if (multicoloredCheckBox.Checked)
            {
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                g.DrawLine(new Pen(randomColor, length / 25), x, pictureBox.Height - y, (int)x1, pictureBox.Height - (int)y1);
            }
            else
            {
                g.DrawLine(new Pen(Color.Black, length / 25), x, pictureBox.Height - y, (int)x1, pictureBox.Height - (int)y1);
            }
            if (length > 20) //перестаем рисовать, если длина ветви меньше 21px
            {
                if (assymetricalCheckBox.Checked)
                {
                    DrawFractalTree((int)x1, (int)y1, (int)(length / ((double)trackLengthDivider.Value / 100)), angle + rnd.Next(10, 88));
                    DrawFractalTree((int)x1, (int)y1, (int)(length / ((double)trackLengthDivider.Value / 100)), angle - rnd.Next(10, 88));
                    DrawFractalTree((int)x1, (int)y1, (int)(length / ((double)trackLengthDivider.Value / 100)), angle + rnd.Next(10, 88));
                    DrawFractalTree((int)x1, (int)y1, (int)(length / ((double)trackLengthDivider.Value / 100)), angle - rnd.Next(10, 88));

                }
                else
                {
                    DrawFractalTree((int)x1, (int)y1, (int)(length / ((double)trackLengthDivider.Value / 100)), angle + 35);
                    DrawFractalTree((int)x1, (int)y1, (int)(length / ((double)trackLengthDivider.Value / 100)), angle - 35);
                    DrawFractalTree((int)x1, (int)y1, (int)(length / ((double)trackLengthDivider.Value / 100)), angle + 15);
                    DrawFractalTree((int)x1, (int)y1, (int)(length / ((double)trackLengthDivider.Value / 100)), angle - 15);
                }
            }
        }

        /// <summary>
        /// Рисует папоротник Барнсли
        /// </summary>
        /// <param name="x">координата x</param>
        /// <param name="y">координата у</param>
        /// <param name="length">длина ветви</param>
        /// <param name="angle">угол наклона</param>
        private void DrawBarnsleysFern(int x, int y, double length, double angle)
        {
            if (multicoloredCheckBox.Checked)
            {
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                g.DrawLine(new Pen(randomColor, (float)length / 25), x, y, (int)Math.Round(x + length * Math.Cos(angle)), (int)Math.Round(y - length * Math.Sin(angle)));
            }
            else
            {
                g.DrawLine(new Pen(Color.Black, (float)length / 25), x, y, (int)Math.Round(x + length * Math.Cos(angle)), (int)Math.Round(y - length * Math.Sin(angle)));
            }
            if (length > (double)trackLengthDivider.Value / 100)
            {
                x = (int)Math.Round(x + length * Math.Cos(angle));
                y = (int)Math.Round(y - length * Math.Sin(angle));
                DrawBarnsleysFern(x, y, length * 0.4, angle - trackAngle.Value * Math.PI / 30);
                DrawBarnsleysFern(x, y, length * 0.4, angle + trackAngle.Value * Math.PI / 30);
                DrawBarnsleysFern(x, y, length * 0.7, angle + Math.PI / 30);
            }
        }

        /// <summary>
        /// Рисует фрактал Квазиклевера
        /// </summary>
        /// <param name="x0">x координата центра круга</param>
        /// <param name="y0">y координата центра круга</param>
        /// <param name="r">радиус круга</param>
        /// <param name="dir">индекс, определяющий положение родителя</param>
        /// <param name="iteration">количество итераций</param>
        private void DrawQuasiCloverFractal(int x0, int y0, int r, int dir, int iteration)
        {
            if (multicoloredCheckBox.Checked)
            {
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                g.FillEllipse(new SolidBrush(randomColor), x0 - r, y0 - r, 2 * r, 2 * r);
            }
            else
            {
                g.FillEllipse(new SolidBrush(Color.Black), x0 - r, y0 - r, 2 * r, 2 * r);
            }
            if (iteration > 0)
            {
                int[] x = new int[4];
                int[] y = new int[4];
                int d = 3 * r / 2;
                x[0] = x0 - d;
                y[0] = y0;
                x[1] = x0;
                y[1] = y0 - d;
                x[2] = x0 + d;
                y[2] = y0;
                x[3] = x0;
                y[3] = y0 + d;

                for (int i = 0; i < 4; i++)
                {
                    if (i - dir == 2 || i - dir == -2)
                        continue;
                    DrawQuasiCloverFractal(x[i], y[i], r / 2, i, iteration - 1);
                }
            }
        }
    }
}
