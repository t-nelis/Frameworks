namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngKeypress directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-keypress (ngKeypress)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngKeypress">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-keypress')")]
        public extern string GetKeypress();
        
        /// <summary>
        /// Sets a textual value to the ng-keypress (ngKeypress)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngKeypress">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-keypress', {value})")]
        public extern void SetKeypress(string value);
        
        /// <summary>
        /// Removes the ng-keypress (ngKeypress) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngKeypress">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-keypress')")]
        public extern void RemoveKeypress();
    }
}