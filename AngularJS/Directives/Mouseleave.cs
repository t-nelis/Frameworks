namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngMouseleave directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-mouseleave (ngMouseleave)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseleave">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-mouseleave')")]
        public extern string GetMouseleave();
        
        /// <summary>
        /// Sets a textual value to the ng-mouseleave (ngMouseleave)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseleave">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-mouseleave', {value})")]
        public extern void SetMouseleave(string value);
        
        /// <summary>
        /// Removes the ng-mouseleave (ngMouseleave) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngMouseleave">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-mouseleave')")]
        public extern void RemoveMouseleave();
    }
}