using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngMouseEnter directive.
    /// </summary>
    public static class MouseEnterDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-mouseenter (ngMouseEnter)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseEnter">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-mouseenter')")]
        public static string GetNGMouseEnter(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-mouseenter (ngMouseEnter)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseEnter">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-mouseenter', {value})")]
        public static void SetNGMouseEnter(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-mouseenter (ngMouseEnter) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseEnter">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-mouseenter')")]
        public static void RemoveNGMouseEnter(this Element el)
        {
        }
    }
}