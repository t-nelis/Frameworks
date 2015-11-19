using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngList directive.
    /// </summary>
    public static class ListDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-list (ngList)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngList">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-list')")]
        public static string GetNGList(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-list (ngList)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngList">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-list', {value})")]
        public static void SetNGList(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-list (ngList) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngList">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-list')")]
        public static void RemoveNGList(this Element el)
        {
        }
    }
}