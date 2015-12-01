namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngController directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-app (ngApp) value of the
        /// element, if any.
        /// </summary>
        /// <returns></returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngController">Official JavaScript documentation.</see>
        [Template("{this}.getAttribute('ng-controller')")]
        public extern string GetController();

        /// <summary>
        /// Binds a controller to the HTML element. The controller's module must
        /// have this element into its scope or it will be ignored.
        /// </summary>
        /// <param name="value">The name of the controller</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngController">Official JavaScript documentation.</see>
        [Template("{this}.setAttribute('ng-controller', {value})")]
        public extern void SetController(string value);

        /// <summary>
        /// Drops the NG controller from the specified element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngController">Official JavaScript documentation.</see>
        [Template("{this}.removeAttribute('ng-controller')")]
        public extern void RemoveController();

        // TODO: support instance of the controller referenced/cycled thru
        //       the module's controller list
    }
}