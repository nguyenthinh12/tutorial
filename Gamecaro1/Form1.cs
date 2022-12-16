using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamecaro1
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBourd;
        #endregion
        public Form1()
        {
            InitializeComponent();
            ChessBourd = new ChessBoardManager(pnlChessBoard);

            ChessBourd.DrawChessBoard();
        }


        private void pnlChessBoard_Paint(object sender, PaintEventArgs e)
        {

    
          
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
