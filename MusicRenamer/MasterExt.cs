using D4DJ_Tools.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRenamer
{
    public class MusicMasterExt : MusicMaster
    {
        public UnitMaster Unit { get; private set; }

        public void FindMyUnit(Dictionary<int, UnitMaster> unitMasters)
        {
            Unit = unitMasters[__UnitPrimaryKey__];
        }
    }
}
