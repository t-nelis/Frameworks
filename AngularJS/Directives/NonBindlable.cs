using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngNonBindlable directive.
    /// </summary>
    public static class NonBindlableDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-nonbindlable (ngNonBindlable)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngNonBindlable">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-nonbindlable')")]
        public static string GetNGNonBindlable(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-nonbindlable (ngNonBindlable)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngNonBindlable">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-nonbindlable', {value})")]
        public static void SetNGNonBindlable(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-nonbindlable (ngNonBindlable) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngNonBindlable">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-nonbindlable')")]
        public static void RemoveNGNonBindlable(this Element el)
        {
        }
    }
}