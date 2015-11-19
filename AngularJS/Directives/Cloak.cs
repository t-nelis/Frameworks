using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngCloak directive.
    /// </summary>
    public static class CloakDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-cloak (ngCloak)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCloak">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-cloak')")]
        public static string GetNGCloak(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-cloak (ngCloak)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCloak">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-cloak', {value})")]
        public static void SetNGCloak(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-cloak (ngCloak) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCloak">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-cloak')")]
        public static void RemoveNGCloak(this Element el)
        {
        }
    }
}