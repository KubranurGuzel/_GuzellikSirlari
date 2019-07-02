using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace _GuzellikSirlari.Abstract
{
    public interface IDataBusiness<T> where T : class
    {
        void InsertData(T data);
        void UpdateData(T data);
        void DeleteData(T data);
        List<T> ListData();
        T Sec(int id);
    }
}