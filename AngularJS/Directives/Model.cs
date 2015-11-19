using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngModel directive.
    /// </summary>
    public static class ModelDirectives
    {
        /// <summary>
        /// Gets the NG model name.
        /// </summary>
        /// <returns>The NG model name.</returns>
        /// <param name="el">Element to get the ngModel name from</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngModel">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-model')")]
        public static string GetNGModel(this Element el)
        {
            return null;
        }

        /// <summary>
        /// Sets the NG model reference to the specified element.
        /// </summary>
        /// <param name="el">Element to get the ngModel reference.</param>
        /// <param name="modelName">Name for the model applied.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngModel">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-model', {modelName})")]
        public static void SetNGModel(this Element el, string modelName)
        {
        }
        /// <summary>
        /// Drops the NG model attribute from the element.
        /// </summary>
        /// <param name="el">
        /// Element to have the ngModel attribute removed.
        /// </param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngModel">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-model')")]
        public static void RemoveNGModel(this Element el)
        {
        }
    }
}