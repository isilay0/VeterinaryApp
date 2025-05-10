using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryApp.Model;

namespace VeterinaryApp.Http
{
    public interface IHttpApi
    {
        Task<T> Get<T>(string ep);
        Task<TRes> Post<TBody, TRes>(string ep, TBody body);
        Task<TRes> Delete<TRes>(string ep);
        Task<TRes> Put<TBody, TRes>(string ep, TBody body);
        
    }
}

