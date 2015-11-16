using Bridge.jQuery2;

namespace Bridge.Bootstrap3
{
    [External]
    public static partial class Bootstrap
    {
        /// <summary>
        /// Does something with a tab. Actully, the only operation is supported - 'show'. It activates a tab element and content container. Tab should have either a data-target or an href targeting a container node in the DOM.
        /// </summary>
        /// <param name="instance">The jQuery object with a tab</param>
        /// <param name="operation">The operation to be done. The only one is actually supported - "show".</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.tab({1})")]
        public static jQuery Tab(this jQuery instance, string operation)
        {
            return null;
        }

        /// <summary>
        /// Does something with a tab. Actully, the only operation is supported - 'show'. It activates a tab element and content container. Tab should have either a data-target or an href targeting a container node in the DOM.
        /// </summary>
        /// <param name="instance">The jQuery object with a tab</param>
        /// <param name="operation">The operation to be done. The only one is actually supported - "show".</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.tab({1})")]
        public static jQuery Tab(this jQuery instance, TabOperation operation)
        {
            return null;
        }

        /// <summary>
        /// Activates a tab element and content container. Tab should have either a data-target or an href targeting a container node in the DOM.
        /// </summary>
        /// <param name="instance">The jQuery object with a tab</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.tab('show')")]
        public static jQuery TabShow(this jQuery instance)
        {
            return null;
        }
    }

    /// <summary>
    /// Possible operations on a tab
    /// </summary>
    [External]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum TabOperation
    {
        /// <summary>
        /// Activates a tab element and content container. Tab should have either a data-target or an href targeting a container node in the DOM.
        /// </summary>
        Show
    }

    /// <summary>
    /// Tab events
    /// </summary>
    [External]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum TabEvent
    {
        /// <summary>
        /// This event fires on tab show, but before the new tab has been shown. Use event.target and event.relatedTarget to target the active tab and the previous active tab (if available) respectively.
        /// </summary>
        [Name("show.bs.tab")]
        Show,

        /// <summary>
        ///      This event fires on tab show after a tab has been shown. Use event.target and event.relatedTarget to target the active tab and the previous active tab (if available) respectively.
        /// </summary>
        [Name("shown.bs.tab")]
        Shown
    }
}
