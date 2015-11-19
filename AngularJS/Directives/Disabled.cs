using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngDisabled directive.
    /// </summary>
    public static class DisabledDirectives
    {
        /// <summary>
        /// Sets the ng-disabled attribute for the element. This will make
        /// AngularJS create a 'aria-disabled' attribute with either false
        /// or true, depending on the result of the passed expression.
        /// </summary>
        /// <param name="el">Own element reference.</param>
        /// <param name="expression">
        /// Expression to be evaluated as true or false.
        /// </param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngDisabled">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-disabled', {expression})")]
        public static void SetNGDisabled(this Element el, string expression)
        {
        }

        /// <summary>
        /// Sets the ng-disabled attribute for the element. This will make
        /// AngularJS create a 'aria-disabled' attribute with either false
        /// or true, depending on the result of the passed expression.
        /// </summary>
        /// <param name="el">Own element reference.</param>
        /// <param name="value">
        /// Value to be evaluated as true or false.
        /// </param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngDisabled">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-disabled', {value})")]
        public static void SetNGDisabled(this Element el, bool value)
        {
        }

        /// <summary>
        /// Removes the ng-disabled attribute from the element (if any).
        /// </summary>
        /// <param name="el">Own element reference.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngDisabled">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-disabled')")]
        public static void RemoveNGDisabled(this Element el)
        {
        }
    }
}