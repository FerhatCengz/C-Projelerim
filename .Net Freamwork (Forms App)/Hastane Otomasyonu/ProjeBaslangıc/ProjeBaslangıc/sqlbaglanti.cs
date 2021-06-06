using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ProjeBaslangıc
{
    class sqlbaglanti
    {

        public SqlConnection baglanti()
        {

            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-H32U3ONQ;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }


    }

}
