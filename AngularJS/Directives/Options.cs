namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngOptions directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-options (ngOptions)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngOptions">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-options')")]
        public extern string GetOptions();
        
        /// <summary>
        /// Sets a textual value to the ng-options (ngOptions)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngOptions">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-options', {value})")]
        public extern void SetOptions(string value);
        
        /// <summary>
        /// Removes the ng-options (ngOptions) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngOptions">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-options')")]
        public extern void RemoveOptions();
    }
}