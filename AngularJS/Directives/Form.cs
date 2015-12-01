namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngForm directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-form (ngForm)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngForm">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-form')")]
        public extern string GetForm();
        
        /// <summary>
        /// Sets a textual value to the ng-form (ngForm)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngForm">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-form', {value})")]
        public extern void SetForm(string value);
        
        /// <summary>
        /// Removes the ng-form (ngForm) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngForm">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-form')")]
        public extern void RemoveForm();
    }
}