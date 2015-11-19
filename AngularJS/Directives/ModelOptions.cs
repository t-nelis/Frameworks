using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngModelOptions directive.
    /// </summary>
    public static class ModelOptionsDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-modeloptions (ngModelOptions)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngModelOptions">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-modeloptions')")]
        public static string GetNGModelOptions(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-modeloptions (ngModelOptions)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngModelOptions">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-modeloptions', {value})")]
        public static void SetNGModelOptions(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-modeloptions (ngModelOptions) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngModelOptions">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-modeloptions')")]
        public static void RemoveNGModelOptions(this Element el)
        {
        }
    }
}