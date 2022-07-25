using static TradeCategory.Model.Enums;

namespace TradeCategory.Model
{
    public class Trade
    {
        public int Id { get; set; }

        public double Value { get; set; }

        public ClientSectorEnum Sector { get; set; }

        public RiskEnum RiskLevel { get; set; }
        
        //public RiskEnum RiskLevel => Classify();

        //LOWRISK: Trades with value less than 1,000,000 and client from Public Sector
        //MEDIUMRISK: Trades with value greater than 1,000,000 and client from Public Sector
        //HIGHRISK: Trades with value greater than 1,000,000 and client from Private Sector
        // private method to calculate the classification
        //private RiskEnum Classify()
        //{
        //    if (Value < 1000000 && Sector == ClientSectorEnum.Public)
        //        return RiskEnum.LOWRISK;

        //    if (Value > 1000000 && Sector == ClientSectorEnum.Public)
        //        return RiskEnum.MEDIUMRISK;

        //    if (Value > 1000000 && Sector == ClientSectorEnum.Privavte)
        //        return RiskEnum.HIGHRISK;
        //    else
        //        return RiskEnum.NONE;
        //}
    }
}
