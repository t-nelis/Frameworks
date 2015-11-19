using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngController directive.
    /// </summary>
    public static class ControllerDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-app (ngApp) value of the
        /// element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns></returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngController">Official JavaScript documentation.</see>
        [Template("{el}.getAttribute('ng-controller')")]
        public static string GetNGController(this Element el)
        {
            return default(string);
        }

        /// <summary>
        /// Binds a controller to the HTML element. The controller's module must
        /// have this element into its scope or it will be ignored.
        /// </summary>
        /// <param name="el">Element to be bound to the controller</param>
        /// <param name="value">The name of the controller</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngController">Official JavaScript documentation.</see>
        [Template("{el}.setAttribute('ng-controller', {value})")]
        public static void SetNGController(this Element el, string value)
        {
        }

        /// <summary>
        /// Drops the NG controller from the specified element.
        /// </summary>
        /// <param name="el">Element to drop the ngController from.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngController">Official JavaScript documentation.</see>
        [Template("{el}.removeAttribute('ng-controller')")]
        public static void RemoveNGController(this Element el)
        {
        }

        // TODO: support instance of the controller referenced/cycled thru
        //       the module's controller list
    }
}