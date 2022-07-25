using TradeCategory.Model;
using TradeCategory.Service;
using static TradeCategory.Model.Enums;

namespace TradeCategory.Controller
{
    class TradeController
    {
        private readonly ProcessTrade service;
        
        public TradeController()
        {
            service = new ProcessTrade();
        }
        
        public RiskEnum GetRisk(Trade trade)
        {
            return service.GetRisk(trade);
        }
    }
}
