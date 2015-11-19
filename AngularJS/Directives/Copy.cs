using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngCopy directive.
    /// </summary>
    public static class CopyDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-copy (ngCopy)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCopy">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-copy')")]
        public static string GetNGCopy(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-copy (ngCopy)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCopy">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-copy', {value})")]
        public static void SetNGCopy(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-copy (ngCopy) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCopy">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-copy')")]
        public static void RemoveNGCopy(this Element el)
        {
        }
    }
}