using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogSolve
{


    public class FrogCard
    {
        // Private variables
        int _card_nbr;
        int _rotations;
        FrogPart _top;
        FrogPart _left;
        FrogPart _right;
        FrogPart _bottom;

        public FrogCard()
        {

        }

        public FrogCard(int p_card_nbr, FrogPart p_top, FrogPart p_left, FrogPart p_right, FrogPart p_bottom)
        {
            _card_nbr = p_card_nbr;
            _rotations = 0;
            _top = p_top;
            _left = p_left;
            _right = p_right;
            _bottom = p_bottom;
        }

        // Method to rotate the card 90 degress to the right
        public void RotateCard()
        {
            FrogPart temp_part = new FrogPart();

            temp_part = _top;

            _top = _left;
            _left = _bottom;
            _bottom = _right;
            _right = temp_part;

            _rotations++;


        }

        // Public Access methods
        public int card_nbr
        {
            get { return _card_nbr; }
            set { _card_nbr = value; }
        }

        public int rotations
        {
            get { return _rotations; }
            set { _rotations = value; }
        }

        public FrogPart top {
            get { return _top; }
            set { _top = value; }
        }
        public FrogPart left
        {
            get { return _left; }
            set { _left = value; }
        }

        public FrogPart right
        {
            get { return _right; }
            set { _right = value; }
        }

        public FrogPart bottom
        {
            get { return _bottom; }
            set { _bottom = value; }
        }

    }
}
