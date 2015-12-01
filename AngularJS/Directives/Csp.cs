namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngCsp directive.
    /// </summary>
    [External]
    public partial class AngularHtmlElement : AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-csp (ngCsp)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCsp">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-csp')")]
        public extern string GetCsp();
        
        /// <summary>
        /// Sets the ng-csp (ngCsp) directive on the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCsp">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-csp')")]
        public extern void SetCsp();
        
        /// <summary>
        /// Removes the ng-csp (ngCsp) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCsp">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-csp')")]
        public extern void RemoveCsp();
    }
}