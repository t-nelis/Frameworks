using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngReadonly directive.
    /// </summary>
    public static class ReadonlyDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-readonly (ngReadonly)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngReadonly">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-readonly')")]
        public static string GetNGReadonly(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-readonly (ngReadonly)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngReadonly">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-readonly', {value})")]
        public static void SetNGReadonly(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-readonly (ngReadonly) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngReadonly">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-readonly')")]
        public static void RemoveNGReadonly(this Element el)
        {
        }
    }
}