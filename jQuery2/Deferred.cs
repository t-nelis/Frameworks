using Bridge.Foundation;
using System;
using System.Threading.Tasks;

namespace Bridge.jQuery2
{    
    public partial class jQuery
    {
        /// <summary>
        ///  A constructor function that returns a chainable utility object with methods to register multiple callbacks into callback queues, invoke callback queues, and relay the success or failure state of any synchronous or asynchronous function.
        /// </summary>
        /// <returns>A Deferred object</returns>
        [Template("$.Deferred")]
        public static Deferred Deffered()
        {
            return null;
        }

        /// <summary>
        ///  A constructor function that returns a chainable utility object with methods to register multiple callbacks into callback queues, invoke callback queues, and relay the success or failure state of any synchronous or asynchronous function.
        /// </summary>
        /// <param name="beforeStart">A function that is called just before the constructor returns. </param>
        /// <returns></returns>
        [Template("$.Deferred({0})")]
        public static Deferred Deffered(Delegate beforeStart)
        {
            return null;
        }

        /// <summary>
        ///  A constructor function that returns a chainable utility object with methods to register multiple callbacks into callback queues, invoke callback queues, and relay the success or failure state of any synchronous or asynchronous function.
        /// </summary>
        /// <param name="beforeStart">A function that is called just before the constructor returns. </param>
        /// <returns></returns>
        [Template("$.Deferred({0})")]
        public static Deferred Deffered(Action<Deferred> beforeStart)
        {
            return null;
        }

        /// <summary>
        /// Provides a way to execute callback functions based on one or more objects, usually Deferred objects that represent asynchronous events.
        /// </summary>
        /// <param name="deferreds">One or more Deferred objects, or plain JavaScript objects.</param>
        /// <returns>A Promise object</returns>
        public static Promise When(params object[] deferreds)
        {
            return null;
        }

        /// <summary>
        /// Return a Promise object to observe when all actions of a certain type (defaults to "fx") bound to the collection, queued or not, have finished. 
        /// </summary>
        /// <param name="type">The type of queue that needs to be observed. Defaults to "fx".</param>
        /// <returns>A Promise object</returns>
        public virtual Promise Promise(string type = "fx")
        {
            return null;
        }

        /// <summary>
        /// Return a Promise object to observe when all actions of a certain type (defaults to "fx") bound to the collection, queued or not, have finished. 
        /// </summary>
        /// <param name="type">The type of queue that needs to be observed. Defaults to "fx".</param>
        /// <param name="target">Object onto which the promise methods have to be attached</param>
        /// <returns>A Promise object</returns>
        public virtual Promise Promise(string type, object target)
        {
            return null;
        }
    }

    /// <summary>
    /// The Deferred object is a chainable utility object created by calling the jQuery.Deferred() method. It can register multiple callbacks into callback queues, invoke callback queues, and relay the success or failure state of any synchronous or asynchronous function.
    /// The Deferred object is chainable, similar to the way a jQuery object is chainable, but it has its own methods. After creating a Deferred object, you can use any of the methods below by either chaining directly from the object creation or saving the object in a variable and invoking one or more methods on that variable.
    /// </summary>
    [Ignore]
    [Name("Object")]
    public class Deferred : IPromise
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
        /// Add handlers to be called when the Deferred object is resolved.
        /// </summary>
        /// <param name="doneFilter">A function that is called when the Deferred is resolved.</param>
        /// <returns>A Promise object</returns>
        public virtual Promise Then(Delegate doneFilter)
        {
            return null;
        }

        /// <summary>
        /// Add handlers to be called when the Deferred object is resolved.
        /// </summary>
        /// <param name="doneFilter">A function that is called when the Deferred is resolved.</param>
        /// <returns>A Promise object</returns>
        public virtual Promise Then(Action doneFilter)
        {
            return null;
        }

        /// <summary>
        /// Add handlers to be called when the Deferred object is resolved or rejected.
        /// </summary>
        /// <param name="doneFilter">A function that is called when the Deferred is resolved.</param>
        /// <param name="failFilter">An optional function that is called when the Deferred is rejected.</param>
        /// <returns>A Promise object</returns>
        public virtual Promise Then(Delegate doneFilter, Delegate failFilter)
        {
            return null;
        }

        /// <summary>
        /// Add handlers to be called when the Deferred object is resolved or rejected.
        /// </summary>
        /// <param name="doneFilter">A function that is called when the Deferred is resolved.</param>
        /// <param name="failFilter">An optional function that is called when the Deferred is rejected.</param>
        /// <returns>A Promise object</returns>
        public virtual Promise Then(Action doneFilter, Action failFilter)
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
        public virtual Promise Then(Delegate doneFilter, Delegate failFilter, Delegate progressFilter)
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
        public virtual Promise Then(Action doneFilter, Action failFilter, Action progressFilter)
        {
            return null;
        }

        #region IPromise
        /// <summary>
        /// Adds a fulfilledHandler to be called for completion of a promise.
        /// </summary>
        /// <param name="fulfilledHandler">The fulfilledHandler is called when the promise is fulfilled</param>
        void IPromise.Then(Delegate fulfilledHandler)
        {
        }

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
