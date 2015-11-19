using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngChecked directive.
    /// </summary>
    public static class CheckedDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-checked (ngChecked)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngChecked">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-checked')")]
        public static string GetNGChecked(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-checked (ngChecked)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngChecked">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-checked', {value})")]
        public static void SetNGChecked(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-checked (ngChecked) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngChecked">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-checked')")]
        public static void RemoveNGChecked(this Element el)
        {
        }
    }
}