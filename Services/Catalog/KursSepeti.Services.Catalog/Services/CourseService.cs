using AutoMapper;
using KursSepeti.Services.Catalog.Models;
using KursSepeti.Services.Catalog.Settings;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KursSepeti.Services.Catalog.Services
{
    internal class CourseService
    {
        private readonly IMongoCollection<Course> _courseCollection;

        private readonly IMapper _mapper;

        public CourseService(IMapper mapper,IDatabaseSettings databaseSettings)
        {
            var client = new MongoClient(databaseSettings.ConnectionString);

            var database = client.GetDatabase(databaseSettings.DatabaseName);

            _courseCollection = database.GetCollection<Course>(databaseSettings.CourseCollectionName);
            _mapper = mapper;
        }
    }
}
