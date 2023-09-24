using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
    internal class LibraryCard {

        private int number;
        private string readerName;
        private List<Record> records;
        
        public LibraryCard() { }
        public LibraryCard(int number, string readerName) {
            this.number = number;
            this.readerName = readerName;
            this.records = new List<Record>();
        }

        public void AddRecord(Record record) {
            records.Add(record);
        }

        public string getName() {
            return this.readerName;
        }

        public void setNumber(int number) { this.number = number; }
        public int getNumber() { return this.number;}

        public override string ToString() {
            string str = "";
            str += this.number + "\t" + this.readerName + "\n";
            for (int i = 0; i < records.Count; i++) {
                str += records[i].ToString() + "\n";
            }
            return str;
        }

    }
}
