using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Gomoku_Demo
{
    class Board
    {
        public static readonly int NODE_COUNT = 9;
        private static readonly Point NO_METCH_NODE = new Point(-1, -1);

        private static readonly int OFFSET = 75;
        private static readonly int NODE_RADIUS = 10;
        private static readonly int NODE_DISTANCE = 75;

        private Piece[,] pieces = new Piece[NODE_COUNT, NODE_COUNT];

        private Point lastPlacedNode = NO_METCH_NODE;
        public Point LastPlacedNode { get { return lastPlacedNode; } }
        public PieceType GetPieceType (int nodeIdX, int nodeIdY)
        {
            if (pieces[nodeIdX, nodeIdY] == null)
                return PieceType.NONE;
            else
                return pieces[nodeIdX, nodeIdY].GetPieceType();
        }

        public bool CanBePlaced(int x,int y)  //為了讓視圖上的指標做 移動上的變化
        {
            //TODO: 找出最接近的點(Node)
            Point nodeID = findTheClosetNode(x, y);

            //TODO: 如果沒有回傳false
            if (nodeID == NO_METCH_NODE)
                return false;

            //TODO: 如果有Node，檢查是否有棋子存在
            if (pieces[nodeID.X, nodeID.Y] != null)
                return false;

            return true;
        }

        public Piece PlaceAPiece (int x, int y, PieceType type)
        {
            //TODO: 找出最接近的點(Node)
            Point nodeID = findTheClosetNode(x, y);

            //TODO: 如果沒有回傳false
            if (nodeID == NO_METCH_NODE)
                return null;

            //TODO: 如果有Node，檢查是否有棋子存在
            if (pieces[nodeID.X, nodeID.Y] != null)  //因為它是物件陣列 所以空值為null
                return null;

            //TODO: 根據type產生對應的棋子
            Point formPoint = convertToFormPosition(nodeID);
            if (type == PieceType.BLACK)
                pieces[nodeID.X, nodeID.Y] = new blackPiece(formPoint.X, formPoint.Y);  //將黑棋物件 放入虛擬棋盤(物件陣列)
            else if (type == PieceType.WHITE)
                pieces[nodeID.X, nodeID.Y] = new whitePiece(formPoint.X, formPoint.Y);  //將白棋物件 放入虛擬棋盤(物件陣列)

            // 紀錄最後下棋子的位子
            lastPlacedNode = nodeID;

            return pieces[nodeID.X, nodeID.Y];
        }

        private Point convertToFormPosition(Point nodeID)
        {
            int x = OFFSET + nodeID.X * NODE_DISTANCE;
            int y = OFFSET + nodeID.Y * NODE_DISTANCE;

            return new Point(x, y);
        }

        private Point findTheClosetNode(int x , int y)
        {
            int nodeX = findTheClosetNode(x);
            if (nodeX == -1 || nodeX >= NODE_COUNT)
                return NO_METCH_NODE;
            int nodeY = findTheClosetNode(y);
            if (nodeY == -1 || nodeY >= NODE_COUNT)
                return NO_METCH_NODE;

            return new Point(nodeX, nodeY);
        }

        private int findTheClosetNode(int pos)
        {
            if (pos <= OFFSET - NODE_RADIUS)
                return -1;
            pos -= OFFSET;
            
            int quotient = pos / NODE_DISTANCE;
            int remainder = pos % NODE_DISTANCE;
            if (remainder >= NODE_DISTANCE - NODE_RADIUS)
                return quotient += 1;
            else if (remainder <= NODE_RADIUS)
                return quotient;
            else
                return -1;
        }

        public void RemoveAllThePieces()
        {
            Array.Clear(pieces, 0, pieces.Length);
            //for(int x = 0; x < node_count; x++)
            //{
            //    for(int y = 0; y < node_count; y++)
            //    {
            //        pieces[x, y] = null;
            //    }
            //}
        }


    }
}
