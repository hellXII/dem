using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Флорист_Desktop
{
    class Instances
    {
        private static <user2Entities> _db = null;
        
        public static <user2Entities> db
        {
            get
            {
                if (_db == null)
                    _db = new <user2Entities>();
                return _db;
            }
        }
    }
}
