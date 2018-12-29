using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLinqExpressions
{
    class ProductInfo
    {
        #region Properties
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int NumberInStock { get; set; } = 0;
        #endregion

        #region Methods
        public override string ToString() => $"Name={Name}, Description={Description}, Number in stock={NumberInStock}";
        #endregion
    }
}
