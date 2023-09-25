using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBestPractices
{
    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;
        
        public DapperProductRepository(IDbConnection conn)
        {
            _conn = conn;   
        }
        public IEnumerable<products> GetAllProducts()
        {
            return _conn.Query<products>("SELECT * FROM products;");
        }
    }
}
