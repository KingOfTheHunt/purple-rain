using PurpleRain.Model.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurpleRain
{
    public partial class Form1 : Form
    {
        RainService rainService;
        
        public Form1()
        {
            InitializeComponent();
            rainService = new RainService(this);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            rainService.Start();
            Task t = new Task(new Action(rainService.Update));
            t.Start();
        }
    }
}
