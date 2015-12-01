namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngValue directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-value (ngValue)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngValue">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-value')")]
        public extern string GetValue();
        
        /// <summary>
        /// Sets a textual value to the ng-value (ngValue)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngValue">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-value', {value})")]
        public extern void SetValue(string value);
        
        /// <summary>
        /// Removes the ng-value (ngValue) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngValue">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-value')")]
        public extern void RemoveValue();
    }
}