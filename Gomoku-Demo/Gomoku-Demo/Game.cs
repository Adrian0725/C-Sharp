using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku_Demo
{
    class Game
    {
        private PieceType currentPlayer = PieceType.BLACK;
        private Board board = new Board();

        private PieceType winner = PieceType.NONE;
        public PieceType Winner { get { return winner; } }

        public void EndThisGame()
        {
            winner = PieceType.NONE;
            board.RemoveAllThePieces();
        }

        public bool CanBePlaced (int x,int y)
        {
            return board.CanBePlaced(x, y);
        }

        public Piece PlaceAPiece (int x, int y) 
        {
            Piece piece = board.PlaceAPiece(x, y, currentPlayer); //存放已經new 過的黑/白棋物件
            if (piece != null)
            {
                //檢查是否現在下棋的人獲勝
                checkWinner();
                //交換選手
                if (currentPlayer == PieceType.BLACK)
                    currentPlayer = PieceType.WHITE;
                else if (currentPlayer == PieceType.WHITE)
                    currentPlayer = PieceType.BLACK;
                return piece;
            }
            else
                return null;
        }

        private void checkWinner()
        {
            int centerX = board.LastPlacedNode.X;
            int centerY = board.LastPlacedNode.Y;

            //檢查八個不同方向                              //  (x-1,y-1) (x+0,y-1) (x+1,y-1)
            for (int xDir = -1; xDir <= 1; xDir++)          //  (x-1,y+0) (x+0,y+0) (x+1,y+0)
            {                                               //  (x-1,y+1) (x+0,y+1) (x+1,y+1)
                for (int yDir = -1; yDir <= 1; yDir++)      
                {
                    //排除中間的情況
                    if (xDir == 0 && yDir == 0)
                        continue; //跳過下面那陀程式 進下個for
                    
                    //紀錄現在看到幾顆相同的棋子
                    int count = 1;
                    while (count < 5)
                    {
                        int targetX = centerX + count * xDir;
                        int targetY = centerY + count * yDir;

                        //檢查顏色是否相同
                        if (targetX < 0 || targetX >= Board.NODE_COUNT ||    //防止越界 超越陣列出錯
                            targetY < 0 || targetY >= Board.NODE_COUNT ||
                            board.GetPieceType(targetX, targetY) != currentPlayer)
                            break;


                        count++;
                    }

                    int count2 = 1;
                    while (count2 < 5)
                    {
                        int targetX = centerX - count2 * xDir;
                        int targetY = centerY - count2 * yDir;

                        if (targetX < 0 || targetX >= Board.NODE_COUNT ||
                            targetY < 0 || targetY >= Board.NODE_COUNT ||
                            board.GetPieceType(targetX, targetY) != currentPlayer)                            
                            break;
                            
                        count2++;
                    }

                    //檢查是否看到五顆棋子
                    if (count + count2 >= 6)
                    {
                        winner = currentPlayer;
                    }
                        
                }
            }


            
        }
    }
}
