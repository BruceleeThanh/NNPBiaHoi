using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;

namespace BussinessLogic {
    public class KhachHangBO {
        private DatabaseDA aDatabaseDA = new DatabaseDA();

        public List<KhachHang> SelectAll() {
            try {
                return aDatabaseDA.KhachHang.OrderByDescending(b => b.Ma).ToList();
            }
            catch(Exception ex) {
                throw new Exception("KhachHangBO.Select_All:" + ex.ToString());
            }
            
        }

    }
}
