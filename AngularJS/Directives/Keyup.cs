namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngKeyup directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-keyup (ngKeyup)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngKeyup">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-keyup')")]
        public extern string GetKeyup();
        
        /// <summary>
        /// Sets a textual value to the ng-keyup (ngKeyup)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngKeyup">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-keyup', {value})")]
        public extern void SetKeyup(string value);
        
        /// <summary>
        /// Removes the ng-keyup (ngKeyup) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngKeyup">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-keyup')")]
        public extern void RemoveKeyup();
    }
}