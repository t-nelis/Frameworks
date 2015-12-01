namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngJq directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-jq (ngJq)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngJq">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-jq')")]
        public extern string GetJq();
        
        /// <summary>
        /// Sets a textual value to the ng-jq (ngJq)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngJq">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-jq', {value})")]
        public extern void SetJq(string value);
        
        /// <summary>
        /// Removes the ng-jq (ngJq) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngJq">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-jq')")]
        public extern void RemoveJq();
    }
}