using System.Collections.Generic;

namespace Bridge.AngularJS
{
    public partial class jqLite
    {
        /// <summary>
        /// Get the value of an attribute for the first element in the set of matched elements.
        /// </summary>
        /// <param name="attributeName">The name of the attribute to get.</param>
        /// <returns></returns>
        public virtual string Attr(string attributeName)
        {
            return null;
        }

        /// <summary>
        /// Get the value of an attribute for the first element in the set of matched elements.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="attributeName">The name of the attribute to get.</param>
        /// <returns></returns>
        public virtual T Attr<T>(string attributeName)
        {
            return default(T);
        }

        /// <summary>
        /// Set one or more attributes for the set of matched elements.
        /// </summary>
        /// <param name="attributeName">The name of the attribute to set.</param>
        /// <param name="value">A value to set for the attribute.</param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Attr(string attributeName, string value)
        {
            return null;
        }

        /// <summary>
        ///  Set one or more attributes for the set of matched elements.
        /// </summary>
        /// <param name="attributeName">The name of the attribute to set.</param>
        /// <param name="value">A value to set for the attribute.</param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Attr(string attributeName, int value)
        {
            return null;
        }

        /// <summary>
        ///  Set one or more attributes for the set of matched elements.
        /// </summary>
        /// <param name="attributes">An object of attribute-value pairs to set.</param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Attr(Dictionary<string, object> attributes)
        {
            return null;
        }

        /// <summary>
        ///  Set one or more attributes for the set of matched elements.
        /// </summary>
        /// <param name="attributes">An object of attribute-value pairs to set.</param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Attr(object attributes)
        {
            return null;
        }
    }
}