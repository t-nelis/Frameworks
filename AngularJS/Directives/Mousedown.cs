namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngMousedown directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-mousedown (ngMousedown)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMousedown">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-mousedown')")]
        public extern string GetMousedown();
        
        /// <summary>
        /// Sets a textual value to the ng-mousedown (ngMousedown)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMousedown">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-mousedown', {value})")]
        public extern void SetMousedown(string value);
        
        /// <summary>
        /// Removes the ng-mousedown (ngMousedown) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMousedown">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-mousedown')")]
        public extern void RemoveMousedown();
    }
}