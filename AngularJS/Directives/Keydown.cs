using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngKeydown directive.
    /// </summary>
    public static class KeydownDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-keydown (ngKeydown)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngKeydown">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-keydown')")]
        public static string GetNGKeydown(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-keydown (ngKeydown)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngKeydown">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-keydown', {value})")]
        public static void SetNGKeydown(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-keydown (ngKeydown) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngKeydown">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-keydown')")]
        public static void RemoveNGKeydown(this Element el)
        {
        }
    }
}