using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngMouseleave directive.
    /// </summary>
    public static class MouseleaveDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-mouseleave (ngMouseleave)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseleave">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-mouseleave')")]
        public static string GetNGMouseleave(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-mouseleave (ngMouseleave)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseleave">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-mouseleave', {value})")]
        public static void SetNGMouseleave(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-mouseleave (ngMouseleave) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseleave">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-mouseleave')")]
        public static void RemoveNGMouseleave(this Element el)
        {
        }
    }
}