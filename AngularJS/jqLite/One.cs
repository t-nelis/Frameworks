using System;

namespace Bridge.AngularJS
{
    /*
     * Limitations on jqLite's One():
     * No namespaces or selectors support
     */
    public partial class jqLite
    {
        /// <summary>
        /// Attach a handler to an event for the elements. The handler is
        /// executed at most once per element per event type.
        /// </summary>
        /// <param name="events">
        /// A string containing one or more JavaScript event types, such as
        /// "click" or "submit," or custom event names.
        /// </param>
        /// <param name="handler">
        /// A function to execute at the time the event is triggered.</param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces or selectors.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite One(string events, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is
        /// executed at most once per element per event type.
        /// </summary>
        /// <param name="events">
        /// A string containing one or more JavaScript event types, such as
        /// "click" or "submit," or custom event names.</param>
        /// <param name="handler">
        /// A function to execute at the time the event is triggered.</param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces or selectors.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite One(string events, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is
        /// executed at most once per element per event type.
        /// </summary>
        /// <param name="events">
        /// An Enum's option containing one or more JavaScript event types, such
        /// as "click" or "submit," or custom event names.
        /// </param>
        /// <param name="handler">
        /// A function to execute at the time the event is triggered.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces or selectors.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite One(Enum events, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is
        /// executed at most once per element per event type.
        /// </summary>
        /// <param name="events">
        /// An Enum's option containing one or more JavaScript event types, such
        /// as "click" or "submit," or custom event names.
        /// </param>
        /// <param name="handler">
        /// A function to execute at the time the event is triggered.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces or selectors.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite One(Enum events, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is
        /// executed at most once per element per event type.
        /// </summary>
        /// <param name="events">
        /// A string containing one or more JavaScript event types, such as
        /// "click" or "submit," or custom event names.
        /// </param>
        /// <param name="data">
        /// An object containing data that will be passed to the event handler.
        /// </param>
        /// <param name="handler">
        /// A function to execute at the time the event is triggered.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces or selectors.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite One(string events, object data, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is
        /// executed at most once per element per event type.
        /// </summary>
        /// <param name="events">
        /// A string containing one or more JavaScript event types, such as
        /// "click" or "submit," or custom event names.
        /// </param>
        /// <param name="data">
        /// An object containing data that will be passed to the event handler.
        /// </param>
        /// <param name="handler">
        /// A function to execute at the time the event is triggered.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces or selectors.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite One(string events, object data, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is
        /// executed at most once per element per event type.
        /// </summary>
        /// <param name="events">
        /// An Enum's option containing one or more JavaScript event types, such
        /// as "click" or "submit," or custom event names.
        /// </param>
        /// <param name="data">
        /// An object containing data that will be passed to the event handler.
        /// </param>
        /// <param name="handler">
        /// A function to execute at the time the event is triggered.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces or selectors.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite One(Enum events, object data, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is
        /// executed at most once per element per event type.
        /// </summary>
        /// <param name="events">
        /// An Enum's option containing one or more JavaScript event types, such
        /// as "click" or "submit," or custom event names.
        /// </param>
        /// <param name="data">
        /// An object containing data that will be passed to the event handler.
        /// </param>
        /// <param name="handler">
        /// A function to execute at the time the event is triggered.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces or selectors.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite One(Enum events, object data, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is
        /// executed at most once per element per event type.
        /// </summary>
        /// <param name="events">
        /// An object in which the string keys represent one or more
        /// space-separated event types and optional namespaces, and the values
        /// represent a handler function to be called for the event(s).
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces or selectors.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite One(object events)
        {
            return null;
        }
    }
}