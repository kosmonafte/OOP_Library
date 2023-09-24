using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library {
    internal class Journal {

        List<Record> records;

        public Journal() {
            this.records = new List<Record>();
        }

        public void AddRecord(Record record) {
            records.Add(record);
        }

        public override string ToString() {
            string str = "";
            for (int i = 0; i < records.Count; i++) {
                str += records[i].ToString() + "\t";
            }
            
            return str;
        }

        public int getCount() {
            return records.Count;
        }

        public Record GetRecord(int index) {
            Record record = records[index];
            return record;
        }

    }
}
