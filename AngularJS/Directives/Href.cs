using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngHref directive.
    /// </summary>
    public static class HrefDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-href (ngHref)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngHref">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-href')")]
        public static string GetNGHref(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-href (ngHref)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngHref">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-href', {value})")]
        public static void SetNGHref(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-href (ngHref) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngHref">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-href')")]
        public static void RemoveNGHref(this Element el)
        {
        }
    }
}