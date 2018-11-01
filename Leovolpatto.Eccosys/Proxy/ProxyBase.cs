using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Leovolpatto.Eccosys.Proxy
{
    /// <summary>
    /// Proxy base for Eccosys (erp)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Leovolpatto.Eccosys.Proxy.IModelProxy{T}" />
    public abstract class ProxyBase<T> : IModelProxy<T>
    {
        protected HttpClient Client { get; set; }

        public ProxyBase(HttpClient client)
        {
            this.Client = client;
        }

        /// <summary>
        /// Gets the endpoint.
        /// </summary>
        /// <remarks>
        /// The endpoint is composed of the root URL + the method 
        /// </remarks>
        /// <value>
        /// The endpoint.
        /// </value>
        protected abstract string Endpoint { get; }

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public virtual IModelProxyResult<T> GetItem(GetByIdRequest request)
        {
            HttpResponseMessage httpResponse = this.Client.GetAsync(String.Format("{0}/{1}", this.Endpoint, request.id.ToString())).Result;
            T result = default(T);
            if (httpResponse.IsSuccessStatusCode)
            {
                //var xx = httpResponse.Content.ReadAsStringAsync().Result;
                //JArray a = JArray.Parse(xx);

                var listRes = httpResponse.Content.ReadAsAsync<List<T>>().Result;
                result = listRes[0];
            }
            return new Response<T>()
            {
                IsSuccess = httpResponse.IsSuccessStatusCode,
                Data = result
            };
        }


        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public virtual IModelProxyResult<List<T>> GetItems(Request request)
        {
            HttpResponseMessage httpResponse = this.Client.GetAsync(this.Endpoint + request.GetParametersString()).Result;
            List<T> resultList = null;
            if (httpResponse.IsSuccessStatusCode)
            {
                resultList = httpResponse.Content.ReadAsAsync<List<T>>().Result;
            }

            Response<List<T>> response = new Response<List<T>>()
            {
                IsSuccess = httpResponse.IsSuccessStatusCode,
                Data = resultList
            };

            return response;
        }

        /// <summary>
        /// Posts the items.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public virtual IModelProxyResult<DefaultPostResponse> PostItems(PayloadRequest<List<T>> request)
        {
            HttpResponseMessage httpResponse = this.Client.PostAsJsonAsync(this.Endpoint, request.Body).Result;
            string res = httpResponse.Content.ReadAsStringAsync().Result;
            try
            {
                var resultData = httpResponse.Content.ReadAsAsync<DefaultPostResponse>().Result;
                return new Response<DefaultPostResponse>()
                {
                    IsSuccess = httpResponse.IsSuccessStatusCode,
                    Data = resultData
                };
            }
            catch(Exception exp)
            {
                return new Response<DefaultPostResponse>()
                {
                    IsSuccess = false,
                    Data = null
                };
            }
        }

        /// <summary>
        /// Puts the items.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public virtual IModelProxyResult<DefaultPostResponse> PutItems(PayloadRequest<List<T>> request)
        {
            HttpResponseMessage httpResponse = this.Client.PutAsJsonAsync(this.Endpoint, request.Body).Result;
            string res = httpResponse.Content.ReadAsStringAsync().Result;
            try
            {   
                var resultData = httpResponse.Content.ReadAsAsync<Result>().Result;
                var defaultPostResp = new DefaultPostResponse();
                defaultPostResp.result = resultData;

                return new Response<DefaultPostResponse>()
                {
                    IsSuccess = httpResponse.IsSuccessStatusCode,
                    Data = defaultPostResp
                };
            }
            catch(Exception exp)
            {
                return new Response<DefaultPostResponse>()
                {
                    IsSuccess = false,
                    Data = null
                };
            }
        }

        /// <summary>
        /// Deletes the item.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public virtual IModelProxyResult<T> DeleteItem(DeleteRequest request)
        {
            HttpResponseMessage httpResponse = this.Client.DeleteAsync(String.Format("{0}/{1}", this.Endpoint, request.id.ToString())).Result;

            return new Response<T>()
            {
                IsSuccess = httpResponse.IsSuccessStatusCode,
                Data = default(T)
            };

        }
    }
}