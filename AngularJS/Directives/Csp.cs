using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngCsp directive.
    /// </summary>
    public static class CspDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-csp (ngCsp)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCsp">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-csp')")]
        public static string GetNGCsp(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-csp (ngCsp)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCsp">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-csp', {value})")]
        public static void SetNGCsp(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-csp (ngCsp) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCsp">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-csp')")]
        public static void RemoveNGCsp(this Element el)
        {
        }
    }
}