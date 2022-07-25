using TradeCategory.Model;
using static TradeCategory.Model.Enums;

namespace TradeCategory.Service.Interface
{
    public interface IProcessTrade
    {
        RiskEnum GetRisk(Trade trade);
    }
}
