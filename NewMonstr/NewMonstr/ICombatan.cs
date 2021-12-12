using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMonstr
{
    public interface ICombatan
    {       
        public bool Attack();
        public int MinAttack { get; set; }
        public int MaxAttack { get; set; }
    }
}
