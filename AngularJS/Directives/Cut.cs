using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngCut directive.
    /// </summary>
    public static class CutDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-cut (ngCut)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCut">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-cut')")]
        public static string GetNGCut(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-cut (ngCut)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCut">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-cut', {value})")]
        public static void SetNGCut(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-cut (ngCut) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCut">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-cut')")]
        public static void RemoveNGCut(this Element el)
        {
        }
    }
}