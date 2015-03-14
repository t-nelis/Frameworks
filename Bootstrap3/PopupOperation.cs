using Bridge;

namespace Bridge.Bootstrap3
{
    /// <summary>
    /// Operations on a tooltip/popover
    /// </summary>
    [Ignore]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum PopupOperation
    {
        /// <summary>
        /// Hides and destroys an element's tooltip/popover.
        /// </summary>
        Destroy,

        /// <summary>
        /// Hides an element's tooltip/popover.
        /// </summary>
        Hide,

        /// <summary>
        /// Reveals an element's tooltip/popover.
        /// </summary>
        Show,

        /// <summary>
        /// Toggles an element's tooltip/popover.
        /// </summary>
        Toggle
    } 
}
