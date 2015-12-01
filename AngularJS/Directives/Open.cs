namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngOpen directive.
    /// </summary>
    /// <remarks>
    /// The &lt;details&gt; tag is currently in draft state and not supported
    /// by all browsers, thus not available on Bridge.Html5.
    /// Details: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/details
    /// </remarks>
    [External]
    public partial class AngularDetailsElement : AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-open (ngOpen)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngOpen">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-open')")]
        public extern string GetOpen();
        
        /// <summary>
        /// Sets a textual value to the ng-open (ngOpen)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngOpen">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-open', {value})")]
        public extern void SetOpen(string value);
        
        /// <summary>
        /// Removes the ng-open (ngOpen) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngOpen">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-open')")]
        public extern void RemoveOpen();
    }
}