﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawler
{
    public partial class GameScreen : UserControl
    {
        Player adventurer = new Player(0, 0, 0, 500);
        public GameScreen()
        {
            InitializeComponent();
        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Wheat), new Rectangle(0, 0, this.Width, this.Height));
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            this.Size = new Size(Form1.width, Form1.height);
        }
    }
}
