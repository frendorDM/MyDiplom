using System;
using System.Collections.Generic;
using System.Text;
using CreateNote.Core.Models;

namespace CreateNote.Data
{
    public interface IAnalisisInfoRepository
    {
        CountTestingDto GetCountFailedTesting(int id);
        CountTestingDto GetCountSuccessfulTesting(int id);
    }
}
