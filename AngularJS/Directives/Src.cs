namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngSrc directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-src (ngSrc)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSrc">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-src')")]
        public extern string GetSrc();
        
        /// <summary>
        /// Sets a textual value to the ng-src (ngSrc)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSrc">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-src', {value})")]
        public extern void SetSrc(string value);
        
        /// <summary>
        /// Removes the ng-src (ngSrc) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSrc">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-src')")]
        public extern void RemoveSrc();
    }
}