using System;

namespace Bridge.AngularJS
{
    public partial class jqLite
    {
        /// <summary>
        /// Remove a single class, multiple classes, or all classes from each
        /// element in the set of matched elements.
        /// </summary>
        /// <param name="className">
        /// One or more space-separated classes to be removed from the class
        /// attribute of each matched element.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite RemoveClass(string className)
        {
            return null;
        }

        /// <summary>
        /// Remove a single class, multiple classes, or all classes from each
        /// element in the set of matched elements.
        /// </summary>
        /// <param name="function">
        /// A function returning one or more space-separated class names to be
        /// removed. Receives the index position of the element in the set and
        /// the old class value as arguments.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite RemoveClass(Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Remove a single class, multiple classes, or all classes from each
        /// element in the set of matched elements.
        /// </summary>
        /// <param name="function">
        /// A function returning one or more space-separated class names to be
        /// removed. Receives the index position of the element in the set and
        /// the old class value as arguments.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite RemoveClass(Func<int, string, string> function)
        {
            return null;
        }
    }
}