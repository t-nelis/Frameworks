using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngRepeat directive.
    /// </summary>
    public static class RepeatDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-repeat (ngRepeat)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngRepeat">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-repeat')")]
        public static string GetNGRepeat(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-repeat (ngRepeat)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngRepeat">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-repeat', {value})")]
        public static void SetNGRepeat(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-repeat (ngRepeat) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngRepeat">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-repeat')")]
        public static void RemoveNGRepeat(this Element el)
        {
        }
    }
}