using Bridge;
using System;

namespace Bridge.AngularJS
{
    /// <summary>
    /// A new promise instance is created when a deferred instance is created
    /// and can be retrieved by calling deferred.promise.
    /// The purpose of the promise object is to allow for interested parties to
    /// get access to the result of the deferred task when it completes.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [External]
    public class Promise<T>
    {
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
        public extern Promise<T> Then(Func<T> successCallback, Func<T> errorCallback = null, Func<T> notifyCallback = null);

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
        public extern Promise<T> Catch(Func<T> callback);
    }
}

