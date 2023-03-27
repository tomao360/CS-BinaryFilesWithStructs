using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinFilesAndStructs
{
    [Serializable]
    internal struct Car
    {
        public int ID;
        public string Name;
        public string Description;
        public float KM;
    }
}
