using Bridge.Foundation;
using Bridge.jQuery2;

namespace Bridge.Bootstrap3
{
    [Ignore]
    public static partial class Bootstrap
    {
        /// <summary>
        /// Call the dropdowns via JavaScript.
        /// A data-toggle="dropdown" attribute is still required.
        /// </summary>
        /// <param name="instance">The jQuery object with a dropdown or dropdowns</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.dropdown()")]
        public static jQuery Dropdown(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Does something with a dropdown. Actually, the only operation is supported at this point - "toggle".
        /// </summary>
        /// <param name="instance">The jQuery object with a dropdown or dropdowns</param>
        /// <param name="operation">The operation. Only "toggle" is supported.</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.dropdown({0})")]
        public static jQuery Dropdown(this jQuery instance, string operation)
        {
            return null;
        }

        /// <summary>
        /// Does something with a dropdown. Actually, the only operation is supported at this point - "toggle".
        /// </summary>        
        /// <param name="instance">The jQuery object with a dropdown or dropdowns</param>
        /// <param name="operation">The operation. Only "toggle" is supported.</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.dropdown({0})")]
        public static jQuery Dropdown(this jQuery instance, DropdownOperation operation)
        {
            return null;
        }

        /// <summary>
        /// Toggles the dropdown menu of a given navbar or tabbed navigation.
        /// </summary>
        /// <param name="instance">The jQuery object with a dropdown or dropdowns</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.dropdown('toggle')")]
        public static jQuery DropdownToggle(this jQuery instance)
        {
            return null;
        }
    }

    /// <summary>
    /// Possible operations on a dropdown
    /// </summary>
    [Ignore]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum DropdownOperation
    {
        /// <summary>
        /// Toggles the dropdown menu of a given navbar or tabbed navigation.
        /// </summary>
        Toggle
    }

    /// <summary>
    /// Events of a dropdown
    /// </summary>
    [Ignore]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum DropdownEvent
    {
        /// <summary>
        /// This event fires immediately when the show instance method is called. The toggling anchor element is available as the relatedTarget property of the event.
        /// </summary>
        [Name("show.bs.dropdown")]
        Show,

        /// <summary>
        ///  	This event is fired when the dropdown has been made visible to the user (will wait for CSS transitions, to complete). The toggling anchor element is available as the relatedTarget property of the event.
        /// </summary>
        [Name("shown.bs.dropdown")]
        Shown,

        /// <summary>
        /// This event is fired immediately when the hide instance method has been called. The toggling anchor element is available as the relatedTarget property of the event.
        /// </summary>
        [Name("hide.bs.dropdown")]
        Hide,

        /// <summary>
        /// This event is fired when the dropdown has finished being hidden from the user (will wait for CSS transitions, to complete). The toggling anchor element is available as the relatedTarget property of the event.
        /// </summary>
        [Name("hidden.bs.dropdown")]
        Hidden
    }
}
