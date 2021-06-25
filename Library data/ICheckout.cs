using LibraryData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
  public interface ICheckout
    {
        void Add(Checkout newCheckout);
       
       
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);
        IEnumerable<Checkout> GetAll();
        IEnumerable<Hold> GetCurrentHolds(int id);
       
        
        Checkout GetById(int checkoutid);
        Checkout GetLatestCheckout(int assetId);
        string GetCurrentCheckoutPatron(int assetId);
        string GetCurrentHoldPatronName(int holdId);
        DateTime GetCurrentHoldPlaced(int holdId);
        bool IsCheckedOut(int id);


        void CheckOutItem(int assetId, int libraryCardId);
        void CheckInItem(int assetId);
        void PlaceHold(int assetId, int librrayCardId);
        void MarkLost(int assetId);
        void MarkFound(int assetId);


       





  }
}
