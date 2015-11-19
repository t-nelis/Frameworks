using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngSwitch directive.
    /// </summary>
    public static class SwitchDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-switch (ngSwitch)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSwitch">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-switch')")]
        public static string GetNGSwitch(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-switch (ngSwitch)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSwitch">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-switch', {value})")]
        public static void SetNGSwitch(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-switch (ngSwitch) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngSwitch">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-switch')")]
        public static void RemoveNGSwitch(this Element el)
        {
        }
    }
}