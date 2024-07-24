using System;
using System.Windows.Forms;
using WindowsFormsApp1.src;
using static WindowsFormsApp1.src.Conditioner;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ICond conditioner;

        public Form1()
        {
            InitializeComponent();

            this.conditioner = new Conditioner();

            this.textBox1.Text = conditioner.getMode().ToString();
            this.textBox2.Text = conditioner.getTemperature().ToString();
            this.textBox3.Text = conditioner.getPosition().ToString();  
        }

        //-------------------Вмикач і вимикач------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            if (conditioner.power())
            {
                this.button2.ForeColor = System.Drawing.Color.Green;
                this.button2.Text = "ON";
            }
            else
            {
                this.button2.ForeColor = System.Drawing.Color.Red;
                this.button2.Text = "OFF";
            }
        }

        //-------------------РЕЖИМ------------------------
        private void button5_Click(object sender, EventArgs e)
        {
            CondMode mode = this.conditioner.changeMode();

            textBox1.Text = mode.ToString();
        }

        //-------------------ТЕМПЕРАТУРА------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            

            this.conditioner.increaseT();
            this.textBox2.Text = this.conditioner.getTemperature().ToString();
            //MessageBox.Show("Максимальна температура 28 градусів");
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            this.conditioner.decreaseT();
            this.textBox2.Text = this.conditioner.getTemperature().ToString();
            //MessageBox.Show("Мінімальна температура 16 градусів");
        }

        //-------------------Відкритість жалюзів------------------------
        private void button7_Click(object sender, EventArgs e)
        {
           this.conditioner.openJalousie();
           this.textBox3.Text = this.conditioner.getPosition().ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.conditioner.closeJalousie();
            this.textBox3.Text = this.conditioner.getPosition().ToString();
        }
    }
}
