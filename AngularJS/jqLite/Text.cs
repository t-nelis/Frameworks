using System;

namespace Bridge.AngularJS
{
    public partial class jqLite
    {
        /// <summary>
        /// Get the combined text contents of each element in the set of matched
        /// elements, including their descendants.
        /// </summary>
        /// <returns></returns>
        public virtual string Text()
        {
            return null;
        }

        /// <summary>
        /// Set the content of each element in the set of matched elements to
        /// the specified text.
        /// </summary>
        /// <param name="text">
        /// The text to set as the content of each matched element. When Number
        /// or Boolean is supplied, it will be converted to a String
        /// representation.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Text(string text)
        {
            return null;
        }

        /// <summary>
        /// Set the content of each element in the set of matched elements to
        /// the specified text.
        /// </summary>
        /// <param name="text">
        /// The text to set as the content of each matched element. When Number
        /// or Boolean is supplied, it will be converted to a String
        /// representation.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Text(int text)
        {
            return null;
        }

        /// <summary>
        /// Set the content of each element in the set of matched elements to
        /// the specified text.
        /// </summary>
        /// <param name="text">
        /// The text to set as the content of each matched element. When Number
        /// or Boolean is supplied, it will be converted to a String
        /// representation.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Text(bool text)
        {
            return null;
        }

        /// <summary>
        /// Set the content of each element in the set of matched elements to
        /// the specified text.
        /// </summary>
        /// <param name="function">
        /// A function returning the text content to set. Receives the index
        /// position of the element in the set and the old text value as
        /// arguments.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Text(Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Set the content of each element in the set of matched elements to
        /// the specified text.
        /// </summary>
        /// <param name="function">
        /// A function returning the text content to set. Receives the index
        /// position of the element in the set and the old text value as
        /// arguments.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Text(Func<int, string, string> function)
        {
            return null;
        }
    }
}