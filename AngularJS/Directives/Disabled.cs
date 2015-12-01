namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngDisabled directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Sets the ng-disabled attribute for the element. This will make
        /// AngularJS create a 'aria-disabled' attribute with either false
        /// or true, depending on the result of the passed expression.
        /// </summary>
        /// <param name="expression">
        /// Expression to be evaluated as true or false.
        /// </param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngDisabled">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-disabled', {expression})")]
        public extern void SetDisabled(string expression);

        /// <summary>
        /// Sets the ng-disabled attribute for the element. This will make
        /// AngularJS create a 'aria-disabled' attribute with either false
        /// or true, depending on the result of the passed expression.
        /// </summary>
        /// <param name="value">
        /// Value to be evaluated as true or false.
        /// </param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngDisabled">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-disabled', {value})")]
        public extern void SetDisabled(bool value);

        /// <summary>
        /// Removes the ng-disabled attribute from the element (if any).
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngDisabled">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-disabled')")]
        public extern void RemoveDisabled();
    }
}