using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowfun
{
    public partial class Jump : Form
    {
        public event EventHandler Kamilclick;
        Random rndms = new Random();
        private Vector2 movement;
        public Jump()
        {
            movement = new Vector2(rndms.Next(-10, 10), rndms.Next(-10, 10));
            InitializeComponent();
            
        }
        protected int x, y, dx, dy, sx, sy;
        public Jump(int x, int y)
        {
            this.x = x;
            this.y = y;
            movement = new Vector2(rndms.Next(-10, 10), rndms.Next(-10, 10));
            InitializeComponent();
            
        }
        

        protected virtual void ziut_Click(object sender, EventArgs e)
        {
            Kamilclick?.Invoke(this, EventArgs.Empty);
        }

        private void kabel_Tick(object sender, EventArgs e)
        {
            hopka();
        }


        private void hopka()
        {
            this.x = this.Location.X;
            this.y = this.Location.Y;
            this.dx = this.x + this.Size.Width;
            this.dy = this.y + this.Size.Height;
            this.sx = Screen.FromControl(this).Bounds.Width;
            this.sy = Screen.FromControl(this).Bounds.Height;




            if (this.dx > sx)
            {
                movement.X = -movement.X;

            }
            if (this.dy > sy)
            {
                movement.Y = -movement.Y;

            }
            if (this.x < 0)
            {
                movement.X = -movement.X;

            }
            if (this.y < 0)
            {
                movement.Y = -movement.Y;

            }


            this.SetDesktopLocation(this.x + (int)movement.X, this.y + (int)movement.Y);
        }
    }
}
