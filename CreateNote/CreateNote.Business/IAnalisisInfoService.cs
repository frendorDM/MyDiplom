using System;
using System.Collections.Generic;
using System.Text;
using CreateNote.Core.Models;

namespace CreateNote.Business
{
    public interface IAnalisisInfoService
    {
        CountTestingDto GetCountFailedTesting(int id);
        CountTestingDto GetCountSuccessfulTesting(int id); 
    }
}
