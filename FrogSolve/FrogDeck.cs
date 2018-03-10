using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogSolve
{
    public class FrogDeck
    {
        // Private variables
        private FrogCard[] _frog_deck = new FrogCard[9];

        // Deck of 9 Frog Cards
        public FrogDeck()
        {

        }

        // Load the Deck with the cards
        public void LoadDeck()
        {
            _frog_deck[0] = new FrogCard(
                    0,
                    new FrogPart(System.Drawing.Color.Blue, "head"),
                    new FrogPart(System.Drawing.Color.Yellow, "butt"),
                    new FrogPart(System.Drawing.Color.Green, "butt"),
                    new FrogPart(System.Drawing.Color.Red, "butt")
                    );


            _frog_deck[1] = new FrogCard(
                    1,
                    new FrogPart( System.Drawing.Color.Red, "butt"),
                    new FrogPart( System.Drawing.Color.Yellow, "head"),
                    new FrogPart( System.Drawing.Color.Blue, "butt"),
                    new FrogPart( System.Drawing.Color.Green, "butt")
                    );

            _frog_deck[2] = new FrogCard(
                    2,
                    new FrogPart( System.Drawing.Color.Yellow, "butt"),
                    new FrogPart( System.Drawing.Color.Green, "head"),
                    new FrogPart( System.Drawing.Color.Blue, "butt"),
                    new FrogPart( System.Drawing.Color.Red, "head")
                    );

            _frog_deck[3] = new FrogCard(
                    3,
                    new FrogPart( System.Drawing.Color.Green, "butt"),
                    new FrogPart( System.Drawing.Color.Green, "head"),
                    new FrogPart( System.Drawing.Color.Yellow, "butt"),
                    new FrogPart( System.Drawing.Color.Red, "butt")
                    );

            _frog_deck[4] = new FrogCard(
                    4,
                    new FrogPart( System.Drawing.Color.Green, "head"),
                    new FrogPart( System.Drawing.Color.Red, "butt"),
                    new FrogPart( System.Drawing.Color.Yellow, "head"),
                    new FrogPart( System.Drawing.Color.Blue, "butt")
                    );
            //
            _frog_deck[5] = new FrogCard(
                    5,
                    new FrogPart( System.Drawing.Color.Green, "head"),
                    new FrogPart( System.Drawing.Color.Yellow, "butt"),
                    new FrogPart( System.Drawing.Color.Red, "butt"),
                    new FrogPart( System.Drawing.Color.Blue, "head")
                    );

            _frog_deck[6] = new FrogCard(
                    6,
                    new FrogPart( System.Drawing.Color.Red, "butt"),
                    new FrogPart( System.Drawing.Color.Red, "head"),
                    new FrogPart( System.Drawing.Color.Blue, "head"),
                    new FrogPart( System.Drawing.Color.Green, "butt")
                    );

            _frog_deck[7] = new FrogCard(
                    7,
                    new FrogPart( System.Drawing.Color.Green, "head"),
                    new FrogPart( System.Drawing.Color.Blue, "head"),
                    new FrogPart( System.Drawing.Color.Yellow, "butt"),
                    new FrogPart( System.Drawing.Color.Red, "head")
                    );

            _frog_deck[8] = new FrogCard(
                    8,
                    new FrogPart( System.Drawing.Color.Blue, "butt"),
                    new FrogPart( System.Drawing.Color.Yellow, "head"),
                    new FrogPart( System.Drawing.Color.Yellow, "head"),
                    new FrogPart( System.Drawing.Color.Blue, "head")
                    );

        }


        // Test to see if the Deck is in correct order
        public Boolean TestSolution()
        {
            return Test_Left_Right(0, 1) &&

                   Test_Left_Right(1, 2) &&

                   Test_Top_Bottom(3, 0) &&

                   Test_Top_Bottom(4, 1) &&
                   Test_Left_Right(3, 4) &&

                   Test_Top_Bottom(5, 2) &&
                   Test_Left_Right(4, 5) &&

                    Test_Top_Bottom(6, 3) &&

                   Test_Top_Bottom(7, 4) &&
                   Test_Left_Right(6, 7) &&

                   Test_Top_Bottom(8, 5) &&
                   Test_Left_Right(7, 8) 
                   ;

        }

        // Perform a Left -> Right Test of two cards in the deck
        public Boolean Test_Left_Right(int test_card1, int test_card2)
        {
            if (_frog_deck[test_card1].right.color != _frog_deck[test_card2].left.color) return false;
            if (_frog_deck[test_card1].right.body_part == _frog_deck[test_card2].left.body_part) return false;

            return true;

        }

        // Perform a Top -> Bottom test of two cards in the deck
        public Boolean Test_Top_Bottom(int test_card1, int test_card2)
        {
            if (_frog_deck[test_card1].top.color != _frog_deck[test_card2].bottom.color) return false;
            if (_frog_deck[test_card1].top.body_part == _frog_deck[test_card2].bottom.body_part) return false;

            return true;

        }

        // Access methods
        public FrogCard[] cards
        {
            get { return _frog_deck; }

        }
    }
}
