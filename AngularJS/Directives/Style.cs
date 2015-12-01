namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngStyle directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-style (ngStyle)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngStyle">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-style')")]
        public extern string GetStyle();
        
        /// <summary>
        /// Sets a textual value to the ng-style (ngStyle)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngStyle">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-style', {value})")]
        public extern void SetStyle(string value);
        
        /// <summary>
        /// Removes the ng-style (ngStyle) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngStyle">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-style')")]
        public extern void RemoveStyle();
    }
}