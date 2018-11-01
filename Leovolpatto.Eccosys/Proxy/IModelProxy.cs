using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Leovolpatto.Eccosys.Proxy
{
    public interface IModelProxy<T>
    {
        IModelProxyResult<T> GetItem(GetByIdRequest request);
        IModelProxyResult<List<T>> GetItems(Request request);
        IModelProxyResult<DefaultPostResponse> PostItems(PayloadRequest<List<T>> request);
        IModelProxyResult<DefaultPostResponse> PutItems(PayloadRequest<List<T>> request);
        IModelProxyResult<T> DeleteItem(DeleteRequest request);
    }

    public interface IModelProxyResult<T>
    {
        bool IsSuccess { get; set; }
        T Data { get; set; }
    }

}
