using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_3.Classes
{
    public class NormHouseData
    {
        /* 28 attributes + 1 final attribute (salePrice) */
        public double MSZoning { get; set; }
        public double LotArea { get; set; }
        public double LandContour { get; set; }
        public double Utilities { get; set; }
        public double BldgType { get; set; }
        public double OverallQual { get; set; }
        public double YearBuilt { get; set; }
        public double ExterCond { get; set; }
        public double Foundation { get; set; }
        public double TotalBsmtSF { get; set; }
        public double Heating { get; set; }
        public double HeatingQC { get; set; }
        public double firstFlrSF { get; set; }
        public double secondFlrSF { get; set; }
        public double GrLivArea { get; set; }
        public double Bedroom { get; set; }
        public double Kitchen { get; set; }
        public double TotRmsAbvGrd { get; set; }
        public double GarageYrBlt { get; set; }
        public double GarageArea { get; set; }
        public double PavedDrive { get; set; }
        public double PoolArea { get; set; }
        public double PoolQC { get; set; }
        public double Fence { get; set; }
        public double MoSold { get; set; }
        public double YrSold { get; set; }
        public double SaleType { get; set; }
        public double SaleCondition { get; set; }

        // Final attribute:
        public double SalePrice { get; set; }
    }
}
