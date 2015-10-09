using System;

namespace Bridge.AngularJS.Services
{
    [Ignore]
    public class Http<T>
    {
        public Http()
        {
        }

        public Promise<T> Get(string url)
        {
            return null;
        }
    }

    [Ignore]
    [ObjectLiteral]
    public class Interceptors
    {
        public Func<string, string> Request;
        public Func<object, string> RequestError;
        public Func<string, string> Response;
        public Func<object, string> ResponseError;
    }
}

