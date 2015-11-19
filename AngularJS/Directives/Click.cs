using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngClick directive.
    /// </summary>
    public static class ClickDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-click (ngClick)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClick">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-click')")]
        public static string GetNGClick(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-click (ngClick)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClick">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-click', {value})")]
        public static void SetNGClick(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-click (ngClick) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClick">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-click')")]
        public static void RemoveNGClick(this Element el)
        {
        }
    }
}