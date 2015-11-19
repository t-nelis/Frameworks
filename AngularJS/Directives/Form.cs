using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngForm directive.
    /// </summary>
    public static class FormDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-form (ngForm)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngForm">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-form')")]
        public static string GetNGForm(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-form (ngForm)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngForm">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-form', {value})")]
        public static void SetNGForm(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-form (ngForm) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngForm">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-form')")]
        public static void RemoveNGForm(this Element el)
        {
        }
    }
}