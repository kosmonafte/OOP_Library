using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
    internal class Book {

        protected string author;
        protected string name;

        public Book() {
            this.author = null;
            this.name = null;
        }

        public Book(string author, string name) {
            this.author = author;
            this.name = name;
        }

        public string getName() { return this.name; }

        public void setName(string name) { this.name = name; }

        public string getAuthor() { return this.author; }

        public void setAuthor(string author) { this.author = author; }

        public override string ToString() {
            return this.author + "--" + this.name;
        }

    }
}
