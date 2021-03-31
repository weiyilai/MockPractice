using MockPractice.Web.Models;
using MockPractice.Web.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MockPractice.Web.Service
{
    public class SampleService
    {
        ISampleRepository _iSampleRepository;

        public SampleService(ISampleRepository sampleRepository)
        {
            _iSampleRepository = sampleRepository;
        }

        public List<SampleModel> GetSample(int param)
        {
            var samples = _iSampleRepository.GetSample(param);

            // 假設有一個商業邏輯是大家不能知道會員的全名 只能知道 姓氏 + **
            foreach (var item in samples)
            {
                if (item.Name != null && item.Name.Length >= 1)
                {
                    item.Name = item.Name.Substring(0, 1) + "**";
                }
            }

            return samples;
        }
    }
}