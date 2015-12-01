namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngClassOdd directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-classodd (ngClassOdd)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClassOdd">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-classodd')")]
        public extern string GetClassOdd();
        
        /// <summary>
        /// Sets a textual value to the ng-classodd (ngClassOdd)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClassOdd">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-classodd', {value})")]
        public extern void SetClassOdd(string value);
        
        /// <summary>
        /// Removes the ng-classodd (ngClassOdd) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngClassOdd">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-classodd')")]
        public extern void RemoveClassOdd();
    }
}