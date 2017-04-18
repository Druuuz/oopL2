using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            picture.Image = new Bitmap(picture.Width, picture.Height);
            Graphics graph = Graphics.FromImage(picture.Image);

            Painter DrawMyDot = new PainterDot(this, button1, graph);
            Painter DrawMyCircle = new PainterCircle(this, button2, graph);
            Painter DrawMyEllipse = new PainterEllipse(this, button3, graph);
            Painter DrawMySquare = new PainterSquare(this, button4, graph);
            Painter DrawMyRectangle = new PainterRectangle(this, button5, graph);
            Painter DrawMyLine = new PainterLine(this, button6, graph);


        }

        
        
        
    }
}
