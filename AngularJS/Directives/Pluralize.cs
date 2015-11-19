using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngPluralize directive.
    /// </summary>
    public static class PluralizeDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-pluralize (ngPluralize)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPluralize">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-pluralize')")]
        public static string GetNGPluralize(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-pluralize (ngPluralize)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPluralize">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-pluralize', {value})")]
        public static void SetNGPluralize(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-pluralize (ngPluralize) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPluralize">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-pluralize')")]
        public static void RemoveNGPluralize(this Element el)
        {
        }
    }
}