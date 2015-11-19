using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngJq directive.
    /// </summary>
    public static class JqDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-jq (ngJq)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngJq">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-jq')")]
        public static string GetNGJq(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-jq (ngJq)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngJq">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-jq', {value})")]
        public static void SetNGJq(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-jq (ngJq) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngJq">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-jq')")]
        public static void RemoveNGJq(this Element el)
        {
        }
    }
}