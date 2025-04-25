using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace N16__YP__Task_3_17._04._2025
{
    public partial class Form1 : Form
    {
        private float x = 0; // Текущая позиция по оси X
        private float y = 0; // Текущая позиция по оси Y (определяется через синус)
        private const int RADIUS = 20; // Радиус окружности
        private const int SPEED = 5; // Скорость движения по оси X

        public Form1()
        {
            InitializeComponent();
            Timer timer = new Timer { Interval = 50 }; // Создаем таймер
            timer.Tick += UpdateCirclePosition; // Обработчик события Tick
            timer.Start(); // Запускаем таймер
        }

        private void UpdateCirclePosition(object sender, EventArgs e)
        {
            x += SPEED; // Увеличиваем позицию по оси X
            y = (float)(ClientSize.Height / 2 + Math.Sin(x / 50) * (ClientSize.Height / 4)); // Синусоида
            if (x > ClientSize.Width + RADIUS) x = -RADIUS; // Циклическое перемещение
            Invalidate(); // Перерисовываем форму
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (SolidBrush brush = new SolidBrush(Color.Red))
            {
                e.Graphics.FillEllipse(brush, x - RADIUS, y - RADIUS, 2 * RADIUS, 2 * RADIUS); // Рисуем окружность
            }
        }
    }
}