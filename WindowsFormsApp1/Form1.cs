using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //-------------------Вмикач і вимикач------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кондиціонер увімкнено");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кондиціонер вимкнено");
        }

        //-------------------РЕЖИМ------------------------
        int mode = 0;
        private void modeUbdate()
        {
           if (mode == 0)
           {
                textBox1.Text = "Охолодження";
           }
           else if(mode == 1)
           {
                textBox1.Text = "Нагрів";
           }
           else if(mode == 2) 
           {
                textBox1.Text = "Провітрювання";
           }
        }
        private void button5_Click(object sender, EventArgs e)
        {
           switch (mode)
           {
                case 0: mode++; break;
                case 1: mode++; break;
                case 2: mode--; break;
           }
           modeUbdate();


        }

        //-------------------ТЕМПЕРАТУРА------------------------
        public int temperature = 16;
        private void temperatureUpdate()
        {
            textBox2.Text = temperature.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(temperature < 28)
            {
                temperature++;
                temperatureUpdate();
            }
            else
            {
                MessageBox.Show("Максимальна температура 28 градусів");
            }
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            if (temperature > 16)
            {
                temperature--;
                temperatureUpdate();
            }
            else
            {
                MessageBox.Show("Мінімальна температура 16 градусів");
            }          
        }

        //-------------------Відкритість жалюзів------------------------

        public int openness = 0;
        private void opennessUpdate()
        {
            textBox3.Text = openness.ToString();
        }
        private void button7_Click(object sender, EventArgs e)
        {
           if (openness < 100 )
           {
                openness++;
                opennessUpdate();
           }
           else
           {
                MessageBox.Show("Жалюзі відкриті на максимум");
           }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(openness > 0 )
            {
                openness--;
                opennessUpdate();
            }
            else
            {
                MessageBox.Show("Жалюзі вже закриті");
            }
        }
    }
}
