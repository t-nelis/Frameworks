namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngSrcset directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-srcset (ngSrcset)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSrcset">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-srcset')")]
        public extern string GetSrcset();
        
        /// <summary>
        /// Sets a textual value to the ng-srcset (ngSrcset)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSrcset">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-srcset', {value})")]
        public extern void SetSrcset(string value);
        
        /// <summary>
        /// Removes the ng-srcset (ngSrcset) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSrcset">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-srcset')")]
        public extern void RemoveSrcset();
    }
}