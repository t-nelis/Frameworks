using Bridge;
using Bridge.jQuery2;

namespace Bridge.Bootstrap3
{
    [Ignore]
    public static partial class Bootstrap
    {
        /// <summary>
        /// Enables the collapse functionality.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.collapse()")]
        public static jQuery Collapse(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Activates your content as a collapsible element.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <param name="options">Collapse options</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.collapse({1})")]
        public static jQuery Collapse(this jQuery instance, CollapseOptions options)
        {
            return null;
        }

        /// <summary>
        /// Does something with the collapsible element. It might be "hide", "show" and "toggle".
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <param name="operation">The operation</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.collapse({1})")]
        public static jQuery Collapse(this jQuery instance, string operation)
        {
            return null;
        }

        /// <summary>
        /// Does something with the collapsible element. It might be "hide", "show" and "toggle".
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <param name="operation">The operation</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.collapse({1})")]
        public static jQuery Collapse(this jQuery instance, CollapseOperation operation)
        {
            return null;
        }

        /// <summary>
        /// Hides a collapsible element.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.collapse('hide')")]
        public static jQuery CollapseHide(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Shows a collapsible element
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.collapse('show')")]
        public static jQuery CollapseShow(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Toggles a collapsible element to shown or hidden.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.collapse('toggle')")]
        public static jQuery CollapseToggle(this jQuery instance)
        {
            return null;
        }
    }

    /// <summary>
    /// Collapse options
    /// </summary>
    [Ignore]
    [ObjectLiteral]
    public class CollapseOptions
    {
        /// <summary>
        /// If selector then all collapsible elements under the specified parent will be closed when this collapsible item is shown. (similar to traditional accordion behavior - this dependent on the panel class)
        /// Defaults to no parent.
        /// </summary>
        public virtual string Parent { get; set; }

        /// <summary>
        /// Toggles the collapsible element on invocation
        /// Defaults to true.
        /// </summary>
        public virtual bool Toggle { get; set; }
    }

    /// <summary>
    /// Collapse operations
    /// </summary>
    [Ignore]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum CollapseOperation
    {
        /// <summary>
        /// Hides a collapsible element.
        /// </summary>
        Hide,

        /// <summary>
        /// Shows a collapsible element.
        /// </summary>
        Show,

        /// <summary>
        /// Toggles a collapsible element to shown or hidden.
        /// </summary>
        Toggle
    }

    /// <summary>
    /// Collapse events
    /// </summary>
    [Ignore]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum CollapseEvent
    {
        /// <summary>
        /// This event is fired immediately when the hide method has been called.
        /// </summary>
        [Name("hide.bs.collapse")]
        Hide,

        /// <summary>
        /// This event is fired when a collapse element has been hidden from the user (will wait for CSS transitions to complete).
        /// </summary>
        [Name("hidden.bs.collapse")]
        Hidden,

        /// <summary>
        /// This event fires immediately when the show instance method is called.
        /// </summary>
        [Name("show.bs.collapse")]
        Show,

        /// <summary>
        /// This event is fired when a collapse element has been made visible to the user (will wait for CSS transitions to complete).
        /// </summary>
        [Name("shown.bs.collapse")]
        Shown
    }
}
