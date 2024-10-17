using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProjectStudentManagment
{
    internal interface IStorageServices
    {
        void Save( Student student );
        Student GetByRegNUmber(string regNUmber );
        void DeleteByRegNUmber( string regNUmber );
    }
}
