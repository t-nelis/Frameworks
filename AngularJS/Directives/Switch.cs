namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngSwitch directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-switch (ngSwitch)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSwitch">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-switch')")]
        public extern string GetSwitch();
        
        /// <summary>
        /// Sets a textual value to the ng-switch (ngSwitch)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSwitch">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-switch', {value})")]
        public extern void SetSwitch(string value);
        
        /// <summary>
        /// Removes the ng-switch (ngSwitch) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSwitch">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-switch')")]
        public extern void RemoveSwitch();

        /// <summary>
        /// Gets the current textual value of ng-switch-when (ngSwitchWhen)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSwitch">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-switch-when')")]
        public extern string GetSwitchWhen();

        /// <summary>
        /// Sets a textual value to the ng-switch-when (ngSwitchWhen)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSwitch">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-switch-when', {value})")]
        public extern void SetSwitchWhen(string value);

        /// <summary>
        /// Removes the ng-switch-when (ngSwitchWhen) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSwitch">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-switch-when')")]
        public extern void RemoveSwitchWhen();

        /// <summary>
        /// Gets the current textual value of ng-switch-default (ngSwitchDefault)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSwitch">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-switch-default')")]
        public extern string GetSwitchDefault();

        /// <summary>
        /// Sets a textual value to the ng-switch-default (ngSwitchDefault)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSwitch">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-switch-default', {value})")]
        public extern void SetSwitchDefault(string value);

        /// <summary>
        /// Removes the ng-switch-default (ngSwitchDefault) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSwitch">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-switch-default')")]
        public extern void RemoveSwitchDefault();
    }
}