namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngIf directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-if (ngIf)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngIf">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-if')")]
        public extern string GetIf();
        
        /// <summary>
        /// Sets a textual value to the ng-if (ngIf)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngIf">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-if', {value})")]
        public extern void SetIf(string value);
        
        /// <summary>
        /// Removes the ng-if (ngIf) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngIf">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-if')")]
        public extern void RemoveIf();
    }
}