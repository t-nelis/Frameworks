using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngDblclick directive.
    /// </summary>
    public static class DblclickDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-dblclick (ngDblclick)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngDblclick">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-dblclick')")]
        public static string GetNGDblclick(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-dblclick (ngDblclick)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngDblclick">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-dblclick', {value})")]
        public static void SetNGDblclick(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-dblclick (ngDblclick) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngDblclick">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-dblclick')")]
        public static void RemoveNGDblclick(this Element el)
        {
        }
    }
}