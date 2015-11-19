using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngMousedown directive.
    /// </summary>
    public static class MousedownDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-mousedown (ngMousedown)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMousedown">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-mousedown')")]
        public static string GetNGMousedown(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-mousedown (ngMousedown)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMousedown">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-mousedown', {value})")]
        public static void SetNGMousedown(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-mousedown (ngMousedown) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMousedown">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-mousedown')")]
        public static void RemoveNGMousedown(this Element el)
        {
        }
    }
}