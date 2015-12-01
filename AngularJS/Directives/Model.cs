namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngModel directive.
    /// </summary>
    [External]
    public partial class AngularInputElement : AngularElement
    {
        /// <summary>
        /// Gets the NG model name.
        /// </summary>
        /// <returns>The NG model name.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngModel">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-model')")]
        public extern string GetModel();

        /// <summary>
        /// Sets the NG model reference to the specified element.
        /// </summary>
        /// <param name="modelName">Name for the model applied.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngModel">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-model', {modelName})")]
        public extern void SetModel(string modelName);
        /// <summary>
        /// Drops the NG model attribute from the element.
        /// </summary>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngModel">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.removeAttribute('ng-model')")]
        public extern void RemoveModel();
    }
}