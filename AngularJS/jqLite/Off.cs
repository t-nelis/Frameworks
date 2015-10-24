using System;

namespace Bridge.AngularJS
{
    /*
     * Limitations on jqLite's Off():
     * No namespaces, selectors or event object support
     */
    public partial class jqLite
    {
        /// <summary>
        /// Remove event handlers from the specified events.
        /// </summary>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces, selectors or eventData.
        /// </remarks>
        /// <param name="events">Event names.</param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Off(string events)
        {
            return null;
        }

        /// <summary>
        /// Remove all event handlers.
        /// </summary>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces, selectors or eventData.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Off()
        {
            return null;
        }
    }
}