namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngHref directive.
    /// </summary>
    [External]
    public partial class AngularAnchorElement : AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-href (ngHref)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngHref">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-href')")]
        public extern string GetHref();
        
        /// <summary>
        /// Sets a textual value to the ng-href (ngHref)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngHref">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-href', {value})")]
        public extern void SetHref(string value);
        
        /// <summary>
        /// Removes the ng-href (ngHref) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngHref">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-href')")]
        public extern void RemoveHref();
    }
}