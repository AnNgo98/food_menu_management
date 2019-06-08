using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class DataProvider
    {
        // tạo ins duy nhất trong 
        private static DataProvider _ins;

        // public ins 
        public static DataProvider Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new DataProvider();
                return _ins;
            }
            set
            {
                _ins = value;
            }
        }

        public DAL db { get; set; }
        // new ins
        private DataProvider()
        {
            db = new DAL();
        }
    }
}
