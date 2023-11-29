using AutoMapper;
using Newtonsoft.Json;
using Task1.DbContexts;
using Task1.Entities;
using Task1.Models;

namespace Task1.Services
{
    public class DbService
    {
        private readonly DbInfo _dbContext;
        private readonly IMapper _mapper;

        public DbService(DbInfo dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void WriteToDatabase(JsonClass jsonClass)
        {
            var dbEntity = _mapper.Map<DbClass>(jsonClass);

            _dbContext.DbClasses.Add(dbEntity);
            _dbContext.SaveChanges();
        }
    }
}
