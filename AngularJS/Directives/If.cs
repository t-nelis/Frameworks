using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngIf directive.
    /// </summary>
    public static class IfDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-if (ngIf)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngIf">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-if')")]
        public static string GetNGIf(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-if (ngIf)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngIf">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-if', {value})")]
        public static void SetNGIf(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-if (ngIf) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngIf">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-if')")]
        public static void RemoveNGIf(this Element el)
        {
        }
    }
}