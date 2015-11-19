using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngOptions directive.
    /// </summary>
    public static class OptionsDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-options (ngOptions)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngOptions">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-options')")]
        public static string GetNGOptions(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-options (ngOptions)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngOptions">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-options', {value})")]
        public static void SetNGOptions(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-options (ngOptions) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngOptions">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-options')")]
        public static void RemoveNGOptions(this Element el)
        {
        }
    }
}