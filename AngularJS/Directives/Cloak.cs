namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngCloak directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-cloak (ngCloak)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCloak">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-cloak')")]
        public extern string GetCloak();
        
        /// <summary>
        /// Sets a textual value to the ng-cloak (ngCloak)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCloak">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-cloak', {value})")]
        public extern void SetCloak(string value);
        
        /// <summary>
        /// Removes the ng-cloak (ngCloak) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCloak">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-cloak')")]
        public extern void RemoveCloak();
    }
}