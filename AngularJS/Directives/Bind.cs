using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngBind directive.
    /// </summary>
    public static class BindDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-bind (ngBind)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBind">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-bind')")]
        public static string GetNGBind(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-bind (ngBind)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBind">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-bind', {value})")]
        public static void SetNGBind(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-bind (ngBind) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBind">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-bind')")]
        public static void RemoveNGBind(this Element el)
        {
        }
    }
}