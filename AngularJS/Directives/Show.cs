using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngShow directive.
    /// </summary>
    public static class ShowDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-show (ngShow)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngShow">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-show')")]
        public static string GetNGShow(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-show (ngShow)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngShow">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-show', {value})")]
        public static void SetNGShow(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-show (ngShow) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngShow">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-show')")]
        public static void RemoveNGShow(this Element el)
        {
        }
    }
}