using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngMouseover directive.
    /// </summary>
    public static class MouseoverDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-mouseover (ngMouseover)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseover">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-mouseover')")]
        public static string GetNGMouseover(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-mouseover (ngMouseover)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseover">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-mouseover', {value})")]
        public static void SetNGMouseover(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-mouseover (ngMouseover) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseover">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-mouseover')")]
        public static void RemoveNGMouseover(this Element el)
        {
        }
    }
}