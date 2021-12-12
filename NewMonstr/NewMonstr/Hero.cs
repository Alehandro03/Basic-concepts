using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMonstr
{
    class Hero : Humanoid, ICombatan
    {
        public int MinAttack 
        { 
            get => throw new NotImplementedException(); 

            set
            {
                if(Ork)
            } 
        }
        public int MaxAttack { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Attack()
        {
            throw new NotImplementedException();
        }
    }
}
