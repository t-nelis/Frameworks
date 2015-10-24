using System;

namespace Bridge.AngularJS
{
    public partial class jqLite
    {
        /// <summary>
        /// Get the HTML contents of the first element in the set of matched
        /// elements or set the HTML contents of every matched element.
        /// </summary>
        /// <returns></returns>
        public virtual string Html()
        {
            return null;
        }

        /// <summary>
        /// Set the HTML contents of each element in the set of matched
        /// elements.
        /// </summary>
        /// <param name="htmlString">
        /// A string of HTML to set as the content of each matched element.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Html(string htmlString)
        {
            return null;
        }

        /// <summary>
        /// Set the HTML contents of each element in the set of matched
        /// elements.
        /// </summary>
        /// <param name="function">
        /// A function returning the HTML content to set. Receives the index
        /// position of the element in the set and the old HTML value as
        /// arguments. jQuery empties the element before calling the function;
        /// use the oldhtml argument to reference the previous content. Within
        /// the function, this refers to the current element in the set.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Html(Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Set the HTML contents of each element in the set of matched
        /// elements.
        /// </summary>
        /// <param name="function">
        /// A function returning the HTML content to set. Receives the index
        /// position of the element in the set and the old HTML value as
        /// arguments. jQuery empties the element before calling the function;
        /// use the oldhtml argument to reference the previous content. Within
        /// the function, this refers to the current element in the set.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Html(Func<int, string, string> function)
        {
            return null;
        }
    }
}