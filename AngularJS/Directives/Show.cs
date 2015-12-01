namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngShow directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-show (ngShow)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngShow">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-show')")]
        public extern string GetShow();
        
        /// <summary>
        /// Sets a textual value to the ng-show (ngShow)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngShow">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-show', {value})")]
        public extern void SetShow(string value);
        
        /// <summary>
        /// Removes the ng-show (ngShow) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngShow">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-show')")]
        public extern void RemoveShow();
    }
}