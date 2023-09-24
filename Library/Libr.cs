using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
    internal class Libr {

        private List<Book> books;
        private List<LibraryCard> cards;
        private Journal journal;

        public Libr() {
            books = new List<Book>();
            cards = new List<LibraryCard>();
            journal = new Journal();
        }

        public void AddBook(Book book) {
            books.Add(book);
        }

        public void DelBook(int index) {
            books.RemoveAt(index);
        }

        public void IssueABook(string author, string name, Reader reader) {
            for (int i = 0; i < books.Count; i++) {
                if (books[i].getAuthor().Equals(author) && books[i].getName().Equals(name)) {
                    reader.AddBook(books[i]);
                    this.journal.AddRecord(new OpenJournalRecord(books[i], reader));
                    reader.getCard().AddRecord(new OpenCardRecord(books[i]));
                    this.DelBook(i);
                    break;
                }
            }
        }

        public void retBook(string author, string name, Reader reader) {
            Book book = reader.OutBook(author, name);
            journal.AddRecord(new CloseJournalRecord(book, reader));
            reader.getCard().AddRecord(new CloseCardRecord(book));
            this.AddBook(book);
        }

        public LibraryCard CreateCard(string name) {
            LibraryCard card = new LibraryCard(this.cards.Count, name);
            this.cards.Add(card);
            return card;
        }

        public override string ToString() {
            string str = "";
            str += "Список книг:\n";
            for (int i = 0; i < books.Count; i++) {
                str += books[i].ToString() + "\n";
            }
            str += "Список читательских билетов:\n";
            for (int i = 0; i < cards.Count; i++) {
                str += cards[i].getNumber() + "\t" + cards[i].getName() + "\n";
            }
            str += "Записи в журнале:\n";
            for (int i = 0; i < journal.getCount(); i++) {
                str += journal.GetRecord(i).ToString() + "\n";
            }
            return str;
        }

    }
}
