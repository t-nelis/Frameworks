using Bridge.Html5;
using System;

namespace Bridge.AngularJS
{
    public partial class jqLite
    {
        /// <summary>
        /// Store arbitrary data associated with the matched elements.
        /// </summary>
        /// <param name="key">
        /// A string naming the piece of data to set.
        /// </param>
        /// <param name="value">
        /// The new data value; it can be any Javascript type including Array or
        /// Object.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Data(string key, object value)
        {
            return null;
        }

        /// <summary>
        /// Store arbitrary data associated with the matched elements.
        /// </summary>
        /// <param name="obj">
        /// An object of key-value pairs of data to update.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Data(object obj)
        {
            return null;
        }

        /// <summary>
        /// Return the value at the named data store for the first element in
        /// the jQuery collection, as set by data(name, value) or by an HTML5
        /// data-* attribute.
        /// </summary>
        /// <param name="key">Name of the data stored.</param>
        /// <returns></returns>
        public virtual object Data(string key)
        {
            return null;
        }

        /// <summary>
        /// Return the value at the named data store for the first element in
        /// the jQuery collection, as set by data(name, value) or by an HTML5
        /// data-* attribute.
        /// </summary>
        /// <typeparam name="T">Return Type of Data object</typeparam>
        /// <param name="key">Name of the data stored.</param>
        /// <returns></returns>
        public virtual T Data<T>(string key)
        {
            return default(T);
        }

        /// <summary>
        /// Return the value at the named data store for the first element in
        /// the jQuery collection, as set by data(name, value) or by an HTML5
        /// data-* attribute.
        /// </summary>
        /// <returns></returns>
        public virtual object Data()
        {
            return null;
        }

        /// <summary>
        /// Return the value at the named data store for the first element in
        /// the jQuery collection, as set by data(name, value) or by an HTML5
        /// data-* attribute.
        /// </summary>
        /// <typeparam name="T">Return Type of Data object</typeparam>
        /// <returns></returns>
        public virtual T Data<T>()
        {
            return default(T);
        }

        /// <summary>
        /// Store arbitrary data associated with the specified element. Returns
        /// the value that was set.
        /// </summary>
        /// <param name="element">
        /// The DOM element to associate with the data.
        /// </param>
        /// <param name="key">A string naming the piece of data to set.</param>
        /// <param name="value">The new data value.</param>
        /// <returns></returns>
        public static object Data(Element element, string key, object value)
        {
            return null;
        }

        /// <summary>
        /// Store arbitrary data associated with the specified element. Returns
        /// the value that was set.
        /// </summary>
        /// <typeparam name="T">Type T of object to return</typeparam>
        /// <param name="element">The DOM element to associate with the data.
        /// </param>
        /// <param name="key">A string naming the piece of data to set.</param>
        /// <param name="value">The new data value.</param>
        /// <returns></returns>
        public static T Data<T>(Element element, string key, T value)
        {
            return default(T);
        }

        /// <summary>
        /// Store arbitrary data associated with the specified element. Returns
        /// the value that was set.
        /// </summary>
        /// <param name="element">The DOM element to associate with the data.
        /// </param>
        /// <param name="key">A string naming the piece of data to set.</param>
        /// <returns></returns>
        public static object Data(Element element, string key)
        {
            return null;
        }

        /// <summary>
        /// Store arbitrary data associated with the specified element. Returns
        /// the value that was set.
        /// </summary>
        /// <param name="element">
        /// The DOM element to associate with the data.
        /// </param>
        /// <returns></returns>
        public static object Data(Element element)
        {
            return null;
        }
    }
}