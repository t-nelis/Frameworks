using System;

namespace Bridge.AngularJS
{
    public partial class jqLite
    {
        /// <summary>
        /// Adds the specified class(es) to each of the set of matched elements.
        /// </summary>
        /// <param name="className">
        /// One or more space-separated classes to be added to the class
        /// attribute of each matched element.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite AddClass(string className)
        {
            return null;
        }

        /// <summary>
        /// Adds the specified class(es) to each of the set of matched elements.
        /// </summary>
        /// <param name="function">
        /// A function returning one or more space-separated class names to be
        /// added to the existing class name(s). Receives the index position of
        /// the element in the set and the existing class name(s) as arguments.
        /// Within the function, this refers to the current element in the set.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite AddClass(Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Adds the specified class(es) to each of the set of matched elements.
        /// </summary>
        /// <param name="function">
        /// A function returning one or more space-separated class names to be
        /// added to the existing class name(s). Receives the index position of
        /// the element in the set and the existing class name(s) as arguments.
        /// Within the function, this refers to the current element in the set.
        /// </param>
        /// <returns></returns>
        public virtual jqLite AddClass(Func<int, string> function)
        {
            return null;
        }

        /// <summary>
        /// Adds the specified class(es) to each of the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning one or more
        /// space-separated class names to be added to the existing class
        /// name(s). Receives the index position of the element in the set and
        /// the existing class name(s) as arguments. Within the function, this
        /// refers to the current element in the set.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite AddClass(Func<int, string, string> function)
        {
            return null;
        }
    }
}