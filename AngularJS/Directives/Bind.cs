namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngBind directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-bind (ngBind)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBind">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-bind')")]
        public extern string GetBind();
        
        /// <summary>
        /// Sets a textual value to the ng-bind (ngBind)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBind">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-bind', {value})")]
        public extern void SetBind(string value);
        
        /// <summary>
        /// Removes the ng-bind (ngBind) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngBind">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-bind')")]
        public extern void RemoveBind();
    }
}