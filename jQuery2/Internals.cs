using Bridge.CLR;
using Bridge.Html5;
using System;

namespace Bridge.jQuery2
{
    public partial class jQuery
    {
        /// <summary>
        /// A string containing the jQuery version number.
        /// </summary>
        [Template("$.fn.jquery")]
        public static string Version;

        [Template("$.error({0})")]
        public static void Error(string message)
        {
        }

        /// <summary>
        /// A string containing the jQuery version number.
        /// </summary>
        [Template("jquery")]
        public string jQueryVersion;

        /// <summary>
        /// Add a collection of DOM elements onto the jQuery stack.
        /// </summary>
        /// <param name="elements">An array of elements to push onto the stack and make into a new jQuery object.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery PushStack(Array elements)
        {
            return null;
        }

        /// <summary>
        /// Add a collection of DOM elements onto the jQuery stack.
        /// </summary>
        /// <param name="elements">An array of elements to push onto the stack and make into a new jQuery object.</param>
        /// <param name="name">The name of a jQuery method that generated the array of elements.</param>
        /// <param name="arguments">The arguments that were passed in to the jQuery method (for serialization).</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery PushStack(Array elements, string name, Array arguments)
        {
            return null;
        }
    }
}
