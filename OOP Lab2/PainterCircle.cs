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
    class PainterCircle : Painter
    {
        public Form1 frm;
        public Button btn;
        public Graphics graph;

        public PainterCircle(Form1 frm, Button btn, Graphics graph)
        {
            this.frm = frm;
            this.btn = btn;
            this.graph = graph;
            btn.Click += new EventHandler(button_Click);
        }
        protected override void Draw()
        {
            Circle circle = new Circle();
            graph.DrawEllipse(new Pen(Color.Red), circle.point1.X = Convert.ToInt32(frm.textBox3.Text), circle.point1.Y = Convert.ToInt32(frm.textBox4.Text), circle.radius = Convert.ToInt32(frm.textBox5.Text), circle.radius);
            frm.picture.Refresh();


        }


    }
}
