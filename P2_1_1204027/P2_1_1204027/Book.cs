using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204027
{
    public class Book : Product
    {
        protected string pageCount;

        public Book(string type, string tittle, string pagecount)
            base(type,title)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get
            {
                return pageCount;
            }
            
            set
            {
                pageCount = value;
            }
        }
    }
}
