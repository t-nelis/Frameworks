using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngInclude directive.
    /// </summary>
    public static class IncludeDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-include (ngInclude)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngInclude">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-include')")]
        public static string GetNGInclude(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-include (ngInclude)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngInclude">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-include', {value})")]
        public static void SetNGInclude(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-include (ngInclude) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngInclude">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-include')")]
        public static void RemoveNGInclude(this Element el)
        {
        }
    }
}