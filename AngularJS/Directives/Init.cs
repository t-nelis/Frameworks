namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngInit directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-init (ngInit)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngInit">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-init')")]
        public extern string GetInit();
        
        /// <summary>
        /// Sets a textual value to the ng-init (ngInit)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngInit">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-init', {value})")]
        public extern void SetInit(string value);
        
        /// <summary>
        /// Removes the ng-init (ngInit) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngInit">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-init')")]
        public extern void RemoveInit();
    }
}