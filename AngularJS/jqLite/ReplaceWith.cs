using System;

namespace Bridge.AngularJS
{
    public partial class jqLite
    {
        /// <summary>
        /// Replace each element in the set of matched elements with the
        /// provided new content and return the set of elements that was
        /// removed.
        /// </summary>
        /// <param name="newContent">
        /// The content to insert. May be an HTML string, DOM element, array of
        /// DOM elements, or jQuery object.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite ReplaceWith(string newContent)
        {
            return null;
        }

        /// <summary>
        /// Replace each element in the set of matched elements with the
        /// provided new content and return the set of elements that was
        /// removed.
        /// </summary>
        /// <param name="newContent">
        /// The content to insert. May be an HTML string, DOM element, array of
        /// DOM elements, or jQuery object.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite ReplaceWith(jqLite newContent)
        {
            return null;
        }

        /// <summary>
        /// Replace each element in the set of matched elements with the
        /// provided new content and return the set of elements that was
        /// removed.
        /// </summary>
        /// <param name="newContent">
        /// The content to insert. May be an HTML string, DOM element, array of
        /// DOM elements, or jQuery object.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite ReplaceWith(Array newContent)
        {
            return null;
        }

        /// <summary>
        /// Replace each element in the set of matched elements with the
        /// provided new content and return the set of elements that was
        /// removed.
        /// </summary>
        /// <param name="function">
        /// A function that returns content with which to replace the set of
        /// matched elements.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite ReplaceWith(Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Replace each element in the set of matched elements with the
        /// provided new content and return the set of elements that was
        /// removed.
        /// </summary>
        /// <param name="function">
        /// A function that returns content with which to replace the set of
        /// matched elements.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite ReplaceWith(Func<jqLite> function)
        {
            return null;
        }
    }
}