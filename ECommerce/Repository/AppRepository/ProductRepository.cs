using BaseRepository;
using DAL;
using Entity.AppModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.AppRepository
{
    public class ProductRepository:BaseRepository<Product>
    {
        private readonly DataContext DB;
        public ProductRepository(DataContext db):base(db)
        {
            DB = db;
        }
        public List<Product> GetAll()
        {
            return DB.Products.Include(x => x.Ratings).ToList();
        }
    }
}
