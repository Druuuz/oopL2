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
    class PainterEllipse : Painter
    {
        public Form1 frm;
        public Button btn;
        public Graphics graph;



        public PainterEllipse(Form1 frm, Button btn, Graphics graph)
        {
            this.frm = frm;
            this.btn = btn;
            this.graph = graph;
            btn.Click += new EventHandler(button_Click);
        }
        protected override void Draw()
        {
            Ellipse ell = new Ellipse();
            graph.DrawEllipse(new Pen(Color.Black), ell.point1.X = Convert.ToInt32(frm.textBox6.Text), ell.point1.Y = Convert.ToInt32(frm.textBox7.Text), ell.width = Convert.ToInt32(frm.textBox8.Text), ell.height = Convert.ToInt32(frm.textBox9.Text));

            frm.picture.Refresh();

        }
    }
}
