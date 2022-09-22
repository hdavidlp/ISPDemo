using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ReferenceBook: ILibraryItem
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }  
        public int Pages { get; set; }
        public int CheckOutDurationInDays { get; set; }
        public string Borrower { get; set; }
        public DateTime BorrowDate { get; set; }

        void ILibraryItem.CheckIn()
        {
            throw new NotImplementedException();
        }

        void ILibraryItem.CheckOut(string borrower)
        {
            throw new NotImplementedException();
        }

        DateTime ILibraryItem.GetDueDate()
        {
            throw new NotImplementedException();
        }
    }
}
