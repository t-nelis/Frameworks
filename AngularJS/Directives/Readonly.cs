namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngReadonly directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-readonly (ngReadonly)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngReadonly">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-readonly')")]
        public extern string GetReadonly();
        
        /// <summary>
        /// Sets a textual value to the ng-readonly (ngReadonly)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngReadonly">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-readonly', {value})")]
        public extern void SetReadonly(string value);
        
        /// <summary>
        /// Removes the ng-readonly (ngReadonly) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngReadonly">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-readonly')")]
        public extern void RemoveReadonly();
    }
}