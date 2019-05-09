using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVM
{
    class PaymentView
    {
        //this
        public void PayCheck()
        {
            //if(usertotal == FinalTotal)
            //{
            //    ReceiptView.
            //}
            ReceiptView.PrintReciept(VendingMachine.PurchasedItems);
        }

        public void PayCredit()
        {
            ReceiptView.PrintReciept(VendingMachine.PurchasedItems);
        }

        public void PayCash()
        {
            ReceiptView.PrintReciept(VendingMachine.PurchasedItems);
        }
    }
}
