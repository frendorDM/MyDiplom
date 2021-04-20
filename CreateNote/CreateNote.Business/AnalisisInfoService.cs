using System;
using System.Collections.Generic;
using System.Text;
using CreateNote.Core.Models;
using CreateNote.Data;

namespace CreateNote.Business
{
    public class AnalisisInfoService
    {
        private IAnalisisInfoRepository _analisisInfoRepository;

        public AnalisisInfoService
            (
            IAnalisisInfoRepository analisisInfoRepository
            )
        {
            _analisisInfoRepository = analisisInfoRepository;
        }
        public CountTestingDto GetCountFailedTesting(int id) 
        {
            return _analisisInfoRepository.GetCountFailedTesting(id);
        }
        public CountTestingDto GetCountSuccessfulTesting(int id)
        {
            return _analisisInfoRepository.GetCountSuccessfulTesting(id);
        }
    }
}
