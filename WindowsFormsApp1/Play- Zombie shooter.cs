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

            base.OnPaint(e);
        }
    }
}
