namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngFocus directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-focus (ngFocus)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngFocus">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-focus')")]
        public extern string GetFocus();
        
        /// <summary>
        /// Sets a textual value to the ng-focus (ngFocus)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngFocus">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-focus', {value})")]
        public extern void SetFocus(string value);
        
        /// <summary>
        /// Removes the ng-focus (ngFocus) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngFocus">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-focus')")]
        public extern void RemoveFocus();
    }
}