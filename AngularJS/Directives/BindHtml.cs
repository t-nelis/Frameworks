namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngBindHtml directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-bindhtml (ngBindHtml)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBindHtml">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-bindhtml')")]
        public extern string GetBindHtml();
        
        /// <summary>
        /// Sets a textual value to the ng-bindhtml (ngBindHtml)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBindHtml">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-bindhtml', {value})")]
        public extern void SetBindHtml(string value);
        
        /// <summary>
        /// Removes the ng-bindhtml (ngBindHtml) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBindHtml">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-bindhtml')")]
        public extern void RemoveBindHtml();
    }
}