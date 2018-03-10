using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogSolve
{

    // A frog part has a color (red, green, blue, yellow) and a body part (head or butt)
    public class FrogPart
    {
        private String _body_part;
        private String _body_color;

        public FrogPart()
        {

        }

        public FrogPart(String p_body_part, String p_body_color)
        {
            _body_part = p_body_part;
            _body_color = p_body_color;
        }

        public String body_part
        {
            get { return _body_part; }
            set { _body_part = value; }
        }
        public String color
        {
            get { return _body_color; }
            set { _body_color = value; }
        }

    }


}
