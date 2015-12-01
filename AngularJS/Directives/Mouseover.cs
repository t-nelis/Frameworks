namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngMouseover directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-mouseover (ngMouseover)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseover">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-mouseover')")]
        public extern string GetMouseover();
        
        /// <summary>
        /// Sets a textual value to the ng-mouseover (ngMouseover)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseover">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-mouseover', {value})")]
        public extern void SetMouseover(string value);
        
        /// <summary>
        /// Removes the ng-mouseover (ngMouseover) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseover">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-mouseover')")]
        public extern void RemoveMouseover();
    }
}