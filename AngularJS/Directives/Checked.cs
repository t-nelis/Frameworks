namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngChecked directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-checked (ngChecked)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngChecked">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-checked')")]
        public extern string GetChecked();
        
        /// <summary>
        /// Sets a textual value to the ng-checked (ngChecked)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngChecked">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-checked', {value})")]
        public extern void SetChecked(string value);
        
        /// <summary>
        /// Removes the ng-checked (ngChecked) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngChecked">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-checked')")]
        public extern void RemoveChecked();
    }
}