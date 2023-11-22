using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCI.Domain.Entities.Base
{
    public class PaginationEntity
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
