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
    /// $http service returns a slightly different promise with Success()
    /// and Error() chainings.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [External]
    public class HttpPromise<T> : Promise<T>
    {
        /// <summary>
        /// Shorthand for Then(callback, null, null).
        /// </summary>
        /// <param name="callback">Callback function called on success.</param>
        /// <returns>$http Service promise.</returns>
        public extern HttpPromise<T> Success(Func<T> callback);

        /// <summary>
        /// Alias for Catch(callback).
        /// </summary>
        /// <param name="callback">Callback function called on error.</param>
        /// <returns>$http Service promise.</returns>
        public extern HttpPromise<T> Error(Func<T> callback);

        /// <summary>
        /// Regardless of when the promise was or will be resolved or rejected,
        /// 'Then' calls one of the success or error callbacks asynchronously
        /// as soon as the result is available. The callbacks are called with a
        /// single argument: the result or rejection reason. Additionally, the
        /// notify callback may be called zero or more times to provide a
        /// progress indication, before the promise is resolved or rejected.
        /// </summary>
        /// <param name="successCallback">Called on success.</param>
        /// <param name="errorCallback">Called on error.</param>
        /// <param name="notifyCallback">Called zero or more times.</param>
        /// <returns>
        /// A new promise which is resolved or rejected via the return value of
        /// the successCallback, errorCallback (unless that value is a promise,
        /// in which case it is resolved with the value which is resolved in
        /// that promise using promise chaining). It also notifies via the
        /// return value of the notifyCallback method. The promise cannot be
        /// resolved or rejected from the notifyCallback method.
        /// </returns>
        public new extern HttpPromise<T> Then(Func<T> successCallback, Func<T> errorCallback = null, Func<T> notifyCallback = null);

        /// <summary>
        /// A shorthand for Then(null, callback).
        /// </summary>
        /// <param name="callback">Called on error.</param>
        /// <returns>
        /// A new promise which is resolved or rejected via the return value of
        /// the successCallback, errorCallback (unless that value is a promise,
        /// in which case it is resolved with the value which is resolved in
        /// that promise using promise chaining). It also notifies via the
        /// return value of the notifyCallback method. The promise cannot be
        /// resolved or rejected from the notifyCallback method.
        /// </returns>
        public new extern HttpPromise<T> Catch(Func<T> callback);
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