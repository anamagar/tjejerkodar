using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class SetUpConfiguration : Form
    {
        Player p1;
        Player p2;

        public SetUpConfiguration()
        {
            p1 = new Player("player1", "X", true, false);
            p2 = new Player("Computer", "0", false, true);
            MessageBox.Show("Welcome to tic-tac-toe ");

            InitializeComponent();
            this.CenterToScreen();
        }

        void updatePlayerName(Player p, String name)
        {
            if (name != "")
            {
                p.setName(name);
            }

        }

        void updatePlayerPiece(CheckBox pieceX, CheckBox piece0, Player p)
        {
            if (pieceX.Checked)
            {
                p.setPiece(pieceX.Text);
            }
            else if (piece0.Checked) {
                p.setPiece(piece0.Text);
            }
        }

        void updateTurnPlayer(CheckBox turnPlayer, Player p)
        {
            if (turnPlayer.Checked)
            {
                p.setTurn(turnPlayer.Checked);
            }
        }

        int getSizeOfBoard() {
            int sizeOfBoard = 3;
            if (this.boardSize.Text != "")
            {
                sizeOfBoard = Int32.Parse(this.boardSize.Text);
            }
            return sizeOfBoard;
        }

        private void play_Click(object sender, EventArgs e)
        {
            Game.setSizeOfBoard(getSizeOfBoard());

            updatePlayerName(p1, this.player1Name.Text);
            updatePlayerPiece(this.player1PieceX, this.player1Piece0, p1);
            updateTurnPlayer(this.turnPlayer1, p1);

            if (this.player2PanelInfo.Enabled)
            {
                updatePlayerName(p2, this.player2Name.Text);
                updatePlayerPiece(this.player2PieceX, this.player2Piece0, p2);
                updateTurnPlayer(this.turnPlayer2, p2);
                p2.isComputer(false);
            }

            Game.setPlayers(p1, p2);
            this.Close();

        }

        private void enablePlayer2_MouseClick(object sender, MouseEventArgs e)
        {
            enablePlayer2.Checked = !enablePlayer2.Checked;
            this.player2PanelInfo.Enabled = !this.player2PanelInfo.Enabled;
        }

        private void pieceOfPlayer(object sender, MouseEventArgs e)
        {
            CheckBox piece = (CheckBox)sender;
            if (this.player1PieceX == sender)
            {
                this.player2PieceX.Enabled = !this.player1PieceX.Checked;
                this.player1Piece0.Enabled = !this.player1PieceX.Checked;
                this.player2Piece0.Checked = this.player1PieceX.Checked;
            }
            else if (this.player1Piece0 == sender)
            {
                this.player2Piece0.Enabled = !this.player1Piece0.Checked;
                this.player1PieceX.Enabled = !this.player1Piece0.Checked;
                this.player2PieceX.Checked = this.player1Piece0.Checked;
            }
            else if (this.player2PieceX == sender)
            {
                this.player1PieceX.Enabled = !this.player2PieceX.Checked;
                this.player2Piece0.Enabled = !this.player2PieceX.Checked;
                this.player1Piece0.Checked = this.player2PieceX.Checked;
            }
            else if (this.player2Piece0 == sender)
            {
                this.player2PieceX.Enabled = !this.player2Piece0.Checked;
                this.player1Piece0.Enabled = !this.player2Piece0.Checked;
                this.player1PieceX.Checked = this.player2Piece0.Checked;
            }
        }

        private void turnPlayer_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.turnPlayer1 == sender) {
                this.turnPlayer2.Enabled = !this.turnPlayer1.Checked;
            } else if(this.turnPlayer2 == sender) {
                this.turnPlayer1.Enabled = !this.turnPlayer2.Checked;
            }
        }
    }
}