using Bridge.CLR;
using Bridge.Html5;
using System;
using System.Collections.Generic;

namespace Bridge.jQuery2
{    
    public partial class jQuery
    {
        /// <summary>
        /// Remove the parents of the set of matched elements from the DOM, leaving the matched elements in their place.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery Unwrap()
        {
            return null;
        }

        /// <summary>
        /// Wrap an HTML structure around each element in the set of matched elements.
        /// </summary>
        /// <param name="wrappingElement">A selector, element, HTML string, or jQuery object specifying the structure to wrap around the matched elements.</param>
        /// <returns></returns>
        public virtual jQuery Wrap(string wrappingElement)
        {
            return null;
        }

        /// <summary>
        /// Wrap an HTML structure around each element in the set of matched elements.
        /// </summary>
        /// <param name="wrappingElement">A selector, element, HTML string, or jQuery object specifying the structure to wrap around the matched elements.</param>
        /// <returns></returns>
        public virtual jQuery Wrap(Element wrappingElement)
        {
            return null;
        }

        /// <summary>
        /// Wrap an HTML structure around each element in the set of matched elements.
        /// </summary>
        /// <param name="wrappingElement">A selector, element, HTML string, or jQuery object specifying the structure to wrap around the matched elements.</param>
        /// <returns></returns>
        public virtual jQuery Wrap(jQuery wrappingElement)
        {
            return null;
        }

        /// <summary>
        /// Wrap an HTML structure around each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A callback function returning the HTML content or jQuery object to wrap around the matched elements. Receives the index position of the element in the set as an argument. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        public virtual jQuery Wrap(Func<int, jQuery> function)
        {
            return null;
        }

        /// <summary>
        /// Wrap an HTML structure around each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A callback function returning the HTML content or jQuery object to wrap around the matched elements. Receives the index position of the element in the set as an argument. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        public virtual jQuery Wrap(Func<int, string> function)
        {
            return null;
        }

        /// <summary>
        /// Wrap an HTML structure around all elements in the set of matched elements.
        /// </summary>
        /// <param name="wrappingElement">A selector, element, HTML string, or jQuery object specifying the structure to wrap around the matched elements.</param>
        /// <returns></returns>
        public virtual jQuery WrapAll(string wrappingElement)
        {
            return null;
        }

        /// <summary>
        /// Wrap an HTML structure around all elements in the set of matched elements.
        /// </summary>
        /// <param name="wrappingElement">A selector, element, HTML string, or jQuery object specifying the structure to wrap around the matched elements.</param>
        /// <returns></returns>
        public virtual jQuery WrapAll(Element wrappingElement)
        {
            return null;
        }

        /// <summary>
        /// Wrap an HTML structure around all elements in the set of matched elements.
        /// </summary>
        /// <param name="wrappingElement">A selector, element, HTML string, or jQuery object specifying the structure to wrap around the matched elements.</param>
        /// <returns></returns>
        public virtual jQuery WrapAll(jQuery wrappingElement)
        {
            return null;
        }

        /// <summary>
        /// Wrap an HTML structure around the content of each element in the set of matched elements.
        /// </summary>
        /// <param name="wrappingElement">An HTML snippet, selector expression, jQuery object, or DOM element specifying the structure to wrap around the content of the matched elements.</param>
        /// <returns></returns>
        public virtual jQuery WrapInner(string wrappingElement)
        {
            return null;
        }

        /// <summary>
        /// Wrap an HTML structure around the content of each element in the set of matched elements.
        /// </summary>
        /// <param name="wrappingElement">An HTML snippet, selector expression, jQuery object, or DOM element specifying the structure to wrap around the content of the matched elements.</param>
        /// <returns></returns>
        public virtual jQuery WrapInner(Element wrappingElement)
        {
            return null;
        }

        /// <summary>
        /// Wrap an HTML structure around the content of each element in the set of matched elements.
        /// </summary>
        /// <param name="wrappingElement">An HTML snippet, selector expression, jQuery object, or DOM element specifying the structure to wrap around the content of the matched elements.</param>
        /// <returns></returns>
        public virtual jQuery WrapInner(jQuery wrappingElement)
        {
            return null;
        }   

        /// <summary>
        /// Wrap an HTML structure around the content of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A callback function which generates a structure to wrap around the content of the matched elements. Receives the index position of the element in the set as an argument. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        public virtual jQuery WrapInner(Func<int, string> function)
        {
            return null;
        }
    }
}