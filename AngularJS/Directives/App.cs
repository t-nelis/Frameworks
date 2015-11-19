using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Use this directive to auto-bootstrap an AngularJS application. The
    /// ngApp directive designates the root element of the application and is
    /// typically placed near the root element of the page - e.g. on the &lt;body&gt;
    /// or &lt;html&gt; tags.
    /// </summary>
    public static class AppDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-app (ngApp) value of the
        /// element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns></returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngApp">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-app')")]
        public static string GetNGApp(this Element el)
        {
            return default(string);
        }

        /// <summary>
        /// Binds the module to the page's node. Its scope will extend to any
        /// node inside this, so as controllers will be available at this point
        /// and deeper and not outside it.
        /// </summary>
        /// <param name="el">Element to be bound to the module/app</param>
        /// <param name="app">The instance of the module/app</param>
        /// <remarks>
        /// The name of the module/app filled in ng-app=[name] will be extracted
        /// from the specified instance.
        /// </remarks>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngApp">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-app', {app:raw}.name)")]
        public static void SetNGApp(this Element el, Module app)
        {
        }

        /// <summary>
        /// Binds the module to the page's node. Its scope will extend to any
        /// node inside this, so as controllers will be available at this point
        /// and deeper and not outside it.
        /// </summary>
        /// <param name="el">Element to be bound to the module/app</param>
        /// <param name="value">The name of the module/app</param>
        /// <remarks>Will add 'ng-app=value' to the element.</remarks>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngApp">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-app', {value})")]
        public static void SetNGApp(this Element el, string value)
        {
        }

        /// <summary>
        /// Removes the binding of the module to the page's node if any.
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngApp">
        /// Official JavaScript documentation.
        /// </see>
        /// </summary>
        /// <param name="el">Element to have the module unbound from</param>
        [Template("{el}.removeAttribute('ng-app')")]
        public static void RemoveNGApp(this Element el)
        {
        }
    }
}