using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstract.Managers
{
    class GamerVerificateManager:IPersonVerificateService
    {
        public bool Verification(IPerson person)
        {
            if (person.LastName == "Ogutcu")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
