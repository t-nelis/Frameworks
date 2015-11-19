using System;

namespace Bridge.AngularJS
{
    /// <summary>
    /// jqLite element.
    /// If jQuery is available, 'angular.element' is an alias for the jQuery
    /// function. If jQuery is not available, it delegates to AngularJSs builtin
    /// subset of jQuery (this class), called "jQuery Lite" or "jqLite".
    /// </summary>
    /// <remarks>
    /// To use jQuery in AngularJS (JavaScript part) just ensure it is loaded
    /// before the angular.js file.
    /// All element references in Angular are always wrapped with either jQuery
    /// or jqLite. They are never raw DOM references.
    /// </remarks>
    [Ignore]
    public partial class jqLite
    {
        #region Children() -- no selectors support
        /// <summary>
        /// Get the children of each element in the set of matched elements,
        /// optionally filtered by a selector.
        /// </summary>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces or event object as parameter.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Children()
        {
            return null;
        }
        #endregion

        #region Contents()
        /// <summary>
        /// Get the children of each element in the set of matched elements,
        /// including text and comment nodes.
        /// </summary>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Contents()
        {
            return null;
        }
        #endregion

        #region Empty()
        /// <summary>
        /// Remove all child nodes of the set of matched elements from the DOM.
        /// </summary>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Empty()
        {
            return null;
        }
        #endregion

        #region Eq()
        /// <summary>
        /// Reduce the set of matched elements to the one at the specified
        /// index.
        /// </summary>
        /// <param name="index">
        /// An integer indicating the 0-based position of the element.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Eq(int index)
        {
            return null;
        }
        #endregion

        #region Find() -- Lookups by tag name only
        /// <summary>
        /// Get the descendants of each element in the current set of matched
        /// elements, filtered by a selector, jQuery object, or element.
        /// </summary>
        /// <param name="tagName">
        /// A string containing the tag name.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Limited to lookups by tag name.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Find(string tagName)
        {
            return null;
        }
        #endregion

        #region HasClass()
        /// <summary>
        /// Determine whether any of the matched elements are assigned the given
        /// class.
        /// </summary>
        /// <param name="className">The class name to search for.</param>
        /// <returns>boolean</returns>
        public virtual bool HasClass(string className)
        {
            return false;
        }
        #endregion

        #region Next() -- No selectors support
        /// <summary>
        /// Get the immediately following sibling of each element in the set of
        /// matched elements. If a selector is provided, it retrieves the next
        /// sibling only if it matches that selector.
        /// </summary>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support selectors.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Next()
        {
            return null;
        }
        #endregion

        #region Parent() -- No selectors support
        /// <summary>
        /// Get the parent of each element in the current set of matched
        /// elements, optionally filtered by a selector.
        /// </summary>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support selectors.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Parent()
        {
            return null;
        }
        #endregion

        #region RemoveAttr()
        /// <summary>
        /// Remove an attribute from each element in the set of matched
        /// elements.
        /// </summary>
        /// <param name="attributeName">
        /// An attribute to remove; as of version 1.7, it can be a
        /// space-separated list of attributes.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite RemoveAttr(string attributeName)
        {
            return null;
        }
        #endregion
    }
}