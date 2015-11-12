using System;

namespace Bridge.jQuery2
{
    /// <summary>
    /// This object provides a subset of the methods of the Deferred object (then, done, fail, always and state) to prevent users from changing the state of the Deferred.
    /// </summary>
    [Ignore]
    [Name("Object")]
    public class Promise
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
    }
}
