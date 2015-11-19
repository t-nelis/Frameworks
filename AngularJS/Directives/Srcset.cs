using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngSrcset directive.
    /// </summary>
    public static class SrcsetDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-srcset (ngSrcset)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSrcset">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-srcset')")]
        public static string GetNGSrcset(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-srcset (ngSrcset)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSrcset">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-srcset', {value})")]
        public static void SetNGSrcset(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-srcset (ngSrcset) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSrcset">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-srcset')")]
        public static void RemoveNGSrcset(this Element el)
        {
        }
    }
}