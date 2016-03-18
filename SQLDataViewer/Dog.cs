using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Dog : Animal
    {

        public string FurColor = "";

        public Dog()
        {

        }

        public virtual string Bark()
        {
            return "Wuff";  
        }
    
    
    
    }


}
