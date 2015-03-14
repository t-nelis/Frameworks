using System;
using Bridge;
using Bridge.Html5;
using Bridge.jQuery2;

namespace Bridge.Bootstrap3
{
    [Ignore]
    public static partial class Bootstrap
    {
        /// <summary>
        /// Enables the Bootstrap Popover functionality on an element collection.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.popover()")]
        public static jQuery Popover(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Initializes popovers for an element collection.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <param name="options">The options</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.popover({1})")]
        public static jQuery Popover(this jQuery instance, PopoverOptions options)
        {
            return null;
        }

        /// <summary>
        /// Does something with a popover - "show", "hide", "toggle" or "destroy".
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <param name="operation">The operation to be done</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.popover({1})")]
        public static jQuery Popover(this jQuery instance, string operation)
        {
            return null;
        }

        /// <summary>
        /// Does something with a popover - "show", "hide", "toggle" or "destroy".
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <param name="operation">The operation to be done</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.popover({1})")]
        public static jQuery Popover(this jQuery instance, PopupOperation operation)
        {
            return null;
        }

        /// <summary>
        /// Hides and destroys an element's popover.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.popover('destroy')")]
        public static jQuery PopoverDestroy(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Hides an element's popover.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.popover('hide')")]
        public static jQuery PopoverHide(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Reveals an element's popover.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.popover('show')")]
        public static jQuery PopoverShow(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Toggles an element's popover.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.popover('toggle')")]
        public static jQuery PopoverToggle(this jQuery instance)
        {
            return null;
        }
    }

    /// <summary>
    /// Popover events
    /// </summary>
    [Ignore]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum PopoverEvent
    {
        /// <summary>
        /// This event is fired immediately when the hide instance method has been called.
        /// </summary>
        [Name("hide.bs.popover")]
        Hide,

        /// <summary>
        /// This event is fired when the popover has finished being hidden from the user (will wait for CSS transitions to complete).
        /// </summary>
        [Name("hidden.bs.popover")]
        Hidden,

        /// <summary>
        /// This event fires immediately when the show instance method is called.
        /// </summary>
        [Name("show.bs.popover")]
        Show,

        /// <summary>
        /// This event is fired when the popover has been made visible to the user (will wait for CSS transitions to complete).
        /// </summary>
        [Name("shown.bs.popover")]
        Shown        
    }
}
