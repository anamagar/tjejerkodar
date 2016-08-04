using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
   
    public partial class Game : Form
    {

        BoardUI board;
        static Player player1;
        static Player player2;
        Button[] listButton;
        static int sizeOfBoard;
        int startPointX = 0;
        int startPointY = 40;
        

        public Game() {
            InitializeComponent();
        }

        void initializeConfiguration() {
            board = new BoardUI(sizeOfBoard, sizeOfBoard);
            this.listButton = new Button[board.getRows() * board.getRows()];
            DrawBoard(board);
        }

        public static void setSizeOfBoard(int size) {
            sizeOfBoard = size;
        }

        public static void setPlayers(Player p1, Player p2)
        {
            player1 = p1;
            player2 = p2;
            
        }      

        Player getPlayer()
        {
            Player p = player1;
            if (player2.getTurn() && !player2.isComputer()) {
                p = player2;
            }
            return p;
        }
        void switchPlayer(Player p) {
            
            if (p == player1 && !player2.isComputer())
            {
                player1.setTurn(false);
                player2.setTurn(true);
            }
            else if (p == player2 && !player2.isComputer()) {
                player1.setTurn(true);
                player2.setTurn(false);
            }
        }

        bool thereIsAWinner(BoardUI board, String piece)
        {
            bool thereIsAWinner = false;
            if (board.checkColWinner(piece) || board.checkRowWinner(piece) || board.checkDiagonalWinner(piece))
            {
                thereIsAWinner = true;   
            }
            return thereIsAWinner;
        }

        public void DrawBoard(BoardUI board) {
            int cellNr = 0;
            for (int i = 0; i < board.getRows(); i++) {
                for (int j = 0; j < board.getRows(); j++)
                {
                    Button BtnNew = new Button();
                    BtnNew.Tag = cellNr; // Tag of button 
                    BtnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    BtnNew.Height = 80;
                    BtnNew.Width = 80;
                    BtnNew.Location = new Point((80 * i) + startPointX, (80 * j) + startPointY);
                    BtnNew.Text = board.getPiece(i, j);
                    BtnNew.Click += new System.EventHandler(ClickButton);
                    this.Controls.Add(BtnNew);
                    this.listButton[cellNr] = BtnNew;
                    cellNr++;
                }
            }
            
        }

        void initializeButton() {
            for (int i = 0; i < listButton.Length; i++) {
                listButton[i].Text = "";
            }
        }

        public bool insertPiece(int row, int col, string piece) {
            bool insertedPice = false;
            if (!board.isBoardFull() && board.isAvailablePosition(row, col))
            {
                board.setPiece(row, col, piece);
                insertedPice = true; 
            }
            return insertedPice;
        }

        //create computer player
        void computerPlayer(ref int row, ref int col) {
            Random rnd = new Random();
            row = rnd.Next(0, board.getRows());
            col = rnd.Next(0, board.getRows());
        }
        
        void continuePlayingMessage() {
            DialogResult result = MessageBox.Show("Do you want to continue playing?", "caption", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                newGame();
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }

        }

        void updateScore() {
            player1Score.Text = player1.getScore().ToString();
            player2Score.Text = player2.getScore().ToString();
        }

        void checkIfThereIsAWinner(BoardUI board, Player p)
        {
            if (thereIsAWinner(board, p.getPiece()))
            {
                MessageBox.Show("There is a winner " + p.getName());
                p.setScore(p.getScore()+1);
                updateScore();
                continuePlayingMessage();
            }

        }

        void computerInsert(String piece) {
            int rowref = 0;
            int colref = 0;
            int buttonPosition = 0;
            while (!board.isBoardFull())
            {
                computerPlayer(ref rowref, ref colref);
                if (board.isAvailablePosition(rowref, colref))
                {
                    buttonPosition = colref * board.getRows() + rowref;
                    Button bt2 = this.listButton[buttonPosition];
                    bt2.Text = piece;
                    board.setPiece(rowref, colref, piece);
                    checkIfThereIsAWinner(board, player2);
                    break;
                }
            }
        }

        // Result of (Click Button) event, get the text of button 
        public void ClickButton(Object sender, System.EventArgs e)
        {
            if (sender is Button)
            {
                Player p = getPlayer();
                String piece = p.getPiece();
                Button btn = (Button)sender;
                
                int selectedCol = (int)btn.Tag / board.getRows();
                int selectedRow = (int)btn.Tag % board.getRows();

                if (insertPiece(selectedRow, selectedCol, piece))
                {
                    btn.Text = piece;
                    switchPlayer(p);
                    checkIfThereIsAWinner(board, p);
                }
                else {

                    MessageBox.Show("Could not instert!");
                }

                if (player2.isComputer()) {
                    computerInsert(player2.getPiece());

                }
            }
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetCountersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.player1Name = new System.Windows.Forms.Label();
            this.player1Score = new System.Windows.Forms.TextBox();
            this.player2Name = new System.Windows.Forms.Label();
            this.player2Score = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetCountersToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetCountersToolStripMenuItem
            // 
            this.resetCountersToolStripMenuItem.Name = "resetCountersToolStripMenuItem";
            this.resetCountersToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.resetCountersToolStripMenuItem.Text = "Reset Counters";
            this.resetCountersToolStripMenuItem.Click += new System.EventHandler(this.resetCountersToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // player1Name
            // 
            this.player1Name.AutoSize = true;
            this.player1Name.Location = new System.Drawing.Point(60, 0);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(0, 13);
            this.player1Name.TabIndex = 1;
            // 
            // player1Score
            // 
            this.player1Score.Location = new System.Drawing.Point(72, 20);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(24, 20);
            this.player1Score.TabIndex = 2;
            // 
            // player2Name
            // 
            this.player2Name.AutoSize = true;
            this.player2Name.Location = new System.Drawing.Point(120, 0);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(0, 13);
            this.player2Name.TabIndex = 4;
            // 
            // player2Score
            // 
            this.player2Score.Location = new System.Drawing.Point(139, 20);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(24, 20);
            this.player2Score.TabIndex = 6;
            // 
            // Game
            // 
            this.ClientSize = new System.Drawing.Size(727, 506);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.player2Name);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.player1Name);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Game_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void resetCounters() {
            player1Score.Text = "0";
            player2Score.Text = "0";
        }

        private void Game_Load(object sender, EventArgs e)
        {
            SetUpConfiguration showConfiguration = new SetUpConfiguration();
            showConfiguration.ShowDialog();
            
            this.ClientSize = new System.Drawing.Size((sizeOfBoard * 80) + startPointX, (sizeOfBoard * 80)+ startPointY);
            this.CenterToScreen();
            initializeConfiguration();
            player1Name.Text = player1.getName();
            player2Name.Text = player2.getName();
            resetCounters();
        }

        private void newGame() {
            board.initiallize();
            initializeButton();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetCountersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetCounters();
        }
    }
}
