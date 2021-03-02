using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku_Demo
{
    public partial class Form1 : Form
    {
        private Game game = new Game(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Piece piece = game.PlaceAPiece(e.X, e.Y); //存放已經new 過的黑/白棋物件
            if (piece != null)
                this.Controls.Add(piece);  //在視圖上生成棋子
            
            //檢查是否有人獲勝
            if (game.Winner == PieceType.BLACK)
            {
                MessageBox.Show("黑色獲勝");
                game.EndThisGame();
                this.Controls.Clear();
            }else if (game.Winner == PieceType.WHITE)
            {
                MessageBox.Show("白色獲勝");               
                game.EndThisGame();
                this.Controls.Clear();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (game.CanBePlaced(e.X, e.Y))          
                this.Cursor = Cursors.Hand;           
            else
                this.Cursor = Cursors.Default;
        }

        

    }
}
