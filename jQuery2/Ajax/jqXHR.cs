using Bridge;
using Bridge.Html5;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bridge.jQuery2
{
    [Ignore]
    public partial class jqXHR : XMLHttpRequest, IPromise, IDeferred
    {
        /// <summary>
        /// Add handlers to be called when the Deferred object is either resolved or rejected.
        /// </summary>
        /// <param name="alwaysCallbacks">A function, or array of functions, that is called when the Deferred is resolved or rejected.</param>
        /// <returns>The Deferred object</returns>
        public virtual Deferred Always(params Delegate[] alwaysCallbacks)
        {
            return null;
        }

        /// <summary>
        /// Add handlers to be called when the Deferred object is either resolved or rejected.
        /// </summary>
        /// <param name="alwaysCallbacks">A function, or array of functions, that is called when the Deferred is resolved or rejected.</param>
        /// <returns>The Deferred object</returns>
        public virtual Deferred Always(params Action[] alwaysCallbacks)
        {
            return null;
        }

        /// <summary>
        /// Add handlers to be called when the Deferred object is resolved.
        /// </summary>
        /// <param name="doneCallbacks">A function, or array of functions, that is called when the Deferred is resolved or rejected.</param>
        /// <returns>The Deferred object</returns>
        public virtual Deferred Done(params Delegate[] doneCallbacks)
        {
            return null;
        }

        /// <summary>
        /// Add handlers to be called when the Deferred object is resolved.
        /// </summary>
        /// <param name="doneCallbacks">A function, or array of functions, that is called when the Deferred is resolved or rejected.</param>
        /// <returns>The Deferred object</returns>
        public virtual Deferred Done(params Action[] doneCallbacks)
        {
            return null;
        }

        /// <summary>
        /// Add handlers to be called when the Deferred object is resolved.
        /// </summary>
        /// <param name="doneCallbacks">A function, or array of functions, that is called when the Deferred is resolved or rejected.</param>
        /// <returns>The Deferred object</returns>
        public virtual jqXHR Done(params Action<object, string, jqXHR>[] doneCallbacks)
        {
            return null;
        }

        /// <summary>
        /// Add handlers to be called when the Deferred object is rejected.
        /// </summary>
        /// <param name="failCallbacks">A function, or array of functions, that are called when the Deferred is rejected.</param>
        /// <returns>The Deferred object</returns>
        public virtual Deferred Fail(params Delegate[] failCallbacks)
        {
            return null;
        }

        /// <summary>
        /// Add handlers to be called when the Deferred object is rejected.
        /// </summary>
        /// <param name="failCallbacks">A function, or array of functions, that are called when the Deferred is rejected.</param>
        /// <returns>The Deferred object</returns>
        public virtual Deferred Fail(params Action[] failCallbacks)
        {
            return null;
        }

        /// <summary>
        /// Add handlers to be called when the Deferred object is rejected.
        /// </summary>
        /// <param name="failCallbacks">A function, or array of functions, that are called when the Deferred is rejected.</param>
        /// <returns>The Deferred object</returns>
        public virtual jqXHR Fail(params Action<jqXHR, string, string>[] failCallbacks)
        {
            return null;
        }

        /// <summary>
        /// Call the progressCallbacks on a Deferred object with the given args.
        /// </summary>
        /// <param name="arguments">Optional arguments that are passed to the progressCallbacks.</param>
        /// <returns>The Deferred object</returns>
        public virtual Deferred Notify(params object[] arguments)
        {
            return null;
        }

        /// <summary>
        /// Call the progressCallbacks on a Deferred object with the given context and args.
        /// </summary>
        /// <param name="context">Context passed to the progressCallbacks as the this object.</param>
        /// <param name="arguments">An optional array of arguments that are passed to the progressCallbacks.</param>
        /// <returns>The Deferred object</returns>
        public virtual Deferred NotifyWith(object context, params object[] arguments)
        {
            return null;
        }

        /// <summary>
        /// Add handlers to be called when the Deferred object generates progress notifications.
        /// </summary>
        /// <param name="progressCallbacks">A function, or array of functions, to be called when the Deferred generates progress notifications. </param>
        /// <returns>The Deferred object</returns>
        public virtual Deferred Progress(params Delegate[] progressCallbacks)
        {
            return null;
        }

        /// <summary>
        /// Add handlers to be called when the Deferred object generates progress notifications.
        /// </summary>
        /// <param name="progressCallbacks">A function, or array of functions, to be called when the Deferred generates progress notifications. </param>
        /// <returns>The Deferred object</returns>
        public virtual Deferred Progress(params Action[] progressCallbacks)
        {
            return null;
        }

        /// <summary>
        /// Return a Deferred's Promise object.
        /// </summary>
        /// <returns>A Deferred's Promise object.</returns>
        public virtual Promise Promise()
        {
            return null;
        }

        /// <summary>
        /// Return a Deferred's Promise object.
        /// </summary>
        /// <param name="target">Object onto which the promise methods have to be attached.</param>
        /// <returns>A Deferred's Promise object.</returns>
        public virtual Promise Promise(object target)
        {
            return null;
        }

        /// <summary>
        /// Reject a Deferred object and call any failCallbacks with the given args.
        /// </summary>
        /// <param name="arguments">Optional arguments that are passed to the failCallbacks.</param>
        /// <returns>The Deferred object</returns>
        public virtual Deferred Reject(params object[] arguments)
        {
            return null;
        }

        /// <summary>
        /// Reject a Deferred object and call any failCallbacks with the given context and args.
        /// </summary>
        /// <param name="arguments">Optional arguments that are passed to the failCallbacks.</param>
        /// <param name="context">Context passed to the failCallbacks as the this object.</param>
        /// <returns>The Deferred object</returns>
        public virtual Deferred RejectWith(object context, params object[] arguments)
        {
            return null;
        }

        /// <summary>
        /// Resolve a Deferred object and call any doneCallbacks with the given args.
        /// </summary>
        /// <param name="arguments">Optional arguments that are passed to the doneCallbacks.</param>
        /// <returns>The Deferred object</returns>
        public virtual Deferred Resolve(params object[] arguments)
        {
            return null;
        }

        /// <summary>
        /// Resolve a Deferred object and call any doneCallbacks with the given context and args.
        /// </summary>
        /// <param name="context">Context passed to the doneCallbacks as the this object.</param>
        /// <param name="arguments">An optional array of arguments that are passed to the doneCallbacks. </param>
        /// <returns>The Deferred object</returns>
        public virtual Deferred ResolveWith(object context, params object[] arguments)
        {
            return null;
        }

        /// <summary>
        /// Determine the current state of a Deferred object.
        /// The deferred.state() method returns a string representing the current state of the Deferred object. The Deferred object can be in one of three states:
        ///
        ///     "pending" : The Deferred object is not yet in a completed state (neither "rejected" nor "resolved").
        ///     "resolved": The Deferred object is in the resolved state, meaning that either deferred.resolve() or deferred.resolveWith() has been called for the object and the doneCallbacks have been called (or are in the process of being called).
        ///     "rejected": The Deferred object is in the rejected state, meaning that either deferred.reject() or deferred.rejectWith() has been called for the object and the failCallbacks have been called (or are in the process of being called).
        /// </summary>
        /// <returns>The state string</returns>
        public virtual string State()
        {
            return null;
        }
        
        /// <summary>
        /// Add handlers to be called when the Deferred object is resolved, rejected, or still in progress.
        /// </summary>
        /// <param name="doneFilter">A function that is called when the Deferred is resolved.</param>
        /// <param name="failFilter">An optional function that is called when the Deferred is rejected.</param>
        /// <param name="progressFilter">An optional function that is called when progress notifications are sent to the Deferred.</param>
        /// <returns>A Promise object</returns>
        public virtual Promise Then(Delegate doneFilter, Delegate failFilter = null, Delegate progressFilter = null)
        {
            return null;
        }

        /// <summary>
        /// Add handlers to be called when the Deferred object is resolved, rejected, or still in progress.
        /// </summary>
        /// <param name="doneFilter">A function that is called when the Deferred is resolved.</param>
        /// <param name="failFilter">An optional function that is called when the Deferred is rejected.</param>
        /// <param name="progressFilter">An optional function that is called when progress notifications are sent to the Deferred.</param>
        /// <returns>A Promise object</returns>
        public virtual Promise Then(Action doneFilter, Action failFilter = null, Action progressFilter = null)
        {
            return null;
        }
        
        /// <summary>
        /// Add handlers to be called when the Deferred object is resolved, rejected, or still in progress.
        /// </summary>
        /// <param name="doneFilter">A function that is called when the Deferred is resolved.</param>
        /// <param name="failFilter">An optional function that is called when the Deferred is rejected.</param>
        /// <param name="progressFilter">An optional function that is called when progress notifications are sent to the Deferred.</param>
        /// <returns>A Promise object</returns>
        public virtual Promise Then(Action<object, string, jqXHR> doneFilter, Action<jqXHR, string, string> failFilter = null, Action progressFilter = null)
        {
            return null;
        }

        /// <summary>
        /// Add handlers to be called when the Deferred object is resolved, rejected, or still in progress.
        /// </summary>
        /// <param name="doneFilter">A function that is called when the Deferred is resolved.</param>
        /// <param name="failFilter">An optional function that is called when the Deferred is rejected.</param>
        /// <param name="progressFilter">An optional function that is called when progress notifications are sent to the Deferred.</param>
        /// <returns>A Promise object</returns>
        public virtual S Then<S>(Func<object, string, jqXHR, S> doneFilter, Action<jqXHR, string, string> failFilter = null, Action progressFilter = null) where S : IDeferred
        {
            return default(S);
        }

        #region IPromise

        /// <summary>
        /// Adds a fulfilledHandler, errorHandler to be called for completion of a promise.
        /// </summary>
        /// <param name="fulfilledHandler">The fulfilledHandler is called when the promise is fulfilled</param>
        /// <param name="errorHandler">The errorHandler is called when a promise fails.</param>
        void IPromise.Then(Delegate fulfilledHandler, Delegate errorHandler)
        {
        }

        #endregion
    }
}