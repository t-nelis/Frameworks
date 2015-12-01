namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngPaste directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-paste (ngPaste)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPaste">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-paste')")]
        public extern string GetPaste();
        
        /// <summary>
        /// Sets a textual value to the ng-paste (ngPaste)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPaste">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-paste', {value})")]
        public extern void SetPaste(string value);
        
        /// <summary>
        /// Removes the ng-paste (ngPaste) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPaste">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-paste')")]
        public extern void RemovePaste();
    }
}