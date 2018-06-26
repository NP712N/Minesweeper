using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        int win;
        Button[,] btn = new Button[10, 10];
        byte flags = 10;
        
        public Form1()
        {
            InitializeComponent();
            DrowBoard();
            CountMines();
            labFLag.Text = Convert.ToString(flags);
        }
        #region Methods
        void DrowBoard()
        {
            pnlBoard.Controls.Clear();
            int x, y; x = y = 0;

            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    btn[i, j] = new Button
                    {
                        Width = Height = 25,
                        Location = new Point(x, y),
                        BackColor = Color.White,
                        TabStop = false

                    };
                    this.btn[i, j].MouseUp += new MouseEventHandler(this.Buttons_Click);
                    this.btn[i, j].EnabledChanged += new EventHandler(Enable_Changed);
                    btn[i, j].Tag = new Cell(i, j);
                    pnlBoard.Controls.Add(btn[i, j]);
                    x += 25;
                }
                x = 0;
                y += 25;
            }
            Mines();

        }
        void Mines()
        {
            int countMines = 0, _x = 0, _y = 0;
            while (countMines < 10)
            {
                Random randM = new Random();
                _x = randM.Next(0, 10);
                _y = randM.Next(0, 10);
                if (((Cell)btn[_x, _y].Tag).IsMine == false) { ((Cell)btn[_x, _y].Tag).IsMine = true; countMines++; };
            }
        }//sinh bom     
        void CountMines()
        {
            int[] a = new int[8] { -1, -1, -1, 0, 1, 1, 1, 0 };
            int[] b = new int[8] { -1, 0, 1, 1, 1, 0, -1, -1 };
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    for (int k = 0; k < a.Length; k++)
                    {
                        if ((i + a[k] >= 0) && (i + a[k] < 10) && (j + b[k] >= 0) && (j + b[k] < 10) && (((Cell)btn[i, j].Tag).IsMine == false))
                        {
                            ((Cell)btn[i, j].Tag).MinesAround += (((Cell)btn[i + a[k], j + b[k]].Tag).IsMine == true) ? (byte)1 : (byte)0;
                        }
                    }
                }
            }
        }
        void NewGame()
        {
            win = 0;     
            DrowBoard();
            CountMines();
        }
        void ClicksAround(Button btnn)
        {
            
            Cell c = (Cell)btnn.Tag;
            if (c.IsFlag)
            {
                return;
            }
            if (btnn.ImageIndex == 1)
            {
                return;
            }
            
            btnn.ImageIndex = 1;
            int x = c.X;
            int y = c.Y;
            btnn.Enabled = false;
            if (c.MinesAround != 0)
            {
                btnn.Text = Convert.ToString(c.MinesAround);
                return;
            }

            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if ((i >= 0 && i < 10) && (j >= 0 && j < 10))
                    {
                        ClicksAround(btn[i, j]);
                    }
                }
            }
        }
        void ShowBom()
        {
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    if (((Cell)btn[i, j].Tag).IsMine == true)
                    {
                        btn[i, j].Image = Image.FromFile(@"D:\C#\Project\Minesweeper\Minesweeper\bin\Debug\Resources\clanbomber.png");
                    }
                }
            }
        }
        void CountFlags()
        {
            int count = 0;
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    if (((Cell)btn[i, j].Tag).IsFlag == true)
                    {
                        count++;
                        labFLag.Text = Convert.ToString(flags);
                        btn[i, j].Image = Image.FromFile(@"D:\C#\Project\Minesweeper\Minesweeper\Artua-Wall-E-Eve.ico");
                    }
                }
            }
            labFLag.Text = Convert.ToString(flags - count);
        }

        #endregion
        #region Events
        void Enable_Changed(object a, EventArgs e)
        {
            win++;
            Button btnn = (Button)a;
            if (btnn.Enabled == false)
            {
                btnn.BackColor = Color.Transparent;
            }
            if(win == 90)
            {
                MessageBox.Show("You win!", "Thông Báo");
                ShowBom();
            }
            
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            NewGame();

        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void beginnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thông báo", "Bạn muốn thoát game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else e.Cancel = true;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Buttons_Click(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    Button btn = (Button)sender;
                    Cell c = (Cell)btn.Tag;
                    if (c.IsMine)
                    {
                        ShowBom();
                        MessageBox.Show("Thua rồi!", "Bạn đã đạp phải bom");
                        NewGame();
                    }
                    else
                    {
                        btn.BackColor = Color.Transparent;
                        ClicksAround(btn);
                    }
                    break;
                case MouseButtons.Right:

                    btn = (Button)sender;
                    c = (Cell)btn.Tag;

                    if (c.IsFlag == true)
                    {
                        c.IsFlag = false;
                        btn.ImageIndex = 0;
                        btn.BackColor = Color.White;
                        CountFlags();


                    }
                    else
                    {
                        if (labFLag.Text == "0")
                            return;
                        c.IsFlag = true;
                        CountFlags();
                    }
                    break;
            }
        }
        #endregion
    }
}

