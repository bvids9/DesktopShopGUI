using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace ItemClassLibrary
{
    public class SqliteDataAccess
    {
        public static List<Product> loadProducts()
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                var output = cnn.Query<Product>("select * from ProductTable", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void saveProduct(Product product)
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Execute("insert into ProductTable (Item, Category, Price) values (@Item, @Category, @Price)", product);
            }
        }

        public static void deleteProduct(Product product)
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Execute("delete from ProductTable where (Item=@Item)", product) ;
            }
        }

        private static string loadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }


    }
}
