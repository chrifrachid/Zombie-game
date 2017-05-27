#define my_debug

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ZombieShooter : Form
    {
#if my_debug
        int _cursX = 0;
        int _cursY = 0;
#endif
        public ZombieShooter()
        {
            InitializeComponent();
        }

        private void TimerGameLoop_Tick(object sender, EventArgs e)
        {

        }

        //Overriding OnPaint function
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics gs = e.Graphics;
#if my_debug
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis;
            Font _font = new System.Drawing.Font("Stencil", 12, FontStyle.Regular);
            TextRenderer.DrawText(e.Graphics, "X=" + _cursX.ToString() + ":" + "Y=" + _cursY.ToString(), _font,
                new Rectangle(1,1,120,30), SystemColors.ControlLight, flags);
#endif
            base.OnPaint(e);
        }

        private void ZombieShooter_MouseMove(object sender, MouseEventArgs e)
        {
#if my_debug
            _cursX = e.X;
            _cursY = e.Y;
#endif
            this.Refresh();
        }
    }
}
