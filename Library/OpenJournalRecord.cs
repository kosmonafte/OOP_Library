using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Library {
    internal class OpenJournalRecord : Record {

        private DateTime retDate;
        private int cardNumber;
        private string readerName;

        public OpenJournalRecord() : base() {
            this.readerName = "tmpReader";
            this.cardNumber = 999999999;
            retDate = DateTime.Now.AddDays(10);
        }

        public OpenJournalRecord(Book book, Reader reader) : base(book) {
            this.status = "Выдано";
            this.retDate = this.date.AddDays(10);
            this.cardNumber = reader.getCard().getNumber();
            this.readerName = reader.getName();
        }

        public override string ToString() {
            return this.status + "\t" + this.readerName + "\t" + this.cardNumber + "\t" + this.bookAuthor + "\t" + this.bookName + "\t" + this.date + "\t" + this.retDate;
        }

    }
}
