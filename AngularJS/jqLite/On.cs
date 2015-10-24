using System;

namespace Bridge.AngularJS
{
    /*
     * Limitations on jqLite's On():
     * No namespaces, selectors or eventData support
     */
    public partial class jqLite
    {
        /// <summary>
        /// Attach an event handler function for one or more events to the
        /// selected elements.
        /// </summary>
        /// <param name="events">
        /// One or more space-separated event types and optional namespaces,
        /// such as "click" or "keydown.myPlugin".
        /// </param>
        /// <param name="handler">
        /// A function to execute when the event is triggered. The value false
        /// is also allowed as a shorthand for a function that simply does
        /// return false.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces, selectors or eventData.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite On(string events, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach an event handler function for one or more events to the
        /// selected elements.
        /// </summary>
        /// <param name="events">
        /// One or more space-separated event types and optional namespaces,
        /// such as "click" or "keydown.myPlugin".
        /// </param>
        /// <param name="handler">
        /// A function to execute when the event is triggered. The value false
        /// is also allowed as a shorthand for a function that simply does
        /// return false.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces, selectors or eventData.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite On(string events, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach an event handler function for one or more events to the
        /// selected elements.
        /// </summary>
        /// <param name="events">
        /// An Enum's option containing one or more space-separated event types
        /// and optional namespaces, such as "click" or "keydown.myPlugin".
        /// </param>
        /// <param name="handler">
        /// A function to execute when the event is triggered. The value false
        /// is also allowed as a shorthand for a function that simply does
        /// return false.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces, selectors or eventData.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite On(Enum events, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach an event handler function for one or more events to the
        /// selected elements.
        /// </summary>
        /// <param name="events">
        /// An Enum's option containing one or more space-separated event types
        /// and optional namespaces, such as "click" or "keydown.myPlugin".
        /// </param>
        /// <param name="handler">
        /// A function to execute when the event is triggered. The value false
        /// is also allowed as a shorthand for a function that simply does
        /// return false.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces, selectors or eventData.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite On(Enum events, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach an event handler function for one or more events to the
        /// selected elements.
        /// </summary>
        /// <param name="events">
        /// An object in which the string keys represent one or more
        /// space-separated event types, and the values represent a handler
        /// function to be called for the event(s).
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces, selectors or eventData.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite On(object events)
        {
            return null;
        }
    }
}