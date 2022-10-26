using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_3.Classes
{
    public class Worker
    {
        public List<NormHouseData> ConvertRawData(List<RawHouseData> data)
        {
            List<NormHouseData> result = new List<NormHouseData>();

            foreach (RawHouseData item in data)
            {
                NormHouseData tempData = new NormHouseData
                {
                    MSZoning = Convert.ToDouble(Enum.Parse(typeof(Enums.MSZoning), item.MSZoning)),
                    LotArea = Convert.ToDouble(item.LotArea),
                    LandContour = Convert.ToDouble(Enum.Parse(typeof(Enums.LandContour), item.LandContour)),
                    Utilities = Convert.ToDouble(Enum.Parse(typeof(Enums.Utilities), item.Utilities)),
                    BldgType = Convert.ToDouble(Enum.Parse(typeof(Enums.BldgType), item.BldgType)),
                    OverallQual = Convert.ToDouble(item.OverallQual),
                    YearBuilt = Convert.ToDouble(item.YearBuilt),
                    ExterCond = Convert.ToDouble(Enum.Parse(typeof(Enums.ExterCond), item.ExterCond)),
                    Foundation = Convert.ToDouble(Enum.Parse(typeof(Enums.Foundation), item.Foundation)),
                    TotalBsmtSF = Convert.ToDouble(item.TotalBsmtSF),
                    Heating = Convert.ToDouble(Enum.Parse(typeof(Enums.Heating), item.Heating)),
                    HeatingQC = Convert.ToDouble(Enum.Parse(typeof(Enums.HeatingQC), item.HeatingQC)),
                    firstFlrSF = Convert.ToDouble(item.firstFlrSF),
                    secondFlrSF = Convert.ToDouble(item.secondFlrSF),
                    GrLivArea = Convert.ToDouble(item.GrLivArea),
                    Bedroom = Convert.ToDouble(item.Bedroom),
                    Kitchen = Convert.ToDouble(item.Kitchen),
                    TotRmsAbvGrd = Convert.ToDouble(item.TotRmsAbvGrd),
                    GarageYrBlt = Convert.ToDouble(item.GarageYrBlt),
                    GarageArea = Convert.ToDouble(item.GarageArea),
                    PavedDrive = Convert.ToDouble(Enum.Parse(typeof(Enums.PavedDrive), item.PavedDrive)),
                    PoolArea = Convert.ToDouble(item.PoolArea),
                    PoolQC = Convert.ToDouble(Enum.Parse(typeof(Enums.PoolQC), item.PoolQC)),
                    Fence = Convert.ToDouble(Enum.Parse(typeof(Enums.Fence), item.Fence)),
                    MoSold = Convert.ToDouble(item.MoSold),
                    YrSold = Convert.ToDouble(item.YrSold),
                    SaleType = Convert.ToDouble(Enum.Parse(typeof(Enums.SaleType), item.SaleType)),
                    SaleCondition = Convert.ToDouble(Enum.Parse(typeof(Enums.SaleCondition), item.SaleCondition)),
                    SalePrice = Convert.ToDouble(item.SalePrice)
                };

                result.Add(tempData);
            }

            return result;
        }
    
        public List<NormHouseData> NormalizeData(List<NormHouseData> convertedData)
        {
            PropertyInfo[] properties = typeof(NormHouseData).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                var (max, min) = GetMinMax(property, convertedData);
                foreach (var data in convertedData)
                {
                    double value = (double)property.GetValue(data, null);
                    property.SetValue(data, (value - min) / (max - min));
                }
            }

            return convertedData;
        }

        public (double max, double min) GetMinMax(PropertyInfo property, List<NormHouseData> convertedData)
        {
            double min = (double)property.GetValue(convertedData[0], null);
            double max = (double)property.GetValue(convertedData[0], null);

            foreach (var data in convertedData)
            {
                double value = (double)property.GetValue(data, null);
                if (min > value) min = value;
                if (value > max) max = value;
            }

            return (max, min);
        }

    }
}
