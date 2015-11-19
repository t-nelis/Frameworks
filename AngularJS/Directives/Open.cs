using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngOpen directive.
    /// </summary>
    public static class OpenDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-open (ngOpen)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngOpen">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-open')")]
        public static string GetNGOpen(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-open (ngOpen)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngOpen">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-open', {value})")]
        public static void SetNGOpen(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-open (ngOpen) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngOpen">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-open')")]
        public static void RemoveNGOpen(this Element el)
        {
        }
    }
}