using Bridge.jQuery2;

namespace Bridge.Bootstrap3
{
    [Ignore]
    public static partial class Bootstrap
    {
        /// <summary>
        /// Adds the ScrollSpy behavior on the element.
        /// </summary>
        /// <param name="instance">The jQuery object to spy scroll on</param>
        /// <param name="options">The ScrollSpy options - a target (nav) and an offset</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.scrollspy({1})")]
        public static jQuery ScrollSpy(this jQuery instance, ScrollSpyOptions options)
        {
            return null;
        }

        /// <summary>
        /// Calls the ScrollSpy operation. The only operation is supported - "refresh".
        /// </summary>
        /// <param name="instance">The jQuery object with a ScrollSpy</param>
        /// <param name="operation">The operation. Only "refresh" is supported.</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.scrollspy({1})")]
        public static jQuery ScrollSpy(this jQuery instance, string operation)
        {
            return null;
        }

        /// <summary>
        /// Calls the ScrollSpy operation. The only operation is supported - "refresh".
        /// </summary>
        /// <param name="instance">The jQuery object with a ScrollSpy</param>
        /// <param name="operation">The operation. Only "refresh" is supported.</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.scrollspy({1})")]
        public static jQuery ScrollSpy(this jQuery instance, ScrollSpyOperation operation)
        {
            return null;
        }

        /// <summary>
        /// Refreshes the ScrollSpy element. It should be done if adding or removing of elements from the DOM.
        /// </summary>
        /// <param name="instance">The jQuery object with a ScrollSpy</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.scrollspy('refresh')")]
        public static jQuery ScrollSpyRefresh(this jQuery instance)
        {
            return null;
        }
    }

    /// <summary>
    /// ScrollSpy options
    /// </summary>
    [Ignore]
    [ObjectLiteral]
    public class ScrollSpyOptions
    {
        /// <summary>
        /// The string selector of the target.
        /// </summary>
        public virtual string Target
        {
            get;
            set;
        }

        /// <summary>
        /// Pixels to offset from top when calculating position of scroll.
        /// Defaults to 10.
        /// </summary>
        public virtual int Offset
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Possible operations on a scrollspy
    /// </summary>
    [Ignore]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum ScrollSpyOperation
    {
        /// <summary>
        /// Refreshes the ScrollSpy element. It should be done if adding or removing of elements from the DOM.
        /// </summary>
        Refresh
    }

    /// <summary>
    /// ScrollSpy events
    /// </summary>
    [Ignore]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum ScrollSpyEvent
    {
        /// <summary>
        /// This event fires whenever a new item becomes activated by the scrollspy.
        /// </summary>
        [Name("activate.bs.scrollspy")]
        Activate
    }
}
