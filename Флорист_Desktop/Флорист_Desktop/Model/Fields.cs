using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Флорист_Desktop
{
    public partial class Product
    { 
        public string getURL
        {
            get
            {
                if (ProductPhotoUrl.Length == 0)
                    return "/Resources/picture.png";
                return $"/Resources/{ProductPhotoUrl}";
            }
        }
    }
}
