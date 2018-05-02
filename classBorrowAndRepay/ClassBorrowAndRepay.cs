using System;
using System.Collections.Generic;
using System.Text;

namespace classBorrowAndRepay
{
    class ClassBorrowAndRepay
    {
        public string Name;
        public int Money;

        public ClassBorrowAndRepay(string name, int money)
        {
            this.Name = name;
            this.Money = money;
        }

        public void borrow(ClassBorrowAndRepay lender, int money)
        {
            lender.Money += money;
            this.Money -= money;
        }
        public void repay(ClassBorrowAndRepay lender, int money)
        {
            this.Money += money;
            lender.Money -= money;
            
        }
    }
}
