using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngClassEven directive.
    /// </summary>
    public static class ClassEvenDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-classeven (ngClassEven)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClassEven">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-classeven')")]
        public static string GetNGClassEven(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-classeven (ngClassEven)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClassEven">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-classeven', {value})")]
        public static void SetNGClassEven(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-classeven (ngClassEven) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClassEven">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-classeven')")]
        public static void RemoveNGClassEven(this Element el)
        {
        }
    }
}