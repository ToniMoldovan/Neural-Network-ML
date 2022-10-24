using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_3.Classes
{
    public class RawHouseData
    {
        /* 28 attributes + 1 final attribute (salePrice) */
        public string MSZoning { get; set; }
        public string LotArea { get; set; }
        public string LandContour { get; set; }
        public string Utilities { get; set; }
        public string BldgType { get; set; }
        public string OverallQual { get; set; }
        public string YearBuilt { get; set; }
        public string ExterCond { get; set; }
        public string Foundation { get; set; }
        public string TotalBsmtSF { get; set; }
        public string Heating { get; set; }
        public string HeatingQC { get; set; }
        public string firstFlrSF { get; set; }
        public string secondFlrSF { get; set; }
        public string GrLivArea { get; set; }
        public string Bedroom { get; set; }
        public string Kitchen { get; set; }
        public string TotRmsAbvGrd { get; set; }
        public string GarageYrBlt { get; set; }
        public string GarageArea { get; set; }
        public string PavedDrive { get; set; }
        public string PoolArea { get; set; }
        public string PoolQC { get; set; }
        public string Fence { get; set; }
        public string MoSold { get; set; }
        public string YrSold { get; set; }
        public string SaleType { get; set; }
        public string SaleCondition { get; set; }
        
        // Final attribute:
        public string SalePrice { get; set; }
    }
}
