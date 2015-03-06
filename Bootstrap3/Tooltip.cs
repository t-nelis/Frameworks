using System;
using Bridge.Foundation;
using Bridge.Html5;
using Bridge.jQuery2;

namespace Bridge.Bootstrap3
{
    [Ignore]
    public static partial class Bootstrap
    {
        /// <summary>
        /// Enables the Bootstrap Tooltip functionality on an element collection.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.tooltip()")]
        public static jQuery Tooltip(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Attaches a tooltip handler to an element collection.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.tooltip({1})")]
        public static jQuery Tooltip(this jQuery instance, TooltipOptions options)
        {
            return null;
        }

        /// <summary>
        /// Does something with a tooltip - "show", "hide", "toggle" or "destroy".
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <param name="operation">The operation to be done</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.tooltip({1})")]
        public static jQuery Tooltip(this jQuery instance, string operation)
        {
            return null;
        }

        /// <summary>
        /// Does something with a tooltip - "show", "hide", "toggle" or "destroy".
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <param name="operation">The operation to be done</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.tooltip({1})")]
        public static jQuery Tooltip(this jQuery instance, PopupOperation operation)
        {
            return null;
        }

        /// <summary>
        /// Hides and destroys an element's tooltip.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.tooltip('destroy')")]
        public static jQuery TooltipDestroy(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Hides an element's tooltip.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.tooltip('hide')")]
        public static jQuery TooltipHide(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Reveals an element's tooltip.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.tooltip('show')")]
        public static jQuery TooltipShow(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Toggles an element's tooltip.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.tooltip('toggle')")]
        public static jQuery TooltipToggle(this jQuery instance)
        {
            return null;
        }
    }

    /// <summary>
    /// Tooltip events
    /// </summary>
    [Ignore]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum TooltipEvent
    {
        /// <summary>
        /// This event is fired immediately when the hide instance method has been called.
        /// </summary>
        [Name("hide.bs.tooltip")]
        Hide,

        /// <summary>
        /// This event is fired when the tooltip has finished being hidden from the user (will wait for CSS transitions to complete).
        /// </summary>
        [Name("hidden.bs.tooltip")]
        Hidden,

        /// <summary>
        /// This event fires immediately when the show instance method is called.
        /// </summary>
        [Name("show.bs.tooltip")]
        Show,

        /// <summary>
        /// This event is fired when the tooltip has been made visible to the user (will wait for CSS transitions to complete).
        /// </summary>
        [Name("shown.bs.tooltip")]
        Shown        
    }
}
