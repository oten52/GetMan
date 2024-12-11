using System.ComponentModel;
using System.Text;

namespace OtenTool.PostmanCore.Items
{
    public class PostmanRequestItem
    {
        public HttpMethod HttpMethod { get; set; }
        public string Url { get; set; }
        public List<Param> Params { get; set; }
        public Authorization Authorization { get; set; }
        public List<Header> Headers { get; set; }
        public BodyTypeEnum BodyType { get; set; }
        public RawBody RawBody { get; set; }
        public BinaryBody BinaryBody { get; set; }

    }

    public class BinaryBody
    {
        public RawBody RawBody { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }
    }

    public class RawBody
    {
        public string Type { get; set; } = "application/json";
        public string Body { get; set; }
    }

    public enum BodyTypeEnum
    {
        [Description("None")]
        None = 0,
        [Description("From Data")]
        FromData,
        [Description("Url Encoded")]
        UrlEncoded,
        [Description("Raw")]
        Raw,
        [Description("Binary")]
        Binary
    }

    public class Authorization
    {
        public AuthorizationTypeEnum AuthorizationType { get; set; }

        public string Value { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string GetToken()
        {
            if (AuthorizationType == AuthorizationTypeEnum.BasicAuth)
            {
                Value = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{UserName}:{Password}")); ;
            }

            return Value;
        }
    }
    public enum AuthorizationTypeEnum
    {
        [Description("Bearer Token")]
        BearerToken = 0,
        [Description("Basic Auth")]
        BasicAuth
    }

    public class Param
    {
        public bool IsChecked { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
    }
    public class Header
    {
        public bool IsChecked { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
    }
}
