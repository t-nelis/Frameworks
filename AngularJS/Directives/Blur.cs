namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngBlur directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-blur (ngBlur)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBlur">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-blur')")]
        public extern string GetBlur();
        
        /// <summary>
        /// Sets a textual value to the ng-blur (ngBlur)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBlur">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-blur', {value})")]
        public extern void SetBlur(string value);
        
        /// <summary>
        /// Removes the ng-blur (ngBlur) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBlur">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-blur')")]
        public extern void RemoveBlur();
    }
}