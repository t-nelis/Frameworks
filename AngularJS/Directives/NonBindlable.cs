namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngNonBindlable directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-nonbindlable (ngNonBindlable)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngNonBindlable">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-nonbindlable')")]
        public extern string GetNonBindlable();
        
        /// <summary>
        /// Sets a textual value to the ng-nonbindlable (ngNonBindlable)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngNonBindlable">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-nonbindlable', {value})")]
        public extern void SetNonBindlable(string value);
        
        /// <summary>
        /// Removes the ng-nonbindlable (ngNonBindlable) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngNonBindlable">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-nonbindlable')")]
        public extern void RemoveNonBindlable();
    }
}