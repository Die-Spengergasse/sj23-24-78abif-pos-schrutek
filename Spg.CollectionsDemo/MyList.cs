using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CollectionsDemo
{
    public class MyList : List<ClassRoom>
    {
        /// <summary>
        /// Das ist unser toller Indexer!!!
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <example>
        /// 
        /// </example>
        /// <param name="number"></param>
        /// <returns></returns>
        public ClassRoom? this[string number]
        {
            get 
            {
                return this.SingleOrDefault(x => x.Number == number);
            }
        }
    }
}
