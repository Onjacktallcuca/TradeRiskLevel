using TradeCategory.Model;
using TradeCategory.Service.Interface;
using static TradeCategory.Model.Enums;

namespace TradeCategory.Service
{
    internal class ProcessTrade : IProcessTrade
    {

        //LOWRISK: Trades with value less than 1,000,000 and client from Public Sector
        //MEDIUMRISK: Trades with value greater than 1,000,000 and client from Public Sector
        //HIGHRISK: Trades with value greater than 1,000,000 and client from Private Sector
        // private method to calculate the classification

        public RiskEnum GetRisk(Trade trade)
        {
            if (trade.Value < 1000000 && trade.Sector == ClientSectorEnum.Public)
                return RiskEnum.LOWRISK;

            if (trade.Value > 1000000 && trade.Sector == ClientSectorEnum.Public)
                return RiskEnum.MEDIUMRISK;

            if (trade.Value > 1000000 && trade.Sector == ClientSectorEnum.Privavte)
                return RiskEnum.HIGHRISK;
            else
                return RiskEnum.NONE;
        }
    }
}
