namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngPluralize directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-pluralize (ngPluralize)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPluralize">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-pluralize')")]
        public extern string GetPluralize();
        
        /// <summary>
        /// Sets a textual value to the ng-pluralize (ngPluralize)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPluralize">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-pluralize', {value})")]
        public extern void SetPluralize(string value);
        
        /// <summary>
        /// Removes the ng-pluralize (ngPluralize) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPluralize">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-pluralize')")]
        public extern void RemovePluralize();
    }
}