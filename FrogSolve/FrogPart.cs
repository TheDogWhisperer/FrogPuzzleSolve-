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
        // Private Variables

        private String _body_part;
        private System.Drawing.Color _body_color;

        public FrogPart()
        {

        }

        public FrogPart(System.Drawing.Color p_body_color, String p_body_part )
        {
            _body_part = p_body_part;
            _body_color = p_body_color;
        }

        // Public Access Methods
        public String body_part
        {
            get { return _body_part; }
            set { _body_part = value; }
        }
        public System.Drawing.Color color
        {
            get { return _body_color; }
            set { _body_color = value; }
        }

    }


}
