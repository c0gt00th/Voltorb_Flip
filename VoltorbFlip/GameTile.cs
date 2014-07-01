using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoltorbFlip
{
    class GameTile
    {
        //Value for card value; 1 = 1, 2 = 2, 3 = 3, 4 = bomb;
        private int tileCard;
        //Value for card flipped/not-flipped/marked state; 1 = Not flipped/Unmarked, 2 = Not flipped/Marked, 3 = Flipped; 
        private int tileState;
        
        public void GenerateCard(){
            //Method for randomly generating which card value the tile will hold once clicked on.
        }

        public int GetTileCard(){
            //get method for the current "GameTile" tileCard value;
            return 0;
        }

        public void SetTileState(){
            //set method for the current "GameTile" tileState value;
        }

        public int GetTileState(){
            //get method for the current "GameTile" tileState value;
            return 0;
        }

        public void FlipCard(int newTileCard, int newTileState) { 
            //Method for flipping the card on the game board.
            //Takes both tile values as arguments and changes the
            //image within the PictureBox based off of the data.
        }
    }
}
