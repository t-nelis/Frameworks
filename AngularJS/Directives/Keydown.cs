namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngKeydown directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-keydown (ngKeydown)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngKeydown">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-keydown')")]
        public extern string GetKeydown();
        
        /// <summary>
        /// Sets a textual value to the ng-keydown (ngKeydown)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngKeydown">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-keydown', {value})")]
        public extern void SetKeydown(string value);
        
        /// <summary>
        /// Removes the ng-keydown (ngKeydown) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngKeydown">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-keydown')")]
        public extern void RemoveKeydown();
    }
}