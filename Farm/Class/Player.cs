using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Farm.Class;
using System.Drawing;

namespace Farm
{
    public class Player
    {
        public string P_name;
        
        public PictureBox P_img;
        public static Image P_Image = null;
        public Player(string P_name)
        {
            this.P_name = P_name;
        }
        
    }
}
