using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngBindHtml directive.
    /// </summary>
    public static class BindHtmlDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-bindhtml (ngBindHtml)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBindHtml">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-bindhtml')")]
        public static string GetNGBindHtml(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-bindhtml (ngBindHtml)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBindHtml">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-bindhtml', {value})")]
        public static void SetNGBindHtml(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-bindhtml (ngBindHtml) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBindHtml">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-bindhtml')")]
        public static void RemoveNGBindHtml(this Element el)
        {
        }
    }
}