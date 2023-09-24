using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
    internal class Reader {

        private string name;
        private LibraryCard card;
        private List<Book> books;

        public Reader() { }
        public Reader(string name) {
            this.name = name;
            this.books = new List<Book>();
        }

        public void AddBook(Book book) {
            books.Add(book);
        }

        public Book OutBook(string author, string name) {
            Book res = null;
            for (int i = 0; i < books.Count; i++) {
                if (books[i].getAuthor().Equals(author) && books[i].getName().Equals(name)) {
                    res = books[i];
                    books.RemoveAt(i);
                    break;
                }
            }
            return res;
        }

        public string getName() { return this.name; }
        public void setName(string name) { this.name = name;}
        public LibraryCard getCard() { return this.card;}
        public void setCard(LibraryCard card) { this.card = card; }

        public override string ToString() {
            string str = "";
            for (int i = 0; i < books.Count; i++) {
                str += books[i].ToString() + "\n";
            }
            return this.name + "\n" + this.card.ToString() + "\n" + str;
        }

    }
}
