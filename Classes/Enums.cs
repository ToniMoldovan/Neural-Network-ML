using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_3.Classes
{
    public class Enums
    {
        public enum MSZoning
        {
            A,      //Agriculture
            C,      //Commercial
            FV,     //Floating Village Residential
            I,      //Industrial
            RH,     //Residential High Density
            RL,     //Residential Low Density
            RP,     //Residential Low Density Park
            RM,     //Residential Medium Density
        }

        public enum LandContour
        {
            Lvl,     //Near Flat/Level
            Bnk,     //Banked - Quick and significant rise from street grade to building
            HLS,     //Hillside - Significant slope from side to side
            Low,     //Depression
        }

        public enum Utilities
        {
            AllPub,  //All public Utilities(E, G, W,& S)
            NoSewr,  //Electricity, Gas, and Water(Septic Tank)
            NoSeWa,  //Electricity and Gas Only
            ELO,    //Electricity only
        }

        public enum BldgType
        {
            _1Fam,   //Single-family Detached	
            _2FmCon, //Two-family Conversion; originally built as one-family dwelling
            Duplex,   //Duplex
            TwnhsE,  //Townhouse End Unit
            TwnhsI,  //Townhouse Inside Unit
        }

        public enum ExterCond
        {
            Ex,  // Excellent
            Gd,  // Good
            TA,  // Average/Typical
            Fa,  // Fair
            Po,  // Poor
        }

        public enum Foundation
        {
           BrkTil,   //Brick & Tile
           CBlock,   //Cinder Block
           PConc,   //Poured Contrete
           Slab,   //Slab
           Stone,   //Stone
           Wood,   //Wood
        }

        public enum Heating
        {
           Floor,    //Floor Furnace
           GasA,    //Gas forced warm air furnace
           GasW,    //Gas hot water or steam heat
           Grav,    //Gravity furnace
           OthW,    //Hot water or steam heat other than gas
           Wall,    //Wall furnace
       }

        public enum HeatingQC
        {
           Ex,   //Excellent
           Gd,   //Good
           TA,   //Average/Typical
           Fa,   //Fair
           Po,   //Poor
        }

        public enum PavedDrive
        {
           Y,    //Paved
           P,    //Partial Pavement
           N,    //Dirt/Gravel
        }

        public enum PoolQC
        {
           Ex,   //Excellent
           Gd,   //Good
           TA,   //Average/Typical
           Fa,   //Fair
           NA,   //No Pool
        }

        public enum Fence
        {
            GdPrv,	//Good Privacy
            MnPrv,	//Minimum Privacy
            GdWo,	//Good Wood
            MnWw,	//Minimum Wood/Wire
            NA,      //No Fence
        }

        public enum SaleType
        {
           WD,    //Warranty Deed - Conventional
           CWD,    //Warranty Deed - Cash
           VWD,    //Warranty Deed - VA Loan
           New,    //Home just constructed and sold
           COD,    //Court Officer Deed/Estate
           Con,    //Contract 15% Down payment regular terms
           ConLw,    //Contract Low Down payment and low interest
           ConLI,    //Contract Low Interest
           ConLD,    //Contract Low Down
           Oth,    //Other
        }

        public enum SaleCondition
        {
            Normal,     //Normal Sale
            Abnorml,     //Abnormal Sale -  trade, foreclosure, short sale
            AdjLand,     //Adjoining Land Purchase
            Alloca,     //Allocation - two linked properties with separate deeds, typically condo with a garage unit
            Family,     //Sale between family members
            Partial,     //Home was not completed when last assessed(associated with New Homes)
        }
    }
}
            
