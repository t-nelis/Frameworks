namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngSubmit directive.
    /// </summary>
    [External]
    public partial class AngularFormElement : AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-submit (ngSubmit)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSubmit">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-submit')")]
        public extern string GetSubmit();
        
        /// <summary>
        /// Sets a textual value to the ng-submit (ngSubmit)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSubmit">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-submit', {value})")]
        public extern void SetSubmit(string value);
        
        /// <summary>
        /// Removes the ng-submit (ngSubmit) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSubmit">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-submit')")]
        public extern void RemoveSubmit();
    }
}