using LocalStorage;
using PortfolioManagerClient.Models;
using System;

namespace PortfolioManagerClient.Infrastructure
{
    public static class Mapper
    {
        public static PortfolioItemViewModel ToViewModel(this PortfolioItemDAL dalItem)
        {
            return new PortfolioItemViewModel()
            {
                ItemId = dalItem.ItemId,
                UserId = dalItem.UserId,
                SharesNumber = dalItem.SharesNumber,
                Symbol = dalItem.Symbol
            };
        }

        public static PortfolioItemDAL ToDALModel(this PortfolioItemViewModel vm)
        {
            return new PortfolioItemDAL()
            {
                ItemId = vm.ItemId,
                UserId = vm.UserId,
                SharesNumber = vm.SharesNumber,
                Symbol = vm.Symbol
            };
        }
    }
}