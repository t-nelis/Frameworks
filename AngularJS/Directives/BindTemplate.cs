namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngBindTemplate directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-bindtemplate (ngBindTemplate)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBindTemplate">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-bindtemplate')")]
        public extern string GetBindTemplate();
        
        /// <summary>
        /// Sets a textual value to the ng-bindtemplate (ngBindTemplate)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBindTemplate">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-bindtemplate', {value})")]
        public extern void SetBindTemplate(string value);
        
        /// <summary>
        /// Removes the ng-bindtemplate (ngBindTemplate) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBindTemplate">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-bindtemplate')")]
        public extern void RemoveBindTemplate();
    }
}