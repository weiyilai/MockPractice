using MockPractice.Web.Models;
using System.Collections.Generic;

namespace MockPractice.Web.Repository
{
    public interface ISampleRepository
    {
        List<SampleModel> GetSample(int param);
    }
}