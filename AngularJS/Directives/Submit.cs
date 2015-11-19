using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngSubmit directive.
    /// </summary>
    public static class SubmitDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-submit (ngSubmit)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSubmit">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-submit')")]
        public static string GetNGSubmit(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-submit (ngSubmit)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSubmit">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-submit', {value})")]
        public static void SetNGSubmit(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-submit (ngSubmit) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSubmit">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-submit')")]
        public static void RemoveNGSubmit(this Element el)
        {
        }
    }
}