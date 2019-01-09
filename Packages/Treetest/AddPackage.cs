using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treetest
{
    class AddPackage:myConn
    {
        int PackageId;
        string PkgName;
        DateTime PkgStartDate;
        DateTime PkgEndDate;
        string PkgDesc;
        decimal PkgBasePrice;
        decimal PkgAgencyCommission;

        public void SetProperties(int PkgId, string pkgName, DateTime pkgStart, DateTime pkgEnd, string desc, decimal bPrice, decimal agencyComm)
        {



            PackageId = PkgId;
            PkgName = pkgName;
            PkgStartDate = pkgStart;
            PkgEndDate = pkgEnd;
            PkgDesc = desc;
            PkgBasePrice = bPrice;
            PkgAgencyCommission = agencyComm;



        }

        public bool isPkgCreated(string query)
        {
            bool isCreated = false;
            string sql = query;
            if (AddRecord(sql))
            {
                isCreated = true;
            }
            return isCreated;

        }

       

    }
}
