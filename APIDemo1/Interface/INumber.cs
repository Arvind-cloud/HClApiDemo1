using APIDemo.Service.Models;
using APIDemo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDemo1.Interface
{
    public interface INumber:IDisposable
    {
        int GetDetails(NumberEntity item);
    }
}
