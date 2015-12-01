namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngList directive.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-list (ngList)
        /// directive bound to the element, if any.
        /// </summary>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngList">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-list')")]
        public extern string GetList();
        
        /// <summary>
        /// Sets a textual value to the ng-list (ngList)
        /// directive on the element.
        /// </summary>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngList">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-list', {value})")]
        public extern void SetList(string value);
        
        /// <summary>
        /// Removes the ng-list (ngList) directive definition
        /// from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngList">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-list')")]
        public extern void RemoveList();
    }
}