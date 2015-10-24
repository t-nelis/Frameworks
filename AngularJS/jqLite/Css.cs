using System;

namespace Bridge.AngularJS
{
    /*
     * Limitations for Css():
     * Only retrieves inline-styles, does not call getComputedStyle().
     * As a setter, does not convert numbers to strings or append 'px'.
     */
    public partial class jqLite
    {
        /// <summary>
        /// Get the value of a style property for the first element in the set
        /// of matched elements or set one or more CSS properties for every
        /// matched element.
        /// </summary>
        /// <param name="propertyName">A CSS property.</param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Only retrieves inline-styles, does not call getComputedStyle().
        /// As a setter, does not convert numbers to strings or append 'px'.
        /// </remarks>
        /// <returns></returns>
        public virtual string Css(string propertyName)
        {
            return null;
        }

        /// <summary>
        /// Get the value of a style property for the first element in the set
        /// of matched elements or set one or more CSS properties for every
        /// matched element.
        /// </summary>
        /// <param name="propertyNames">
        /// An array of one or more CSS properties.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Only retrieves inline-styles, does not call getComputedStyle().
        /// As a setter, does not convert numbers to strings or append 'px'.
        /// </remarks>
        /// <returns></returns>
        public virtual object Css(string[] propertyNames)
        {
            return null;
        }

        /// <summary>
        /// Set one or more CSS properties for the set of matched elements.
        /// </summary>
        /// <param name="name">A CSS property name.</param>
        /// <param name="value">A value to set for the property.</param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Only retrieves inline-styles, does not call getComputedStyle().
        /// As a setter, does not convert numbers to strings or append 'px'.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Css(string name, object value)
        {
            return null;
        }

        /// <summary>
        /// Set one or more CSS properties for the set of matched elements.
        /// </summary>
        /// <param name="name">A CSS property name.</param>
        /// <param name="function">
        /// A function returning the value to set. This is the current element.
        /// Receives the index position of the element in the set and the old
        /// value as arguments.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Only retrieves inline-styles, does not call getComputedStyle().
        /// As a setter, does not convert numbers to strings or append 'px'.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Css(string name, Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Set one or more CSS properties for the set of matched elements.
        /// </summary>
        /// <param name="name">A CSS property name.</param>
        /// <param name="function">
        /// A function returning the value to set. This is the current element.
        /// Receives the index position of the element in the set and the old
        /// value as arguments.</param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Only retrieves inline-styles, does not call getComputedStyle().
        /// As a setter, does not convert numbers to strings or append 'px'.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Css(string name, Func<int, string, int> function)
        {
            return null;
        }

        /// <summary>
        /// Set one or more CSS properties for the set of matched elements.
        /// </summary>
        /// <param name="name">A CSS property name.</param>
        /// <param name="function">
        /// A function returning the value to set. This is the current element.
        /// Receives the index position of the element in the set and the old
        /// value as arguments.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Only retrieves inline-styles, does not call getComputedStyle().
        /// As a setter, does not convert numbers to strings or append 'px'.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Css(string name,
            Func<int, string, string> function)
        {
            return null;
        }

        /// <summary>
        /// Set one or more CSS properties for the set of matched elements.
        /// </summary>
        /// <param name="properties">
        /// An object of property-value pairs to set.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Only retrieves inline-styles, does not call getComputedStyle().
        /// As a setter, does not convert numbers to strings or append 'px'.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Css(object properties)
        {
            return null;
        }
    }
}