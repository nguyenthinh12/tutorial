using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamecaro1
{
    public class ChessBoardManager
    {

        #region properties
        private Panel chessBoard;
       

        #endregion

        #region Initalize
        public ChessBoardManager(Panel chessBoard)
        {
            this.chessBoard = chessBoard;
        }
        #endregion

        #region Methods
      public  void DrawChessBoard()
        {
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < cons.CHESS_BOARD_HEIGHI; i++)
            {
                for (int j = 0; j < cons.CHESS_BOARD_WIDIH; j++)
                {
                    Button btn = new Button() {
                        Width = cons.CHESS_WIDTH,
                        Height = cons.CHESS_HEIGHI,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y)
                    };

                    chessBoard.Controls.Add(btn);

                    oldButton = btn;

                }
                oldButton.Location = new Point(0, oldButton.Location.Y + cons.CHESS_HEIGHI);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }
        #endregion
       
            }
        }
    
