using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    public class Player
    {
        String name;
        String piece;
        bool turn;
        bool computer;
        int score;

        public Player(String name, String piece, bool turn, bool computer){
            this.name = name;
            this.piece = piece;
            this.turn = turn;
            this.computer = computer;
            this.score = 0;
        }

        public void print()
        {
            Console.WriteLine("**********PLAYER*********");
            Console.WriteLine("...." + this.name + ".......");
            Console.WriteLine("SCORE:" + this.piece);
            Console.WriteLine("*************************");
        }

        public string getName()
        {
            return this.name;
        }

        public string getPiece()
        {
            return this.piece;
        }

        public void setTurn(bool turn)
        {
            this.turn = turn;
        }

        public bool getTurn()
        {
            return this.turn;
        }

        public bool isComputer()
        {
            return this.computer;
        }

        public void isComputer(bool isComputer)
        {
            this.computer = isComputer;
        }

        public void setName(string name) {
            this.name = name;
        }

        public void setPiece(string piece)
        {
            this.piece = piece;
        }
        public static bool operator ==(Player p1, Player p2)
        {
            bool status = false;
            if (p1.name == p2.name && p1.piece == p2.piece && p1.computer == p2.computer) {
            
                status = true;
            }
            return status;
        }

        public static bool operator !=(Player p1, Player p2)
        {
            return (p1.name != p2.name && p1.piece != p2.piece && p1.computer != p2.computer);
        }

        public int getScore() {
            return this.score;
        }

        public void setScore(int score)
        {
             this.score = score;
        }
    }

}
