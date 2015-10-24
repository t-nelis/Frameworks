using System;
using System.Collections.Generic;

namespace Bridge.AngularJS
{
    public partial class jqLite
    {
        /// <summary>
        /// Get the value of a property for the first element in the set of
        /// matched elements.
        /// </summary>
        /// <param name="propertyName">The name of the property to get.</param>
        /// <returns></returns>
        public virtual string Prop(string propertyName)
        {
            return null;
        }

        /// <summary>
        /// Get the value of a property for the first element in the set of
        /// matched elements.
        /// </summary>
        /// <param name="propertyName">The name of the property to get.</param>
        /// <returns></returns>
        public virtual T Prop<T>(string propertyName)
        {
            return default(T);
        }

        /// <summary>
        /// Set one or more properties for the set of matched elements.
        /// </summary>
        /// <param name="propertyName">The name of the property to set.</param>
        /// <param name="value">A value to set for the property.</param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Prop(string propertyName, object value)
        {
            return null;
        }

        /// <summary>
        /// Set one or more properties for the set of matched elements.
        /// </summary>
        /// <param name="properties">
        /// An object of property-value pairs to set.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Prop(Dictionary<string, object> properties)
        {
            return null;
        }

        /// <summary>
        /// Set one or more properties for the set of matched elements.
        /// </summary>
        /// <param name="properties">
        /// An object of property-value pairs to set.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Prop(object properties)
        {
            return null;
        }

        /// <summary>
        /// Set one or more properties for the set of matched elements.
        /// </summary>
        /// <param name="propertyName">The name of the property to set.</param>
        /// <param name="function">
        /// A function returning the value to set. Receives the index position
        /// of the element in the set and the old property value as arguments.
        /// Within the function, the keyword this refers to the current element.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Prop(string propertyName, Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Set one or more properties for the set of matched elements.
        /// </summary>
        /// <param name="propertyName">The name of the property to set.</param>
        /// <param name="function">
        /// A function returning the value to set. Receives the index position
        /// of the element in the set and the old property value as arguments.
        /// Within the function, the keyword this refers to the current element.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Prop(string propertyName,
            Func<int, object, object> function)
        {
            return null;
        }
    }
}