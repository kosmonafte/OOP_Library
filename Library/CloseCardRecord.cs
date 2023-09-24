using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
    internal class CloseCardRecord : Record {

        public CloseCardRecord() : base() { }
        public CloseCardRecord(Book book) : base(book) {
            this.status = "Возвращено";
        }

        public override string ToString() {
            return this.status + "\t" + this.bookAuthor + "\t" + this.bookName + "\t" + this.date;
        }

    }
}
