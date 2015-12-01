namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngMousemove directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-mousemove (ngMousemove)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMousemove">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-mousemove')")]
        public extern string GetMousemove();
        
        /// <summary>
        /// Sets a textual value to the ng-mousemove (ngMousemove)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMousemove">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-mousemove', {value})")]
        public extern void SetMousemove(string value);
        
        /// <summary>
        /// Removes the ng-mousemove (ngMousemove) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMousemove">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-mousemove')")]
        public extern void RemoveMousemove();
    }
}