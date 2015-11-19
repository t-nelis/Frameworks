using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngFocus directive.
    /// </summary>
    public static class FocusDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-focus (ngFocus)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngFocus">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-focus')")]
        public static string GetNGFocus(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-focus (ngFocus)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngFocus">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-focus', {value})")]
        public static void SetNGFocus(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-focus (ngFocus) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngFocus">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-focus')")]
        public static void RemoveNGFocus(this Element el)
        {
        }
    }
}