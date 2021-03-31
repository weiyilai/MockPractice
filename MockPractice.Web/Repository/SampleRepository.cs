using MockPractice.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MockPractice.Web.Repository
{
    public class SampleRepository : ISampleRepository
    {
        public List<SampleModel> GetSample(int param)
        {
            // 為了方便講解 (否則這些資料應該是從 DB 取出)
            var source = new List<SampleModel>
            {
                new SampleModel { Id = 1, Name = "陳大寶", Birthday = DateTime.Parse("2001/1/1") },
                new SampleModel { Id = 2, Name = "林小寶", Birthday = DateTime.Parse("2001/2/1") },
                new SampleModel { Id = 3, Name = "王聰明", Birthday = DateTime.Parse("2001/3/1") },
            };

            return source.Where(q => q.Id == param).ToList();
        }
    }
}