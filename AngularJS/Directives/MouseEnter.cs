namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngMouseEnter directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-mouseenter (ngMouseEnter)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseEnter">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-mouseenter')")]
        public extern string GetMouseEnter();
        
        /// <summary>
        /// Sets a textual value to the ng-mouseenter (ngMouseEnter)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseEnter">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-mouseenter', {value})")]
        public extern void SetMouseEnter(string value);
        
        /// <summary>
        /// Removes the ng-mouseenter (ngMouseEnter) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseEnter">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-mouseenter')")]
        public extern void RemoveMouseEnter();
    }
}