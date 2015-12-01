namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngHide directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-hide (ngHide)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngHide">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-hide')")]
        public extern string GetHide();
        
        /// <summary>
        /// Sets a textual value to the ng-hide (ngHide)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngHide">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-hide', {value})")]
        public extern void SetHide(string value);
        
        /// <summary>
        /// Removes the ng-hide (ngHide) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngHide">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-hide')")]
        public extern void RemoveHide();
    }
}