namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngPluralize directive.
    /// You configure ngPluralize by providing 2 attributes: count and when.
    /// You can also provide an optional attribute, offset.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of 'count' directive
        /// bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPluralize">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('count')")]
        public extern string GetCount();

        /// <summary>
        /// Sets a textual value to the 'count' directive
        /// on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPluralize">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('count', {value})")]
        public extern void SetCount(string value);

        /// <summary>
        /// Removes the 'count' directive definition from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPluralize">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('count')")]
        public extern void RemoveCount();
        /// <summary>
        /// Gets the current textual value of 'when' directive
        /// bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPluralize">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('when')")]
        public extern string GetWhen();

        /// <summary>
        /// Sets a textual value to the 'when' directive
        /// on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPluralize">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('when', {value})")]
        public extern void SetWhen(string value);

        /// <summary>
        /// Removes the 'when' directive definition from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPluralize">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('when')")]
        public extern void RemoveWhen();

        /// <summary>
        /// Gets the current textual value of 'offset' directive
        /// bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPluralize">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('offset')")]
        public extern string GetOffset();

        /// <summary>
        /// Sets a textual value to the 'offset' directive
        /// on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPluralize">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('offset', {value})")]
        public extern void SetOffset(string value);

        /// <summary>
        /// Removes the 'offset' directive definition from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngPluralize">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('offset')")]
        public extern void RemoveOffset();
    }
}