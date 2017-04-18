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
    class PainterLine : Painter
    {
        public Form1 frm;
        public Button btn;
        public Graphics graph;


        public PainterLine(Form1 frm, Button btn, Graphics graph)
        {
            this.frm = frm;
            this.btn = btn;
            this.graph = graph;
            btn.Click += new EventHandler(button_Click);
        }
        protected override void Draw()
        {
            Line line = new Line();
            graph.DrawLine(new Pen(Color.Yellow), line.point1.X = Convert.ToInt32(frm.textBox17.Text), line.point1.Y = Convert.ToInt32(frm.textBox18.Text), line.point2.X = Convert.ToInt32(frm.textBox19.Text), line.point2.Y = Convert.ToInt32(frm.textBox20.Text));
            frm.picture.Refresh();

        }

    }
}
