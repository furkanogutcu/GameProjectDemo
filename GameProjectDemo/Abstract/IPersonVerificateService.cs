using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract
{
    interface IPersonVerificateService
    {
        bool Verification(IPerson person);
    }
}
