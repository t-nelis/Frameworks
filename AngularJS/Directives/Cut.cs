namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngCut directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-cut (ngCut)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCut">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-cut')")]
        public extern string GetCut();
        
        /// <summary>
        /// Sets a textual value to the ng-cut (ngCut)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCut">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-cut', {value})")]
        public extern void SetCut(string value);
        
        /// <summary>
        /// Removes the ng-cut (ngCut) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngCut">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-cut')")]
        public extern void RemoveCut();
    }
}