using Bridge;
using Bridge.Html5;
using System;
using System.Collections.Generic;

namespace Bridge.jQuery2
{    
    public partial class jQuery
    {
        /// <summary>
        /// Remove from the queue all items that have not yet been run.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery ClearQueue()
        {
            return null;
        }

        /// <summary>
        /// Remove from the queue all items that have not yet been run.
        /// </summary>
        /// <param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        /// <returns></returns>
        public virtual string ClearQueue(string queueName)
        {
            return null;
        }

        /// <summary>
        /// Store arbitrary data associated with the matched elements.
        /// </summary>
        /// <param name="key">A string naming the piece of data to set.</param>
        /// <param name="value">The new data value; it can be any Javascript type including Array or Object.</param>
        /// <returns></returns>
        public virtual jQuery Data(string key, object value)
        {
            return null;
        }

        /// <summary>
        /// Store arbitrary data associated with the matched elements.
        /// </summary>
        /// <param name="obj">An object of key-value pairs of data to update.</param>
        /// <returns></returns>
        public virtual jQuery Data(object obj)
        {
            return null;
        }

        /// <summary>
        /// Return the value at the named data store for the first element in the jQuery collection, as set by data(name, value) or by an HTML5 data-* attribute.
        /// </summary>
        /// <param name="key">Name of the data stored.</param>
        /// <returns></returns>
        public virtual object Data(string key)
        {
            return null;
        }

        /// <summary>
        /// Return the value at the named data store for the first element in the jQuery collection, as set by data(name, value) or by an HTML5 data-* attribute.
        /// </summary>
        /// <typeparam name="T">Return Type of Data object</typeparam>
        /// <param name="key">Name of the data stored.</param>
        /// <returns></returns>
        public virtual T Data<T>(string key)
        {
            return default(T);
        }

        /// <summary>
        /// Return the value at the named data store for the first element in the jQuery collection, as set by data(name, value) or by an HTML5 data-* attribute.
        /// </summary>
        /// <returns></returns>
        public virtual object Data()
        {
            return null;
        }

        /// <summary>
        /// Return the value at the named data store for the first element in the jQuery collection, as set by data(name, value) or by an HTML5 data-* attribute.
        /// </summary>
        /// <typeparam name="T">Return Type of Data object</typeparam>
        /// <returns></returns>
        public virtual T Data<T>()
        {
            return default(T);
        }

        /// <summary>
        /// Execute the next function on the queue for the matched elements.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery Dequeue()
        {
            return null;
        }

        /// <summary>
        /// Execute the next function on the queue for the matched elements.
        /// </summary>
        /// <param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        /// <returns></returns>
        public virtual jQuery Dequeue(string queueName)
        {
            return null;
        }

        /// <summary>
        /// Show the queue of functions to be executed on the matched elements.
        /// </summary>
        /// <returns></returns>
        public virtual Array Queue()
        {
            return null;
        }

        /// <summary>
        /// Show the queue of functions to be executed on the matched elements.
        /// </summary>
        /// <param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        /// <returns></returns>
        public virtual Array Queue(string queueName)
        {
            return null;
        }

        /// <summary>
        /// Manipulate the queue of functions to be executed, once for each matched element.
        /// </summary>
        /// <param name="newQueue"></param>
        /// <returns></returns>
        public virtual jQuery Queue(Array newQueue)
        {
            return null;
        }

        /// <summary>
        /// Manipulate the queue of functions to be executed, once for each matched element.
        /// </summary>
        /// <param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        /// <param name="newQueue">An array of functions to replace the current queue contents.</param>
        /// <returns></returns>
        public virtual jQuery Queue(string queueName, Array newQueue)
        {
            return null;
        }

        /// <summary>
        /// Manipulate the queue of functions to be executed, once for each matched element.
        /// </summary>
        /// <param name="callback">The new function to add to the queue, with a function to call that will dequeue the next item.</param>
        /// <returns></returns>
        public virtual jQuery Queue(Delegate callback)
        {
            return null;
        }

        /// <summary>
        /// Manipulate the queue of functions to be executed, once for each matched element.
        /// </summary>
        /// <param name="callback">The new function to add to the queue, with a function to call that will dequeue the next item.</param>
        /// <returns></returns>
        public virtual jQuery Queue(Action callback)
        {
            return null;
        }

        /// <summary>
        /// Manipulate the queue of functions to be executed, once for each matched element.
        /// </summary>
        /// <param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        /// <param name="callback">The new function to add to the queue, with a function to call that will dequeue the next item.</param>
        /// <returns></returns>
        public virtual jQuery Queue(string queueName, Delegate callback)
        {
            return null;
        }

        /// <summary>
        /// Manipulate the queue of functions to be executed, once for each matched element.
        /// </summary>
        /// <param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        /// <param name="callback">The new function to add to the queue, with a function to call that will dequeue the next item.</param>
        /// <returns></returns>
        public virtual jQuery Queue(string queueName, Action callback)
        {
            return null;
        }

        /// <summary>
        /// Remove a previously-stored piece of data.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery RemoveData()
        {
            return null;
        }

        /// <summary>
        /// Remove a previously-stored piece of data.
        /// </summary>
        /// <param name="name">A string naming the piece of data to delete.</param>
        /// <returns></returns>
        public virtual jQuery RemoveData(string name)
        {
            return null;
        }

        /// <summary>
        /// Remove a previously-stored piece of data.
        /// </summary>
        /// <param name="list">An array or space-separated string naming the pieces of data to delete.</param>
        /// <returns></returns>
        public virtual jQuery RemoveData(Array list)
        {
            return null;
        }

        /// <summary>
        /// Store arbitrary data associated with the specified element. Returns the value that was set.
        /// </summary>
        /// <param name="element">The DOM element to associate with the data.</param>
        /// <param name="key">A string naming the piece of data to set.</param>
        /// <param name="value">The new data value.</param>
        /// <returns></returns>
        public static object Data(Element element, string key, object value)
        {
            return null;
        }

        /// <summary>
        /// Store arbitrary data associated with the specified element. Returns the value that was set.
        /// </summary>
        /// <typeparam name="T">Type T of object to return</typeparam>
        /// <param name="element">The DOM element to associate with the data.</param>
        /// <param name="key">A string naming the piece of data to set.</param>
        /// <param name="value">The new data value.</param>
        /// <returns></returns>
        public static T Data<T>(Element element, string key, T value)
        {
            return default(T);
        }

        /// <summary>
        /// Store arbitrary data associated with the specified element. Returns the value that was set.
        /// </summary>
        /// <param name="element">The DOM element to associate with the data.</param>
        /// <param name="key">A string naming the piece of data to set.</param>
        /// <returns></returns>
        public static object Data(Element element, string key)
        {
            return null;
        }

        /// <summary>
        /// Store arbitrary data associated with the specified element. Returns the value that was set.
        /// </summary>
        /// <param name="element">The DOM element to associate with the data.</param>
        /// <returns></returns>
        public static object Data(Element element)
        {
            return null;
        }

        /// <summary>
        /// Execute the next function on the queue for the matched element.
        /// </summary>
        /// <param name="element"></param>
        public static void Dequeue(Element element) { }

        /// <summary>
        /// Execute the next function on the queue for the matched element.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="queueName"></param>
        public static void Dequeue(Element element, string queueName) { }

        /// <summary>
        /// Determine whether an element has any jQuery data associated with it.
        /// </summary>
        /// <param name="element">A DOM element to be checked for data.</param>
        /// <returns></returns>
        public static bool HasData(Element element)
        {
            return false;
        }

        /// <summary>
        /// Show the queue of functions to be executed on the matched element.
        /// </summary>
        /// <param name="element">A DOM element to inspect for an attached queue.</param>
        /// <returns></returns>
        public static Array Queue(Element element)
        {
            return null;
        }

        /// <summary>
        /// Show the queue of functions to be executed on the matched element.
        /// </summary>
        /// <param name="element">A DOM element to inspect for an attached queue.</param>
        /// <param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        /// <returns></returns>
        public static Array Queue(Element element, string queueName)
        {
            return null;
        }

        /// <summary>
        /// Manipulate the queue of functions to be executed on the matched element.
        /// </summary>
        /// <param name="element">A DOM element where the array of queued functions is attached.</param>
        /// <param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        /// <param name="newQueue">An array of functions to replace the current queue contents.</param>
        /// <returns></returns>
        public static jQuery Queue(Element element, string queueName, Array newQueue)
        {
            return null;
        }

        /// <summary>
        /// Manipulate the queue of functions to be executed on the matched element.
        /// </summary>
        /// <param name="element">A DOM element where the array of queued functions is attached.</param>
        /// <param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        /// <param name="callback">he new function to add to the queue.</param>
        /// <returns></returns>
        public static jQuery Queue(Element element, string queueName, Delegate callback)
        {
            return null;
        }

        /// <summary>
        /// Manipulate the queue of functions to be executed on the matched element.
        /// </summary>
        /// <param name="element">A DOM element where the array of queued functions is attached.</param>
        /// <param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        /// <param name="callback">he new function to add to the queue.</param>
        /// <returns></returns>
        public static jQuery Queue(Element element, string queueName, Action callback)
        {
            return null;
        }

        /// <summary>
        /// Remove a previously-stored piece of data.
        /// </summary>
        /// <param name="element">A DOM element from which to remove data.</param>
        /// <returns></returns>
        public static jQuery RemoveData(Element element)
        {
            return null;
        }

        /// <summary>
        /// Remove a previously-stored piece of data.
        /// </summary>
        /// <param name="element">A DOM element from which to remove data.</param>
        /// <param name="name">A string naming the piece of data to remove.</param>
        /// <returns></returns>
        public static jQuery RemoveData(Element element, string name)
        {
            return null;
        }
    }
}