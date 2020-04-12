using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sppr
{
    public partial class Form1 : Form
    {

        Method method;
        public Form1()
        {
            InitializeComponent();
            float ca = 2;
            Func<float, float> function = x => x * ca;
            method = new Brute(function, 0.0f, 0.5f, 10);
        }

    }
}
