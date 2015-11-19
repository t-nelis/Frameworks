using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngHide directive.
    /// </summary>
    public static class HideDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-hide (ngHide)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngHide">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-hide')")]
        public static string GetNGHide(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-hide (ngHide)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngHide">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-hide', {value})")]
        public static void SetNGHide(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-hide (ngHide) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngHide">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-hide')")]
        public static void RemoveNGHide(this Element el)
        {
        }
    }
}