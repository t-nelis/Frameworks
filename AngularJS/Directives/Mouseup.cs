namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngMouseup directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-mouseup (ngMouseup)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseup">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-mouseup')")]
        public extern string GetMouseup();
        
        /// <summary>
        /// Sets a textual value to the ng-mouseup (ngMouseup)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseup">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-mouseup', {value})")]
        public extern void SetMouseup(string value);
        
        /// <summary>
        /// Removes the ng-mouseup (ngMouseup) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseup">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-mouseup')")]
        public extern void RemoveMouseup();
    }
}