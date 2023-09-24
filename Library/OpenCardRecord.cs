using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
    internal class OpenCardRecord : Record {

        private DateTime retDate;

        public OpenCardRecord() : base() { }
        public OpenCardRecord(Book book) : base(book) {
            this.retDate = DateTime.Now.AddDays(10);
            this.status = "Получено";
        }

        public override string ToString() {
            return this.status + "\t" + this.bookAuthor + "\t" + this.bookName + "\t" + this.date + "\t" + this.retDate;
        }

    }
}
