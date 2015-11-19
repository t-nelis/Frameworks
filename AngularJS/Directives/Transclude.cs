using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngTransclude directive.
    /// </summary>
    public static class TranscludeDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-transclude (ngTransclude)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngTransclude">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-transclude')")]
        public static string GetNGTransclude(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-transclude (ngTransclude)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngTransclude">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-transclude', {value})")]
        public static void SetNGTransclude(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-transclude (ngTransclude) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngTransclude">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-transclude')")]
        public static void RemoveNGTransclude(this Element el)
        {
        }
    }
}