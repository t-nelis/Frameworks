using Bridge;
using Bridge.jQuery2;

namespace Bridge.Bootstrap3
{
    [Ignore]
    public static partial class Bootstrap
    {
        /// <summary>
        /// Enable buttons.
        /// Data attributes are still required.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.button()")]
        public static jQuery Button(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// The effect of this method depends on the "str" parameter.
        /// The "str" parameter could be an operation string: "toggle", "loading", "reset"; or an arbitrary string - in that case it resets button state - swaps text to any data defined text state.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <param name="str">It could be an operation string: "toggle", "loading", "reset"; or an arbitrary string - in that case it resets button state - swaps text to any data defined text state.</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.button({1})")]
        public static jQuery Button(this jQuery instance, string str)
        {
            return null;
        }

        /// <summary>
        /// Does something with a button - "loading", "reset" or "toggle" operations.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <param name="operation"></param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.button({1})")]
        public static jQuery Button(this jQuery instance, ButtonOperation operation)
        {
            return null;
        }

        /// <summary>
        /// Sets button state to loading - disables button and swaps text to loading text. Loading text should be defined on the button element using the data attribute data-loading-text.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.button('loading')")]
        public static jQuery ButtonLoading(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Resets button state - swaps text to original text.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.button('reset')")]
        public static jQuery ButtonReset(this jQuery instance)
        {
            return null;
        }

        /// <summary>
        /// Toggles push state. Gives the button the appearance that it has been activated.
        /// </summary>
        /// <param name="instance">The jQuery object</param>
        /// <returns>The jQuery object</returns>
        [Template("{0}.button('toggle')")]
        public static jQuery ButtonToggle(this jQuery instance)
        {
            return null;
        }
    }

    /// <summary>
    /// Possible operations on a button
    /// </summary>
    [Ignore]
    [Enum(Emit.StringNameLowerCase)]
    [Name("String")]
    public enum ButtonOperation
    {
        /// <summary>
        /// Sets button state to loading - disables button and swaps text to loading text. Loading text should be defined on the button element using the data attribute data-loading-text.
        /// </summary>
        Loading,

        /// <summary>
        /// Resets button state - swaps text to original text.
        /// </summary>
        Reset,

        /// <summary>
        /// Toggles push state. Gives the button the appearance that it has been activated.
        /// </summary>
        Toggle
    }
}
