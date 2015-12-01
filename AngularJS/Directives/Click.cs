namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngClick directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-click (ngClick)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClick">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-click')")]
        public extern string GetClick();
        
        /// <summary>
        /// Sets a textual value to the ng-click (ngClick)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClick">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-click', {value})")]
        public extern void SetClick(string value);
        
        /// <summary>
        /// Removes the ng-click (ngClick) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClick">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-click')")]
        public extern void RemoveClick();
    }
}