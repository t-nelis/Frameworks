using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngMouseup directive.
    /// </summary>
    public static class MouseupDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-mouseup (ngMouseup)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseup">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-mouseup')")]
        public static string GetNGMouseup(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-mouseup (ngMouseup)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseup">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-mouseup', {value})")]
        public static void SetNGMouseup(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-mouseup (ngMouseup) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseup">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-mouseup')")]
        public static void RemoveNGMouseup(this Element el)
        {
        }
    }
}