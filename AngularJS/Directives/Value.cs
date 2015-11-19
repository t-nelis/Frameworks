using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngValue directive.
    /// </summary>
    public static class ValueDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-value (ngValue)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngValue">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-value')")]
        public static string GetNGValue(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-value (ngValue)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngValue">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-value', {value})")]
        public static void SetNGValue(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-value (ngValue) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngValue">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-value')")]
        public static void RemoveNGValue(this Element el)
        {
        }
    }
}