using Bridge.Foundation;
using Bridge.jQuery2;

namespace Bridge.Bootstrap3
{
    [Ignore]
    public static partial class Bootstrap
    {
        /// <summary>
        /// Wraps all alerts with close functionality. To have your alerts animate out when closed, make sure they have the .fade and .in class already applied to them.
        /// An data-dismiss="alert" attribute is still required.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.alert()")]
        public static jQuery Alert(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Performs an operation on an alert. Actually, only "close" is supported.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <param name="operation">An operation string. Actually, only "close" is supported.</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.alert({1})")]
        public static jQuery Alert(this jQuery instance, string operation)
        {
            return null;
        }

        /// <summary>
        /// Performs an operation on an alert. Actually, only "close" is supported.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <param name="operation">An operation. Actually, only "close" is supported.</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.alert({1})")]
        public static jQuery Alert(this jQuery instance, AlertOperation operation)
        {
            return null;
        }

        /// <summary>
        /// Closes an alert.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.alert('close')")]
        public static jQuery AlertClose(this jQuery instance)
        {
            return null;
        }
    }

    /// <summary>
    /// Possible operations on an alert
    /// </summary>
    [Ignore]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum AlertOperation
    {
        /// <summary>
        /// Closes an alert
        /// </summary>
        Close
    }

    /// <summary>
    /// Alert events
    /// </summary>
    [Ignore]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum AlertEvents
    {
        [Name("close.bs.alert")]
        Close,

        [Name("closed.bs.alert")]
        Closed
    }
}
