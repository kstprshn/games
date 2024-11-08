using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    
    public partial class cars : Form
    {
        Random r = new Random();
        int x, y;
        Generator gen;

        private List<enemy_car> enemy_cars = new List<enemy_car>();

        public cars()
        {
            InitializeComponent();
            label1.Visible = false;
            button1.Visible = false;
            gen = Generator.GetInstance();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coin(gamespeed);
            collectioncoins();
        }
        int coincount = 0;


        void enemy(int speed)
        {
            enemy_cars.Add(new enemy_car(enemycar1));
            enemy_cars.Add(new enemy_car(enemycar2));
            enemy_cars.Add(new enemy_car(enemycar3));
            for (int i = 0; i < enemy_cars.Count; i++) {
                enemy_cars[i].move(gamespeed);
            }
        }
     
        void coin(int speed)
        {
            if (coin1.Top >= 700) 
            {
                x = r.Next(0, 365);
                y = r.Next(0, 30);
                coin1.Location = new Point(x, y);
            }
            else
            {
                coin1.Top += speed;
            }
            if (coin2.Top >= 700)
            {
                x = r.Next(0, 365);
                y = r.Next(0, 30);
                coin2.Location = new Point(x, y);
            }
            else
            {
                coin2.Top += speed;
            }
            if (coin3.Top >= 700)
            {
                x = r.Next(0, 365);
                y = r.Next(0, 30);
                coin3.Location = new Point(x, y);
            }
            else
            {
                coin3.Top += speed;
            }

        }





        void nonvisible()
        {
            car.Visible = false;
            enemycar1.Visible = false;
            enemycar2.Visible = false;
            enemycar3.Visible = false;
            coin1.Visible = false;
            coin2.Visible = false;
            coin3.Visible = false;
            button1.Visible = true;
   
        }
        void gameover()
        {
            if (car.Bounds.IntersectsWith(enemycar1.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
                nonvisible();
            }
            if (car.Bounds.IntersectsWith(enemycar2.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
                nonvisible();
            }
            if (car.Bounds.IntersectsWith(enemycar3.Bounds))
            {
                timer1.Enabled = false;
                label1.Visible = true;
                nonvisible();
            }
        }
        void moveline(int speed)
        {
            if (pictureBox1.Top >= 700)
            {
                pictureBox1.Top = 0;
            }
            else
            { 
                pictureBox1.Top += speed;   
            }
            if (pictureBox2.Top >= 700) 
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 700)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 700)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

        }

        void collectioncoins()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                coincount++;
                label2.Text = "Coins = " + coincount.ToString();
                x = r.Next(0, 365);
                y = r.Next(0, 30);
                coin1.Location = new Point(x, y);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                coincount++;
                label2.Text = "Coins = " + coincount.ToString();
                x = r.Next(0, 365);
                y = r.Next(0, 30);
                coin2.Location = new Point(x, y);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                coincount++;
                label2.Text = "Coins = " + coincount.ToString();
                x = r.Next(0, 365);
                y = r.Next(0, 30);
                coin3.Location = new Point(x, y);
            }
        }

        int gamespeed = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enemycar2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left)
            { 
                if (car.Left > 10)
                  car.Left += -17;
            }
            if (e.KeyCode == Keys.Right)
            {  
                if (car.Right < 429)
                  car.Left += 17;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                }
            }
        }

    }
    public class enemy_car
    {
        private int x;
        private int y;
        Random r = new Random();
        PictureBox pick;
        Generator gen;

        public enemy_car(PictureBox _pick)
        {
            gen = Generator.GetInstance();
            x = gen.randomX();
            y = gen.randomY();
            pick = _pick;
        }

        public void move(int spd)
        {
           
            pick.Top += spd;
            y = pick.Top;            
            if (y > 700) {
                y = gen.randomY();
                pick.Top = y;
                x = gen.randomX();
                pick.Left = x;
            }
        }

        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }

        public PictureBox getPic()
        {
            return pick;
        }

    }

    public class Generator
    {
        private Generator() { }
        private static Generator _instance;
        public static Generator GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Generator();
            }
            return _instance;
        }

        public int randomX()
        {
            int i;

            Random r = new Random();
            i = r.Next(20, 365);

            return i;
        }
        public int randomY()
        {
            int i;

            Random r = new Random();
            i = r.Next(20, 70);

            return i;
        }

    }

}
