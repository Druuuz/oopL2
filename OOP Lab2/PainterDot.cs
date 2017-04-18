using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Lab2
{
    class PainterDot : Painter
    {
        public Form1 frm;
        public Button btn;
        public Graphics graph;



        public PainterDot(Form1 frm, Button btn, Graphics graph)
        {
            this.frm = frm;
            this.btn = btn;
            this.graph = graph;
            btn.Click += new EventHandler(button_Click);
        }
        protected override void Draw()
        {
            Dot dot = new Dot();
            graph.DrawLine(new Pen(Color.Blue), dot.point1.X = Convert.ToInt32(frm.textBox1.Text), dot.point1.Y = Convert.ToInt32(frm.textBox2.Text), dot.point1.X + 1, dot.point1.Y + 1);
            frm.picture.Refresh();

        }

    }
}
