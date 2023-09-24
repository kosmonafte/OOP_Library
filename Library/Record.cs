using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
    internal abstract class Record {

        protected string bookAuthor;
        protected string bookName;
        protected DateTime date;
        protected string status;

        public Record() {
            this.bookAuthor = "tmpName";
            this.bookName = "tmpBookName";
            this.date = DateTime.Now;
        }

        public Record(Book book) {
            this.bookAuthor = book.getAuthor();
            this.bookName = book.getName();
            this.date = DateTime.Now;
        }

        //public void setBookAuthor(string name) {  
        //    this.bookAuthor = name; 
        //}

        //public string getBookAuthor() {
        //    return this.bookAuthor;
        //}

        //public void setBookName(string bookName) {
        //    this.bookName = bookName;
        //}

        //public string getBookName() {
        //    return this.bookName;
        //}

    }
}
