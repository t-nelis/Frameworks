namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngOpen directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-open (ngOpen)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngOpen">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-open')")]
        public extern string GetOpen();
        
        /// <summary>
        /// Sets a textual value to the ng-open (ngOpen)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngOpen">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-open', {value})")]
        public extern void SetOpen(string value);
        
        /// <summary>
        /// Removes the ng-open (ngOpen) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngOpen">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-open')")]
        public extern void RemoveOpen();
    }
}