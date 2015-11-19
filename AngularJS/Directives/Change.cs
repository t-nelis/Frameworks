using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngChange directive.
    /// </summary>
    public static class ChangeDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-change (ngChange)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngChange">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-change')")]
        public static string GetNGChange(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-change (ngChange)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngChange">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-change', {value})")]
        public static void SetNGChange(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-change (ngChange) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngChange">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-change')")]
        public static void RemoveNGChange(this Element el)
        {
        }
    }
}