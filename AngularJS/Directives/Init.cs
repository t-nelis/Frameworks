using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngInit directive.
    /// </summary>
    public static class InitDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-init (ngInit)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngInit">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-init')")]
        public static string GetNGInit(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-init (ngInit)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngInit">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-init', {value})")]
        public static void SetNGInit(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-init (ngInit) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngInit">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-init')")]
        public static void RemoveNGInit(this Element el)
        {
        }
    }
}