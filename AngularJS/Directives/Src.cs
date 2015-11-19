using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngSrc directive.
    /// </summary>
    public static class SrcDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-src (ngSrc)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSrc">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-src')")]
        public static string GetNGSrc(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-src (ngSrc)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSrc">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-src', {value})")]
        public static void SetNGSrc(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-src (ngSrc) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSrc">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-src')")]
        public static void RemoveNGSrc(this Element el)
        {
        }
    }
}