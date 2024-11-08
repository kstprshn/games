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
    public partial class chess : Form
    {
        public int[,] map = new int[8, 8]
        {
            {15,14,13,12,11,13,14,15},
            {16,16,16,16,16,16,16,16},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {26,26,26,26,26,26,26,26},
            {25,24,23,22,21,23,24,25},
        };
        public Button [,] butts = new Button[8,8];//связать числовой массив с 
                                                 //массивом кнопок
        public int Player;
        public Button lastButton;
        public bool moving = false;
        public chess()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 750;
            Init();
        }
        public void Init()
        {
            CreateMap();
            Player = 2;
        }
        public void CreateMap()
        {  
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        butts[i, j] = new Button();
                        Button But = new Button();
                        But.Size = new Size(85, 85);
                        But.Location = new Point(j * 85, i * 85);
                        But.BackColor = Color.White;
                        if ((i == 0)&& (j == 4))
                        {                                              
                        But.BackgroundImage = pictureBox6.BackgroundImage;
                        }
                        if ((i == 0) && (j == 3))
                        {
                            But.BackgroundImage = pictureBox4.BackgroundImage;
                        }
                        if ((i == 0) && ((j == 2)||(j  ==5)))
                        {
                            But.BackgroundImage = pictureBox7.BackgroundImage;
                        }
                        if ((i == 0) && ((j == 1) || (j == 6)))
                        {
                            But.BackgroundImage = pictureBox5.BackgroundImage;
                        }
                        if ((i == 0) && ((j == 0) || (j == 7)))
                        {
                            But.BackgroundImage = pictureBox1.BackgroundImage;
                        }
                        if (i == 1)
                        {
                            But.BackgroundImage = pictureBox3.BackgroundImage;
                        }
                           
                    if ((i == 7) && (j == 4))
                    {
                        But.BackgroundImage = pictureBox12.BackgroundImage;
                    }
                    if ((i == 7) && (j == 3))
                    {
                        But.BackgroundImage = pictureBox11.BackgroundImage;
                    }
                    if ((i == 7) && ((j == 2) || (j == 5)))
                    {
                        But.BackgroundImage = pictureBox8.BackgroundImage;
                    }
                    if ((i == 7) && ((j == 1) || (j == 6)))
                    {
                        But.BackgroundImage = pictureBox9.BackgroundImage;
                    }
                    if ((i == 7) && ((j == 0) || (j == 7)))
                    {
                        But.BackgroundImage = pictureBox2.BackgroundImage;
                    }
                    if (i == 6)
                    {
                        But.BackgroundImage = pictureBox10.BackgroundImage;
                    }
                    But.BackColor = Color.White;
                    But.Click += new EventHandler(PressOnFigure);
                    //кнопка будет реагировать на клик по ней
                     this.Controls.Add(But);
                    butts[i, j] = But;//элементу массива присваивается своя кнопка
                                      //с конкретной фигурой 
                    }
            }
        }
        public void PressOnFigure(object sender, EventArgs e)//обрабатывает нажатия
                                                            //на кнопку(фигуру)
        {      
            Button pressedButton = sender as Button;
            if (map[pressedButton.Location.Y / 85, pressedButton.Location.X / 85] != 0 && map[pressedButton.Location.Y / 85, pressedButton.Location.X / 85] / 10 == Player)
            {
                dumpcolor();
                pressedButton.BackColor = Color.IndianRed;
                DeactivateAllButtons();
                pressedButton.Enabled = true;
                ShowSteps(pressedButton.Location.Y / 85, pressedButton.Location.X / 85, map[pressedButton.Location.Y / 85, pressedButton.Location.X / 85]);
                if (moving)
                {
                    dumpcolor();
                    pressedButton.BackColor = Color.White;
                    ActivateAllButtons();
                    moving = false;
                }
                else
                    moving = true;
            }
            else
            {
                if (moving)
                {
                    int temp = map[pressedButton.Location.Y / 85, pressedButton.Location.X / 85];
                    map[pressedButton.Location.Y / 85, pressedButton.Location.X / 85] = map[lastButton.Location.Y / 85, lastButton.Location.X / 85];
                    map[lastButton.Location.Y / 85, lastButton.Location.X / 85] = temp;
                    pressedButton.BackgroundImage = lastButton.BackgroundImage;
                    lastButton.BackgroundImage = null;
                    moving = false;
                    dumpcolor();
                    ActivateAllButtons();
                    SwitchPlayer();
                }
            }           
            lastButton = pressedButton;
        }
        public void ShowSteps(int IcurrFigure, int JcurrFigure, int currFigure)
        {
           
            int dir = Player == 1 ? 1 : -1;
            switch (currFigure % 10)
            {
                case 6:
                    if (InsideBorder(IcurrFigure + 1 * dir, JcurrFigure))
                    {
                        if (map[IcurrFigure + 1 * dir, JcurrFigure] == 0)
                        {
                            butts[IcurrFigure + 1 * dir, JcurrFigure].BackColor = Color.Yellow;
                            butts[IcurrFigure + 1 * dir, JcurrFigure].Enabled = true;
                            if (InsideBorder(IcurrFigure + 2 * dir, JcurrFigure))
                            {
                                if (map[IcurrFigure + 2 * dir, JcurrFigure] == 0)
                                {
                                    butts[IcurrFigure + 2 * dir, JcurrFigure].BackColor = Color.Yellow;
                                    butts[IcurrFigure + 2 * dir, JcurrFigure].Enabled = true;
                                }

                            }

                        }
                    }

                    if (InsideBorder(IcurrFigure + 1 * dir, JcurrFigure + 1))
                    {
                        if (map[IcurrFigure + 1 * dir, JcurrFigure + 1] != 0 && map[IcurrFigure + 1 * dir, JcurrFigure + 1] / 10 != Player)
                        {
                            butts[IcurrFigure + 1 * dir, JcurrFigure + 1].BackColor = Color.Yellow;
                            butts[IcurrFigure + 1 * dir, JcurrFigure + 1].Enabled = true;
                        }
                    }
                    if (InsideBorder(IcurrFigure + 1 * dir, JcurrFigure - 1))
                    {
                        if (map[IcurrFigure + 1 * dir, JcurrFigure - 1] != 0 && map[IcurrFigure + 1 * dir, JcurrFigure - 1] / 10 != Player)
                        {
                            butts[IcurrFigure + 1 * dir, JcurrFigure - 1].BackColor = Color.Yellow;
                            butts[IcurrFigure + 1 * dir, JcurrFigure - 1].Enabled = true;
                        }
                    }
                    break;
                case 5:
                    ShowVerticalHorizontal(IcurrFigure, JcurrFigure);
                    break;
                case 3:
                    ShowDiagonal(IcurrFigure, JcurrFigure);
                    break;
                case 2:
                    ShowVerticalHorizontal(IcurrFigure, JcurrFigure);
                    ShowDiagonal(IcurrFigure, JcurrFigure);
                    break;
                case 1:
                    ShowVerticalHorizontal(IcurrFigure, JcurrFigure, true);
                    ShowDiagonal(IcurrFigure, JcurrFigure, true);
                    break;
                case 4:
                    ShowHorseSteps(IcurrFigure, JcurrFigure);
                    break;
            }
        }
        public void ShowHorseSteps(int IcurrFigure, int JcurrFigure)
        {
            if (InsideBorder(IcurrFigure - 2, JcurrFigure + 1))
            {
                DeterminePath(IcurrFigure - 2, JcurrFigure + 1);
            }
            if (InsideBorder(IcurrFigure - 2, JcurrFigure - 1))
            {
                DeterminePath(IcurrFigure - 2, JcurrFigure - 1);
            }
            if (InsideBorder(IcurrFigure + 2, JcurrFigure + 1))
            {
                DeterminePath(IcurrFigure + 2, JcurrFigure + 1);
            }
            if (InsideBorder(IcurrFigure + 2, JcurrFigure - 1))
            {
                DeterminePath(IcurrFigure + 2, JcurrFigure - 1);
            }
            if (InsideBorder(IcurrFigure - 1, JcurrFigure + 2))
            {
                DeterminePath(IcurrFigure - 1, JcurrFigure + 2);
            }
            if (InsideBorder(IcurrFigure + 1, JcurrFigure + 2))
            {
                DeterminePath(IcurrFigure + 1, JcurrFigure + 2);
            }
            if (InsideBorder(IcurrFigure - 1, JcurrFigure - 2))
            {
                DeterminePath(IcurrFigure - 1, JcurrFigure - 2);
            }
            if (InsideBorder(IcurrFigure + 1, JcurrFigure - 2))
            {
                DeterminePath(IcurrFigure + 1, JcurrFigure - 2);
            }
        }

        public void DeactivateAllButtons()//деактивированы кнопки(то есть когда очередь 
                                 //ходить другому игроку,для 1го игрока кнопки 
                                      //недоступны,то есть DeactivateAllButtons()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    butts[i, j].Enabled = false;
                }
            }
        }

        public void ActivateAllButtons()//активированы кнопки(то есть когда очередь 
                                //ходить игроку,ему кнопки доступны,а когда очередь
                          //ходить другому игроку,для 1го игрока кнопки 
                                        //недоступны,то есть DeactivateAllButtons()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    butts[i, j].Enabled = true;
                }
            }
        }

        public void ShowDiagonal(int IcurrFigure, int JcurrFigure, bool isOneStep = false)
        {
            int j = JcurrFigure + 1;
            for (int i = IcurrFigure - 1; i >= 0; i--)
            {
                if (InsideBorder(i, j))
                {
                    if (!DeterminePath(i, j))
                        break;
                }
                if (j < 7)
                    j++;
                else break;

                if (isOneStep)
                    break;
            }
            j = JcurrFigure - 1;
            for (int i = IcurrFigure - 1; i >= 0; i--)
            {
                if (InsideBorder(i, j))
                {
                    if (!DeterminePath(i, j))
                        break;
                }
                if (j > 0)
                    j--;
                else break;

                if (isOneStep)
                    break;
            }

            j = JcurrFigure - 1;
            for (int i = IcurrFigure + 1; i < 8; i++)
            {
                if (InsideBorder(i, j))
                {
                    if (!DeterminePath(i, j))
                        break;
                }
                if (j > 0)
                    j--;
                else break;

                if (isOneStep)
                    break;
            }

            j = JcurrFigure + 1;
            for (int i = IcurrFigure + 1; i < 8; i++)
            {
                if (InsideBorder(i, j))
                {
                    if (!DeterminePath(i, j))
                        break;
                }
                if (j < 7)
                    j++;
                else break;

                if (isOneStep)
                    break;
            }
        }

        public void ShowVerticalHorizontal(int IcurrFigure, int JcurrFigure, bool isOneStep = false)
        {
            for (int i = IcurrFigure + 1; i < 8; i++)
            {
                if (InsideBorder(i, JcurrFigure))
                {
                    if (!DeterminePath(i, JcurrFigure))
                        break;
                }
                if (isOneStep)
                    break;
            }
            for (int i = IcurrFigure - 1; i >= 0; i--)
            {
                if (InsideBorder(i, JcurrFigure))
                {
                    if (!DeterminePath(i, JcurrFigure))
                        break;
                }
                if (isOneStep)
                    break;
            }
            for (int j = JcurrFigure + 1; j < 8; j++)
            {
                if (InsideBorder(IcurrFigure, j))
                {
                    if (!DeterminePath(IcurrFigure, j))
                        break;
                }
                if (isOneStep)
                    break;
            }
            for (int j = JcurrFigure - 1; j >= 0; j--)
            {
                if (InsideBorder(IcurrFigure, j))
                {
                    if (!DeterminePath(IcurrFigure, j))
                        break;
                }
                if (isOneStep)
                    break;
            }
        }
        public bool DeterminePath(int IcurrFigure, int j)
        {
        //ПРОВЕРЯЕТ:если ячейка в этих координатах пустая,то возможность хода-ДА
        //ЕСЛИ вражеская фигура -то ходиться можно на нее(то есть съесть ее)
        //ЕСЛИ своя фигура-то ходить на эту ячейку НЕЛЬЗЯ
            if (map[IcurrFigure, j] == 0)
            {
                butts[IcurrFigure, j].BackColor = Color.Yellow;
                butts[IcurrFigure, j].Enabled = true;
            }
            else
            {
                if (map[IcurrFigure, j] / 10 != Player)
                {
                    butts[IcurrFigure, j].BackColor = Color.Yellow;
                    butts[IcurrFigure, j].Enabled = true;
                }
                return false;
            }
            return true;
        }

        public bool InsideBorder(int ti, int tj)//проверяет находится ли 
                                         //переданное значение внутри игровой доски
        {                              //то есть чтобы перемещение фигуры было
                                         //в пределах 8:8
            if (ti >= 8 || tj >= 8 || ti < 0 || tj < 0)
                return false;
            return true;
        }

        public void dumpcolor()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    butts[i, j].BackColor = Color.White;
                }
            }
        }
        public void SwitchPlayer()
        {
            if (Player == 2)
                Player = 1;
            else
                Player = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
