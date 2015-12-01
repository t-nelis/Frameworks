namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngSelected directive.
    /// </summary>
    [External]
    public partial class AngularOptionElement : AngularInputElement
    {
        /// <summary>
        /// Gets the current textual value of ng-selected (ngSelected)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSelected">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-selected')")]
        public extern string GetSelected();
        
        /// <summary>
        /// Sets a textual value to the ng-selected (ngSelected)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSelected">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-selected', {value})")]
        public extern void SetSelected(string value);
        
        /// <summary>
        /// Removes the ng-selected (ngSelected) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSelected">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-selected')")]
        public extern void RemoveSelected();
    }
}