using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Class identifiers are sentence casing
//for mroe than 1 word titles use CamelCase
namespace Syntax
{
    class Syntax
    {
        void ShootLaser()
        {
            Console.Write("hello World"); //each single line ends with a ;

            // = is an assigning operator
            // == is a comparison operator
            if (2 + 2 == 5)
            {
                Console.Write("It's True");
            }

            if (true != false)
            {
                Console.Write("It's a paradox");
            }

            int box = 6, pyramid = 4;
            if (box > pyramid)
            {
                Console.Write("A Box has more sides than a Pyramid");
            }
        }
        
    }
}
