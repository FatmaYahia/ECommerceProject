using BaseRepository;
using DAL;
using Entity.AppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.AppRepository
{
    public class ProductRatingsRepository:BaseRepository<ProductRating>
    {
        private readonly DataContext DB;
        public ProductRatingsRepository(DataContext db):base(db)
        {
            DB = db;
        }
    }
}
