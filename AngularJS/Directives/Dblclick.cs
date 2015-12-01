namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngDblclick directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-dblclick (ngDblclick)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngDblclick">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-dblclick')")]
        public extern string GetDblclick();
        
        /// <summary>
        /// Sets a textual value to the ng-dblclick (ngDblclick)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngDblclick">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-dblclick', {value})")]
        public extern void SetDblclick(string value);
        
        /// <summary>
        /// Removes the ng-dblclick (ngDblclick) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngDblclick">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-dblclick')")]
        public extern void RemoveDblclick();
    }
}