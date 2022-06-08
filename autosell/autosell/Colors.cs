using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autosell
{
    internal class Colors
    {
        
        public static Color Primary
        {
            get { return ColorTranslator.FromHtml("#0F4C75"); }
        }
        
        public static Color Secondary
        {
            get { return ColorTranslator.FromHtml("#3282B8"); }
        }
        
        public static Color Background
        {
            get { return ColorTranslator.FromHtml("#1B262C"); }
        }

        public static Color Text
        {
            get { return Color.WhiteSmoke; }
        }

    }
}
