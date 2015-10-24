using System;

/*
 * Limitations on jqLite's Bind():
 * no namespaces, selectors nor eventData support
 */
namespace Bridge.AngularJS
{
    public partial class jqLite
    {
        /// <summary>
        /// Attach a handler to an event for the elements.
        /// </summary>
        /// <param name="eventType">
        /// A string containing one or more DOM event types, such as "click" or
        /// "submit," or custom event names.
        /// </param>
        /// <param name="handler">
        /// A function to execute each time the event is triggered.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Bind(string eventType, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements.
        /// </summary>
        /// <param name="eventType">
        /// A string containing one or more DOM event types, such as "click" or
        /// "submit," or custom event names.
        /// </param>
        /// <param name="handler">
        /// A function to execute each time the event is triggered.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Bind(string eventType, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements.
        /// </summary>
        /// <param name="eventType">
        /// An Enum's option containing one or more DOM event types, such as
        /// "click" or "submit," or custom event names.
        /// </param>
        /// <param name="handler">
        /// A function to execute each time the event is triggered.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Bind(Enum eventType, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements.
        /// </summary>
        /// <param name="eventType">
        /// An Enum's option containing one or more DOM event types, such as
        /// "click" or "submit," or custom event names.
        /// </param>
        /// <param name="handler">
        /// A function to execute each time the event is triggered.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Bind(Enum eventType, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements.
        /// </summary>
        /// <param name="events">
        /// An object containing one or more DOM event types and functions to
        /// execute for them.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Bind(object events)
        {
            return null;
        }
    }
}