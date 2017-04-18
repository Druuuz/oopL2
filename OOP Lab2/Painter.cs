using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab2
{
    abstract class Painter
    {
        protected abstract void Draw();

        protected void button_Click(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
