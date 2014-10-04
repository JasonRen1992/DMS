using DMS.IBLL;
using DMS.IDAL;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.BLL
{
    public class HomeBLL : IHomeBLL
    {
        [Dependency]
        public IHomeRepository HomeRepository { get; set; }
    }
}
