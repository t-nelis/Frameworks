namespace Bridge.AngularJS
{
    /// <summary>
    /// Use this directive to auto-bootstrap an AngularJS application. The
    /// ngApp directive designates the root element of the application and is
    /// typically placed near the root element of the page - e.g. on the &lt;body&gt;
    /// or &lt;html&gt; tags.
    /// </summary>
    [External]
    public partial class AngularElement
    {
        /// <summary>
        /// Gets the current textual value of ng-app (ngApp) value of the
        /// element, if any.
        /// </summary>
        /// <returns></returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngApp">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.getAttribute('ng-app')")]
        public extern string GetApp();

        /// <summary>
        /// Binds the module to the page's node. Its scope will extend to any
        /// node inside this, so as controllers will be available at this point
        /// and deeper and not outside it.
        /// </summary>
        /// <param name="app">The instance of the module/app</param>
        /// <remarks>
        /// The name of the module/app filled in ng-app=[name] will be extracted
        /// from the specified instance.
        /// </remarks>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngApp">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-app', {app:raw}.name)")]
        public extern void SetApp(Module app);

        /// <summary>
        /// Binds the module to the page's node. Its scope will extend to any
        /// node inside this, so as controllers will be available at this point
        /// and deeper and not outside it.
        /// </summary>
        /// <param name="value">The name of the module/app</param>
        /// <remarks>Will add 'ng-app=value' to the element.</remarks>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngApp">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{this}.setAttribute('ng-app', {value})")]
        public extern void SetApp(string value);

        /// <summary>
        /// Removes the binding of the module to the page's node if any.
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngApp">
        /// Official JavaScript documentation.
        /// </see>
        /// </summary>
        [Template("{this}.removeAttribute('ng-app')")]
        public extern void RemoveApp();
    }
}