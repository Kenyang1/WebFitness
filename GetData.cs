using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace fitness
{
    internal class GetData
    {
        public string getAcc()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("fitnessDB")))
            {
                return connection.Query<String>("Select * from Account").ToString();
            }
    }
    }
}
