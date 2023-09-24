using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
    internal class CloseJournalRecord : Record {

        private string name;
        private int cardNumber;

        public CloseJournalRecord() : base() { }
        public CloseJournalRecord(Book book, Reader reader) : base(book) {
            this.name = reader.getName();
            this.cardNumber = reader.getCard().getNumber();
            this.status = "Возвращено";
        }

        public override string ToString() {
            return this.status + "\t" + this.name + "\t" + this.cardNumber + "\t" + this.bookAuthor + "\t" + this.bookName + "\t" + this.date;
        }

    }
}
