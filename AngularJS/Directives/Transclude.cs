namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngTransclude directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-transclude (ngTransclude)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngTransclude">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-transclude')")]
        public extern string GetTransclude();
        
        /// <summary>
        /// Sets a textual value to the ng-transclude (ngTransclude)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngTransclude">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-transclude', {value})")]
        public extern void SetTransclude(string value);
        
        /// <summary>
        /// Removes the ng-transclude (ngTransclude) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngTransclude">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-transclude')")]
        public extern void RemoveTransclude();
    }
}