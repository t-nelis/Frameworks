using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngKeypress directive.
    /// </summary>
    public static class KeypressDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-keypress (ngKeypress)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngKeypress">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-keypress')")]
        public static string GetNGKeypress(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-keypress (ngKeypress)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngKeypress">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-keypress', {value})")]
        public static void SetNGKeypress(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-keypress (ngKeypress) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngKeypress">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-keypress')")]
        public static void RemoveNGKeypress(this Element el)
        {
        }
    }
}