using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_2_20_VolokitinVK
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        abstract class Complect<T>
        {
            public int cost;
            public int yofrel;
            public T articul;
            public Complect(int cost, int yofrel, T articul)
            {
                this.cost = cost;
                this.yofrel = yofrel;
                this.articul = articul;
            }

            public virtual string Display()
            {
                return $"Цена: {cost}p \n Год выпсука: {yofrel}p \n Артикул: {articul}";
            }
        }

        class HDD<T> : Complect<T>
        {
            int speed;
            string inter;
            int volume;

            public HDD(int cost, int yofrel, T articul, int speed, string inter, int volume) : base(cost, yofrel, articul)
            {
                speed = speed;

            }

            public override string Display()
            {
                return $"Цена: {cost}p \n Год выпсука: {yofrel}p \n Артикул: {articul} \n Количество оборотов: {speed} \n Интерфейс: {inter} \n Объём: {volume}";
            }

        }

        class VidCard<T> : Complect<T>
        {
            int freqofgpu;
            int manud;
            int memory;

            public VidCard(int cost, int yofrel, T articul, int freqofgpu, string manud, int memory) : base(cost, yofrel, articul)
            {
                freqofgpu = freqofgpu;

            }

            public override string Display()
            {
                return $"Цена: {cost}p \n Год выпсука: {yofrel}г \n Артикул: {articul} \n Частота: {freqofgpu} \n Производитель: {manud} \n Объем памяти: {memory}";
            }
        }

        HDD<int> hdd;
        VidCard<int> vd;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cost = Convert.ToInt32(textBox1.Text);
                int yofrel = Convert.ToInt32(textBox2.Text);
                int speed = Convert.ToInt32(textBox3.Text);
                string inter = textBox4.Text;
                int volume = Convert.ToInt32(textBox5.Text);
                int articul = Convert.ToInt32(textBox6.Text);
                hdd = new HDD<int>(cost, yofrel, articul, speed, inter, volume);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                listBox1.Items.Add(hdd.Display());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int cost = Convert.ToInt32(textBox1.Text);
                int yofrel = Convert.ToInt32(textBox2.Text);
                int freqofgpu = Convert.ToInt32(textBox7.Text);
                string manud = textBox8.Text;
                int memory = Convert.ToInt32(textBox9.Text);
                int articul = Convert.ToInt32(textBox6.Text);
                hdd = new HDD<int>(cost, yofrel, articul, freqofgpu, manud, memory);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                listBox1.Items.Add(vd.Display());
            }
        }
    }
}
