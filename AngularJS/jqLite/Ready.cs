using System;

namespace Bridge.AngularJS
{
    public partial class jqLite
    {
        /// <summary>
        /// Runs the specified callback function when the document is ready.
        /// </summary>
        /// <param name="callback">Callback.</param>
        /// <returns>The jqLite instance of itself.</returns>
        [Template("$({0})")]
        public static jqLite Ready(Delegate callback)
        {
            return null;
        }

        /// <summary>
        /// Runs the specified callback function when the document is ready.
        /// </summary>
        /// <param name="callback">Callback.</param>
        /// <returns>The jqLite instance of itself.</returns>
        [Template("$({0})")]
        public static jqLite Ready(Action callback)
        {
            return null;
        }
    }
}