using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngSelected directive.
    /// </summary>
    public static class SelectedDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-selected (ngSelected)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSelected">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-selected')")]
        public static string GetNGSelected(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-selected (ngSelected)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSelected">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-selected', {value})")]
        public static void SetNGSelected(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-selected (ngSelected) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSelected">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-selected')")]
        public static void RemoveNGSelected(this Element el)
        {
        }
    }
}