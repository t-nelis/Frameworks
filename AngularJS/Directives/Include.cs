namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngInclude directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-include (ngInclude)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngInclude">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-include')")]
        public extern string GetInclude();
        
        /// <summary>
        /// Sets a textual value to the ng-include (ngInclude)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngInclude">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-include', {value})")]
        public extern void SetInclude(string value);
        
        /// <summary>
        /// Removes the ng-include (ngInclude) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngInclude">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-include')")]
        public extern void RemoveInclude();
    }
}