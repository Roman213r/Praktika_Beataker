using System;
using System.Threading.Tasks;
using Plugin.InAppBilling;

namespace LogicApp.Services.Interfaces
{
    public interface IInAppBillingService
    {
        Task<bool> WasItemPurchased(string productId, ItemType itemType);
        Task<bool> PurchaseItem(string productId, ItemType itemType);
    }
}
