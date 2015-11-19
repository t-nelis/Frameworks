using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngClass directive.
    /// </summary>
    public static class ClassDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-class (ngClass)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClass">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-class')")]
        public static string GetNGClass(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-class (ngClass)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClass">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-class', {value})")]
        public static void SetNGClass(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-class (ngClass) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClass">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-class')")]
        public static void RemoveNGClass(this Element el)
        {
        }
    }
}