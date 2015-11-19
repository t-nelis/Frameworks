using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngStyle directive.
    /// </summary>
    public static class StyleDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-style (ngStyle)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngStyle">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-style')")]
        public static string GetNGStyle(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-style (ngStyle)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngStyle">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-style', {value})")]
        public static void SetNGStyle(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-style (ngStyle) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngStyle">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-style')")]
        public static void RemoveNGStyle(this Element el)
        {
        }
    }
}