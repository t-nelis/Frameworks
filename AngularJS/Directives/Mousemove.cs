using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngMousemove directive.
    /// </summary>
    public static class MousemoveDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-mousemove (ngMousemove)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMousemove">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-mousemove')")]
        public static string GetNGMousemove(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-mousemove (ngMousemove)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMousemove">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-mousemove', {value})")]
        public static void SetNGMousemove(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-mousemove (ngMousemove) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMousemove">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-mousemove')")]
        public static void RemoveNGMousemove(this Element el)
        {
        }
    }
}