using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogSolve
{
    public class FrogDeck
    {
        private FrogCard[] _frog_deck = new FrogCard[9];

        public FrogDeck()
        {

        }

        public void LoadDeck()
        {
            _frog_deck[0] = new FrogCard(
                    new FrogPart("blue", "head"),
                    new FrogPart("yellow", "butt"),
                    new FrogPart("green", "butt"),
                    new FrogPart("red", "butt")
                    );

            _frog_deck[1] = new FrogCard(
                    new FrogPart("red", "butt"),
                    new FrogPart("yellow", "head"),
                    new FrogPart("blue", "butt"),
                    new FrogPart("green", "butt")
                    );

            _frog_deck[2] = new FrogCard(
                    new FrogPart("yellow", "butt"),
                    new FrogPart("green", "head"),
                    new FrogPart("blue", "butt"),
                    new FrogPart("red", "head")
                    );

            _frog_deck[3] = new FrogCard(
                    new FrogPart("green", "butt"),
                    new FrogPart("green", "head"),
                    new FrogPart("yellow", "butt"),
                    new FrogPart("red", "butt")
                    );

            _frog_deck[4] = new FrogCard(
                    new FrogPart("green", "head"),
                    new FrogPart("red", "butt"),
                    new FrogPart("yellow", "butt"),
                    new FrogPart("blue", "butt")
                    );
            //
            _frog_deck[5] = new FrogCard(
                    new FrogPart("blue", "head"),
                    new FrogPart("yellow", "butt"),
                    new FrogPart("green", "butt"),
                    new FrogPart("red", "butt")
                    );

            _frog_deck[6] = new FrogCard(
                    new FrogPart("blue", "head"),
                    new FrogPart("yellow", "butt"),
                    new FrogPart("green", "butt"),
                    new FrogPart("red", "butt")
                    );

            _frog_deck[7] = new FrogCard(
                    new FrogPart("blue", "head"),
                    new FrogPart("yellow", "butt"),
                    new FrogPart("green", "butt"),
                    new FrogPart("red", "butt")
                    );

            _frog_deck[8] = new FrogCard(
                    new FrogPart("blue", "head"),
                    new FrogPart("yellow", "butt"),
                    new FrogPart("green", "butt"),
                    new FrogPart("red", "butt")
                    );

        }

        public FrogCard[] cards
        {
            get { return _frog_deck; }

        }
    }
}
