using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;




namespace tic_tac_toe
{
   
    public class BoardUI 
    {
        public int numberOfCols =3;
        public static int numberOfRows = 3;
        public static int selectedRow;
        public static int selectedCol;
        
        String[][] board;
        
        public BoardUI()
        {
            board = new string[numberOfCols][];
            for (int j = 0; j < numberOfCols; j++)
            {
              board[j] = new string[numberOfRows];
            }
            initiallize();
        }

        public BoardUI(int rows, int cols)
        {
            numberOfRows = rows;
            numberOfCols = cols;
            board = new string[numberOfCols][];
            for (int j = 0; j < numberOfCols; j++)
            {
                board[j] = new string[numberOfRows];
            }
            initiallize();
        }



        /*public void createMenu() {

            // Create a MenuStrip control with a new window.
            MenuStrip ms = new MenuStrip();
            ToolStripMenuItem windowMenu = new ToolStripMenuItem("Window");
            ToolStripMenuItem windowNewMenu = new ToolStripMenuItem("New", null, new EventHandler(windowNewMenu_Click));
            windowMenu.DropDownItems.Add(windowNewMenu);
            ((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowCheckMargin = true;

            // Assign the ToolStripMenuItem that displays 
            // the list of child forms.
            ms.MdiWindowListItem = windowMenu;

            // Add the window ToolStripMenuItem to the MenuStrip.
            ms.Items.Add(windowMenu);

            // Dock the MenuStrip to the top of the form.
            ms.Dock = DockStyle.Top;

            // The Form.MainMenuStrip property determines the merge target.
            this.MainMenuStrip = ms;
            this.Controls.Add(ms);

        }*/






        /*private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createPlayer cp = new createPlayer();
            cp.Show();

            createPlayer cp1 = new createPlayer();
            cp1.Show();
        }
        // Result of (Click Button) event, get the text of button 
        public void ClickButton(Object sender, System.EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                selectedCol = (int)btn.Tag / numberOfRows;
                selectedRow = (int)btn.Tag % numberOfCols;
                selectedButtonUI = true;
        MessageBox.Show("You clicked character [" + btn.Text + " Tag: " + btn.Tag +" ]");
        //Player p = turnPlayer(p1, p2);
        //gameOn(p, row, col);
             }
        }*/

        /*public bool getSelectedButton() {
            return selectedButtonUI;

        }

        public bool setSelectedButton(bool selectedButton)
        {
            return selectedButtonUI = selectedButton;
        }

        public int getSelectedRow() {
            return selectedRow;
        }

        public int getSelectedCol()
        {
            return selectedCol;
        }

        

        // Result of (Click Button) event, get the text of button 
        public void windowNewMenu_Click(Object sender, System.EventArgs e)
        {
            
               
            createPlayer cp = new createPlayer();
             Player p1 = new Player(cp.getName(), cp.getPiece(), true);
            cp.Show();

        }*/


        public bool isAvailablePosition(int row, int col)
        {
            bool isAvailable = false;


            if (row >= numberOfRows || col >= numberOfCols) return isAvailable;
            //try to insert in a position that is bigger that the size of your board
            String bt = this.board[row][col];
            if (board[row] [col] == "")
            {
                isAvailable = true;
            }
            return isAvailable;
        }

        public bool isBoardFull()
        {
            bool isBoardFull = true;
            for (int i = 0; i < numberOfCols && isBoardFull; i++)
            {
                for (int j = 0; j < numberOfRows && isBoardFull; j++)
                {
                    if (isAvailablePosition(i, j))
                    {
                        //you can return also from here
                        isBoardFull = false;
                    }
                }
            }
            return isBoardFull;
        }

        public bool isWinnerRow(int row, string value)
        {

            for (int j = 0; j < numberOfCols; j++)
            {
                if (board[row] [j] != value)
                {
                    return false;
                }
            }

            return true;
        }

        public bool isWinnerCol(int col, string value)
        {

            for (int i = 0; i < numberOfRows; i++)
            {
                if (board[i] [col] != value)
                {
                    return false;
                }
            }

            return true;
        }
        public bool checkColWinner(string value)
        {
            for (int i = 0; i < numberOfCols; i++)
            {
                if (isWinnerCol(i, value))
                {
                    return true;
                }
            }
            return false;


        }



        /// Exercises that this method always return Winner col
        //     public bool checkColWinner(string value) {
        //   bool isWinnerCol = false;
        //  for(int i = 0; i < numberOfColumns; i++)
        // {
        //    isWinnerCol = true;
        // for (int j = 0; j < numberOfRows && isWinnerCol; j++) {
        //         if (board[i][j] != value) {
        //            isWinnerCol = false;
        //      }
        // }
        // if (isWinnerCol)
        //{
        //  return isWinnerCol;
        //}
        //}
        //Console.WriteLine("Winner col:" + isWinnerCol);
        //return isWinnerCol;
        //}



        public bool checkDiagonalWinner(string value)
        {
            bool isWinnerDiagonalRight = false;
            bool isWinnerDiagonalLeft = false;
            if (numberOfCols != numberOfRows) { return isWinnerDiagonalRight; }

            isWinnerDiagonalRight = true;
            isWinnerDiagonalLeft = true;
            for (int i = 0, j = numberOfCols - 1; i < numberOfCols && j >= 0; i++,j--)
            {
                if (board[i][i] != value)
                {
                    isWinnerDiagonalRight = false;
                }

                if (board[i][j] != value)
                {
                    isWinnerDiagonalLeft = false;
                }

            }
            return isWinnerDiagonalRight || isWinnerDiagonalLeft;
        }

        


        public bool checkRowWinner(string value)
        {

            for (int i = 0; i < numberOfRows; i++)
            {
                if (isWinnerRow(i, value))
                {
                    return true;
                }
            }
            return false;
        }
        public void setPiece(int row, int col, string value)
        {
            board[row][col] = value;
        }

        public String getPiece(int row, int col)
        {
            return board[row][col];
        }

        public int getRows()
        {
            return numberOfRows;
        }

        public void initiallize()
        {
            for (int i = 0; i < numberOfCols; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    board[i][j] = "";
                }
            }
        }

        //private void btnExit_Click(object sender, EventArgs e)
        //{
        //  this.Close();
        //}
    }
}
