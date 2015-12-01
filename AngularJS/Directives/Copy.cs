namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngCopy directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-copy (ngCopy)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCopy">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-copy')")]
        public extern string GetCopy();
        
        /// <summary>
        /// Sets a textual value to the ng-copy (ngCopy)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCopy">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-copy', {value})")]
        public extern void SetCopy(string value);
        
        /// <summary>
        /// Removes the ng-copy (ngCopy) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCopy">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-copy')")]
        public extern void RemoveCopy();
    }
}