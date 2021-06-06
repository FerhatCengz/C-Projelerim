using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace E_Okul
{
    class Sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-H32U3ONQ;Initial Catalog=EScholl;Integrated Security=True");
            baglan.Open();
            return baglan;
        }


    }
}
