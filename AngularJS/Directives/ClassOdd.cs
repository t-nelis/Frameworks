using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngClassOdd directive.
    /// </summary>
    public static class ClassOddDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-classodd (ngClassOdd)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClassOdd">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-classodd')")]
        public static string GetNGClassOdd(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-classodd (ngClassOdd)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClassOdd">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-classodd', {value})")]
        public static void SetNGClassOdd(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-classodd (ngClassOdd) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClassOdd">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-classodd')")]
        public static void RemoveNGClassOdd(this Element el)
        {
        }
    }
}