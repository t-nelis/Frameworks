namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngClass directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-class (ngClass)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClass">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-class')")]
        public extern string GetClass();
        
        /// <summary>
        /// Sets a textual value to the ng-class (ngClass)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClass">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-class', {value})")]
        public extern void SetClass(string value);
        
        /// <summary>
        /// Removes the ng-class (ngClass) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClass">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-class')")]
        public extern void RemoveClass();
    }
}