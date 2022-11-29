using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace cancha
{
    public partial class Form1 : Form
    {
        Graphics miDibujo;
        Pen miPluma = new Pen(Color.Fuchsia, 8);
        Brush miPincel = Brushes.Gold;
        int[] posX = new int[100];
        int[] posY = new int[100];
        int[] posXl = new int[100];
        int[] posYl = new int[100];
        int[] tamanoLuna = new int[1];
        int[] dirX = new int[1]; 
        int[] dirY= new int[1];
        int minX, maxX, minY, maxY;
        OpenFileDialog OFD;
        string archivo;
        Image fondito;
        double tiempo, forbita;
        int[] tamano = new int[100];
        int forLabels = 0;
        int planetas, velocidad, cambioDeTam;
        double cambioDeVel;
        
       

        private void button3_Click(object sender, EventArgs e)
        {
            OFD = new OpenFileDialog();
            OFD.ShowDialog();
            archivo = OFD.FileName;
            fondito = Image.FromFile(archivo);
            this.BackgroundImage = fondito;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button4.Visible = false;
            button5.Visible= false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(forLabels == 0)
            {
                label2.Visible = true;
                forLabels = 1;

            } else if(forLabels==1)
            {
                label2.Visible = false;
                forLabels = 0;
            }

            
           

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            button4.Visible = true;
            button5.Visible = true;
            forbita = double.Parse(textBox1.Text);
            planetas = int.Parse(textBox2.Text);
            velocidad = (int)double.Parse(textBox4.Text);
            cambioDeTam = int.Parse(textBox3.Text);


            //Esto es para que se vean todos los planetas
            if (planetas == 1)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;

            }
            if (planetas == 2)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
            }
            if (planetas == 3)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;

            }
            if (planetas == 4)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox6.Visible = true;

            }
            if (planetas == 4)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox6.Visible = true;

            }
            if (planetas == 5)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
            }
            if (planetas == 6)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
            }
            if (planetas == 7)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
            }
            if (planetas == 8)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            tiempo = tiempo + 0.1;
            for (int i = 1; i <= planetas; i++)
            {
                posX[i] = 292 + (int)(250 * Math.Pow(forbita, i) * Math.Cos(tiempo / (Math.Pow(velocidad, i))));
                posY[i] = 268 + (int)(120 * Math.Pow(forbita, i) * Math.Sin(tiempo / (Math.Pow(velocidad, i))));
                tamano[i] = (posY[i] / 10) * (int)Math.Pow(cambioDeTam, i);
            }
            pictureBox2.Location= new Point((posX[1]-(tamano[1]/2)),(posY[1]-tamano[1]/2));
            pictureBox2.Size = new Size(tamano[1], tamano[1]);
            pictureBox3.Location = new Point((posX[2] - (tamano[1] / 2)), (posY[1] - tamano[1] / 2));
            pictureBox3.Size = new Size (tamano[2], tamano[2]);
            pictureBox4.Location = new Point((posX[3] - (tamano[3] / 2)), (posY[3] - tamano[3] / 2));
            pictureBox4.Size = new Size(tamano[3], tamano[3]);
            pictureBox4.BringToFront();
            pictureBox6.Location = new Point((posX[4] - (tamano[4] / 2)), (posY[4] - tamano[4] / 2));
            pictureBox6.Size = new Size(tamano[4], tamano[4]);
            pictureBox7.Location = new Point((posX[5] - (tamano[5] / 2)), (posY[5] - tamano[5] / 2));
            pictureBox7.Size = new Size(tamano[5], tamano[5]);
            pictureBox8.Location = new Point((posX[6] - (tamano[6] / 2)), (posY[6] - tamano[6] / 2));
            pictureBox8.Size = new Size(tamano[6], tamano[6]);
            pictureBox9.Location = new Point((posX[7] - (tamano[7] / 2)), (posY[7] - tamano[6] / 2));
            pictureBox9.Size = new Size(tamano[7], tamano[7]);
            
            for(int j=0; j<1;j++)
            {
                dirX[j] = posX[4] + (int)(250 * Math.Pow(forbita, j) * Math.Sin(tiempo / (Math.Pow(velocidad, j))));
            dirY[j] = posY[4] + (int)(120 * Math.Pow(forbita, j) * Math.Cos(tiempo / (Math.Pow(velocidad, j))));
            tamanoLuna[j] = (posY[4] / 10) * tamano[4];

            pictureBox5.Location = new Point((posX[2] - (tamano[2] / 2)), (posY[0] - tamano[5] / 2));
            pictureBox5.Size = new Size(tamano[5], tamano[5]);
            }
            Refresh();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //minX = 50; maxX = 600;
            //minY = 50; maxY = 450;
            //dirX = 1; dirY = 1;
            // posX = 100; posY = 70;
            button4.Visible = false;
            button5.Visible = false;
            label2.Visible = false;
            tiempo = 0.0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            miDibujo = e.Graphics;
        }
    }
}
