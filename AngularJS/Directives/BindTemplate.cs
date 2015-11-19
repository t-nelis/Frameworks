using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngBindTemplate directive.
    /// </summary>
    public static class BindTemplateDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-bindtemplate (ngBindTemplate)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBindTemplate">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-bindtemplate')")]
        public static string GetNGBindTemplate(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-bindtemplate (ngBindTemplate)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBindTemplate">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-bindtemplate', {value})")]
        public static void SetNGBindTemplate(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-bindtemplate (ngBindTemplate) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBindTemplate">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-bindtemplate')")]
        public static void RemoveNGBindTemplate(this Element el)
        {
        }
    }
}