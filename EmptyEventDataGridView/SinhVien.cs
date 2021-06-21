using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyEventDataGridView
{
    public class SinhVien
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public SinhVien()
        {

        }
        public SinhVien(int _id,string _name)
        {
            ID = _id;
            Name = _name;
        }
    }
}
