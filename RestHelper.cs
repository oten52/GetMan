using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp2
{
    public class RestHelper
    {
        /// <summary>
        /// HttpSendAsync - Http Isteklerini gönderirir
        /// </summary>
        /// <param name="requestUrl"></param>
        /// <param name="headers"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> HttpSendAsync(PostmanRequestItem postmanRequestItem, CancellationToken ct = default)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {

                    // token yapılandırması
                    if (postmanRequestItem.Authorization != null)
                    {
                        if (postmanRequestItem.Authorization.AuthorizationType == AuthorizationTypeEnum.BearerToken)
                        {
                            httpClient.DefaultRequestHeaders.Add("Bearer", postmanRequestItem.Authorization.GetToken());
                        }
                        else if (postmanRequestItem.Authorization.AuthorizationType == AuthorizationTypeEnum.BasicAuth)
                        {
                            httpClient.DefaultRequestHeaders.Add("Basic", postmanRequestItem.Authorization.GetToken());
                        }
                    }

                    // request yapılandırması
                    HttpRequestMessage httpRequestMessage = new HttpRequestMessage(postmanRequestItem.HttpMethod, postmanRequestItem.Url);

                    // raw gönderimi
                    if (postmanRequestItem.BodyType == BodyTypeEnum.Raw)
                    {
                        httpRequestMessage.Content = new StringContent(postmanRequestItem.RawBody.Body, Encoding.UTF8, postmanRequestItem.RawBody.Type);
                    }

                    // binary gönderimi
                    if (postmanRequestItem.BodyType == BodyTypeEnum.Binary)
                    {
                        using (var multipartContent = new MultipartFormDataContent())
                        {
                            // Body ekleme
                            if (postmanRequestItem.BinaryBody.RawBody != null)
                            {
                                multipartContent.Add(new StringContent(postmanRequestItem.BinaryBody.RawBody.Body, Encoding.UTF8, postmanRequestItem.BinaryBody.RawBody.Type), "body");
                            }

                            // Dosya ekleme
                            if (!string.IsNullOrEmpty(postmanRequestItem.BinaryBody.Path) && File.Exists(postmanRequestItem.BinaryBody.Path))
                            {
                                var fileContent = new StreamContent(File.OpenRead(postmanRequestItem.BinaryBody.Path));
                                fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                                multipartContent.Add(fileContent, postmanRequestItem.BinaryBody.FileName, Path.GetFileName(postmanRequestItem.BinaryBody.Path));
                            }
                        }
                    }



                    return await httpClient.SendAsync(httpRequestMessage, default);
                }

            }
            catch (Exception ex)
            {
                HttpResponseMessage httpResponseMessage = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
                httpResponseMessage.Content = new StringContent(ex.Message);

                return httpResponseMessage;
            }
        }
    }
}
