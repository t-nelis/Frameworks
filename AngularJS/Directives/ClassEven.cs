namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngClassEven directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-classeven (ngClassEven)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClassEven">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-classeven')")]
        public extern string GetClassEven();
        
        /// <summary>
        /// Sets a textual value to the ng-classeven (ngClassEven)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClassEven">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-classeven', {value})")]
        public extern void SetClassEven(string value);
        
        /// <summary>
        /// Removes the ng-classeven (ngClassEven) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClassEven">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-classeven')")]
        public extern void RemoveClassEven();
    }
}