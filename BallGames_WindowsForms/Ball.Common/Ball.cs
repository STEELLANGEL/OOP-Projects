using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace BallCommon
{
    public class Ball
    {
        protected Form form;
        protected Timer timer;

        protected float centerX;
        protected float centerY;
        protected float vx = 2;
        protected float vy = 2;
        protected int radius = 25;
        protected string Color;
        protected Brush brush;
        protected bool isCollides;
        protected int wheightBoost = 6;
        protected float frictionForce = 1.9f;

        protected static Random random = new Random();

        public Ball(Form form)
        {
            this.form = form;

            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }

        public Brush GetBrush()
        {
            return brush;
        }

        public void Timer_Tick(object sender, System.EventArgs e)
        {
            Move();
        }
    
        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public bool IsMovuble()
        {
            return timer.Enabled;
        }

        public bool IsStop()
        {
            return timer.Enabled = false;
        }

        public virtual void SlowedSpeed()
        {
            timer.Interval = 100;
        }

        public virtual void ResetSpeed()
        {
            timer.Interval = 10;
        }

        public void Show()
        {
            var graphics = form.CreateGraphics();

            var rectangle = new RectangleF(centerX - radius, centerY - radius, 2 * radius, 2 * radius);

            graphics.FillEllipse(brush, rectangle);
        }

        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
        }

        public void Clear()
        {
            var graphics = form.CreateGraphics();

            var rectangle = new RectangleF(centerX - radius, centerY - radius, 2 * radius, 2 * radius);

            graphics.FillEllipse(Brushes.White, rectangle);
        }

        protected void Move()
        {
            Clear();
            Go();
            Show();
        }

        public int LeftSide()
        {
            return radius;
        }

        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }
        public int TopSide()
        {
            return radius;
        }
        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }

        public bool PostedOnForm()
        {
            return centerX >= LeftSide() && centerX <= RightSide() && centerY >= TopSide() && centerY <= DownSide();
        }

        public bool IsCollides(int pointX, int pointY)
        {
            var dx = pointX - centerX;
            var dy = pointY - centerY;

            return dx * dx + dy * dy <= radius * radius;
        }

        public bool LeftOfCenter()
        {
            return centerX + radius < form.ClientSize.Width / 2;
        }

        public bool RightOfCenter()
        {
            return centerX - radius > form.ClientSize.Width / 2;
        }

        public bool Intersect(Ball other)
        {
            var dx = centerX - other.centerX;
            var dy = centerY - other.centerY;
            return dx * dx + dy * dy <= (radius + other.radius) * (radius + other.radius);
        }

        public bool IsDownSide()
        {
            return centerY >= DownSide();
        }
        public void SetVelocity(int x, int y)
        {
            vx = (x - centerX) / 20;
            vy = (y - centerY) / 12;
        }

    }
}
