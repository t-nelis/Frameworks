using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngBlur directive.
    /// </summary>
    public static class BlurDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-blur (ngBlur)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBlur">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-blur')")]
        public static string GetNGBlur(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-blur (ngBlur)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBlur">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-blur', {value})")]
        public static void SetNGBlur(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-blur (ngBlur) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBlur">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-blur')")]
        public static void RemoveNGBlur(this Element el)
        {
        }
    }
}