using System;

namespace Bridge.AngularJS.Services
{
    /// <summary>
    /// The $http service is a core Angular service that facilitates
    /// communication with the remote HTTP servers via the browser's
    /// XMLHttpRequest object or via JSONP.
    /// </summary>
    [External]
    public class Http
    {
        // TODO: implement remaining stuff defined at: https://docs.angularjs.org/api/ng/service/$http
    }

    /// <summary>
    /// The interceptors are service factories that are registered with the
    /// $httpProvider by adding them to the $httpProvider.interceptors array.
    /// The factory is called and injected with dependencies (if specified)
    /// and returns the interceptor.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class Interceptors
    {
        /// <summary>
        /// Interceptors get called with a http config object. The function is
        /// free to modify the config object or create a new one. The function
        /// needs to return the config object directly, or a promise containing
        /// the config or a new config object.
        /// </summary>
        public Func<string, string> Request;

        /// <summary>
        /// Interceptor gets called when a previous interceptor threw an error
        /// or resolved with a rejection.
        /// </summary>
        public Func<object, string> RequestError;

        /// <summary>
        /// Interceptors get called with http response object. The function is
        /// free to modify the response object or create a new one. The
        /// function needs to return the response object directly, or as a
        /// promise containing the response or a new response object.
        /// </summary>
        public Func<string, string> Response;

        /// <summary>
        /// Interceptor gets called when a previous interceptor threw an error
        /// or resolved with a rejection.
        /// </summary>
        public Func<object, string> ResponseError;
    }
}