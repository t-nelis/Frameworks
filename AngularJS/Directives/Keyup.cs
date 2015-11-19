using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngKeyup directive.
    /// </summary>
    public static class KeyupDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-keyup (ngKeyup)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngKeyup">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-keyup')")]
        public static string GetNGKeyup(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-keyup (ngKeyup)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngKeyup">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-keyup', {value})")]
        public static void SetNGKeyup(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-keyup (ngKeyup) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngKeyup">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-keyup')")]
        public static void RemoveNGKeyup(this Element el)
        {
        }
    }
}