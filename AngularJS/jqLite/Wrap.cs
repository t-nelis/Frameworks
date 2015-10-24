using Bridge.Html5;
using System;

namespace Bridge.AngularJS
{
    public partial class jqLite
    {
        /// <summary>
        /// Wrap an HTML structure around each element in the set of matched elements.
        /// </summary>
        /// <param name="wrappingElement">A selector, element, HTML string, or jQuery object specifying the structure to wrap around the matched elements.</param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Wrap(string wrappingElement)
        {
            return null;
        }

        /// <summary>
        /// Wrap an HTML structure around each element in the set of matched elements.
        /// </summary>
        /// <param name="wrappingElement">A selector, element, HTML string, or jQuery object specifying the structure to wrap around the matched elements.</param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Wrap(Element wrappingElement)
        {
            return null;
        }

        /// <summary>
        /// Wrap an HTML structure around each element in the set of matched elements.
        /// </summary>
        /// <param name="wrappingElement">A selector, element, HTML string, or jQuery object specifying the structure to wrap around the matched elements.</param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Wrap(jqLite wrappingElement)
        {
            return null;
        }

        /// <summary>
        /// Wrap an HTML structure around each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A callback function returning the HTML content or jQuery object to wrap around the matched elements. Receives the index position of the element in the set as an argument. Within the function, this refers to the current element in the set.</param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Wrap(Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Wrap an HTML structure around each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A callback function returning the HTML content or jQuery object to wrap around the matched elements. Receives the index position of the element in the set as an argument. Within the function, this refers to the current element in the set.</param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Wrap(Func<int, jqLite> function)
        {
            return null;
        }

        /// <summary>
        /// Wrap an HTML structure around each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A callback function returning the HTML content or jQuery object to wrap around the matched elements. Receives the index position of the element in the set as an argument. Within the function, this refers to the current element in the set.</param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Wrap(Func<int, string> function)
        {
            return null;
        }
    }
}