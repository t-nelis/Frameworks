using System;

namespace Bridge.jQuery2
{
    public partial class jQuery
    {
        /// <summary>
        ///  Attach a handler to an event for the elements.
        /// </summary>
        /// <param name="eventType">A string containing one or more DOM event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="handler">A function to execute each time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Bind(string eventType, Delegate handler)
        {
            return null;
        }

        /// <summary>
        ///  Attach a handler to an event for the elements.
        /// </summary>
        /// <param name="eventType">A string containing one or more DOM event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="handler">A function to execute each time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Bind(string eventType, Action handler)
        {
            return null;
        }

        /// <summary>
        ///  Attach a handler to an event for the elements.
        /// </summary>
        /// <param name="eventType">An Enum's option containing one or more DOM event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="handler">A function to execute each time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Bind(Enum eventType, Delegate handler)
        {
            return null;
        }

        /// <summary>
        ///  Attach a handler to an event for the elements.
        /// </summary>
        /// <param name="eventType">An Enum's option containing one or more DOM event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="handler">A function to execute each time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Bind(Enum eventType, Action handler)
        {
            return null;
        }

        /// <summary>
        ///  Attach a handler to an event for the elements.
        /// </summary>
        /// <param name="eventType">A string containing one or more DOM event types, such as "click" or "submit," or custom event names.</param>
        /// /// <param name="eventData">An object containing data that will be passed to the event handler.</param>
        /// <param name="handler">A function to execute each time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Bind(string eventType, object eventData, Delegate handler)
        {
            return null;
        }

        /// <summary>
        ///  Attach a handler to an event for the elements.
        /// </summary>
        /// <param name="eventType">A string containing one or more DOM event types, such as "click" or "submit," or custom event names.</param>
        /// /// <param name="eventData">An object containing data that will be passed to the event handler.</param>
        /// <param name="handler">A function to execute each time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Bind(string eventType, object eventData, Action handler)
        {
            return null;
        }

        /// <summary>
        ///  Attach a handler to an event for the elements.
        /// </summary>
        /// <param name="eventType">A string containing one or more DOM event types, such as "click" or "submit," or custom event names.</param>
        /// /// <param name="eventData">An Enum's option containing data that will be passed to the event handler.</param>
        /// <param name="handler">A function to execute each time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Bind(Enum eventType, object eventData, Delegate handler)
        {
            return null;
        }

        /// <summary>
        ///  Attach a handler to an event for the elements.
        /// </summary>
        /// <param name="eventType">A string containing one or more DOM event types, such as "click" or "submit," or custom event names.</param>
        /// /// <param name="eventData">An Enum's option containing data that will be passed to the event handler.</param>
        /// <param name="handler">A function to execute each time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Bind(Enum eventType, object eventData, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements.
        /// </summary>
        /// <param name="eventType">A string containing one or more DOM event types, such as "click" or "submit," or custom event names.</param>
        /// <returns>The jQuery object</returns>
        [Template("bind({0},false)")]
        public virtual jQuery BindFalse(string eventType)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements.
        /// </summary>
        /// <param name="eventType">An Enum's option containing one or more DOM event types, such as "click" or "submit," or custom event names.</param>
        /// <returns>The jQuery object</returns>
        [Template("bind({0},false)")]
        public virtual jQuery BindFalse(Enum eventType)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements.
        /// </summary>
        /// <param name="eventType">A string containing one or more DOM event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="eventData">An object containing data that will be passed to the event handler.</param>
        /// <param name="preventBubble">Setting the third argument to false will attach a function that prevents the default action from occurring and stops the event from bubbling. The default is true.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Bind(string eventType, object eventData, bool preventBubble = true)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements.
        /// </summary>
        /// <param name="eventType">An Enum's option containing one or more DOM event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="eventData">An object containing data that will be passed to the event handler.</param>
        /// <param name="preventBubble">Setting the third argument to false will attach a function that prevents the default action from occurring and stops the event from bubbling. The default is true.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Bind(Enum eventType, object eventData, bool preventBubble = true)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements.
        /// </summary>
        /// <param name="events">An object containing one or more DOM event types and functions to execute for them.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Bind(object events)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to one or more events for all elements that match the selector, now or in the future, based on a specific set of root elements.
        /// </summary>
        /// <param name="selector">A selector to filter the elements that trigger the event.</param>
        /// <param name="eventType">A string containing one or more space-separated JavaScript event types, such as "click" or "keydown," or custom event names.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Delegate(string selector, string eventType, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to one or more events for all elements that match the selector, now or in the future, based on a specific set of root elements.
        /// </summary>
        /// <param name="selector">A selector to filter the elements that trigger the event.</param>
        /// <param name="eventType">A string containing one or more space-separated JavaScript event types, such as "click" or "keydown," or custom event names.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Delegate(string selector, string eventType, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to one or more events for all elements that match the selector, now or in the future, based on a specific set of root elements.
        /// </summary>
        /// <param name="selector">A selector to filter the elements that trigger the event.</param>
        /// <param name="eventType">An Enum's option containing one or more space-separated JavaScript event types, such as "click" or "keydown," or custom event names.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Delegate(string selector, Enum eventType, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to one or more events for all elements that match the selector, now or in the future, based on a specific set of root elements.
        /// </summary>
        /// <param name="selector">A selector to filter the elements that trigger the event.</param>
        /// <param name="eventType">An Enum's option containing one or more space-separated JavaScript event types, such as "click" or "keydown," or custom event names.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Delegate(string selector, Enum eventType, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to one or more events for all elements that match the selector, now or in the future, based on a specific set of root elements.
        /// </summary>
        /// <param name="selector">A selector to filter the elements that trigger the event.</param>
        /// <param name="eventType">A string containing one or more space-separated JavaScript event types, such as "click" or "keydown," or custom event names.</param>
        /// /// <param name="eventData">An object containing data that will be passed to the event handler.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Delegate(string selector, string eventType, object eventData, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to one or more events for all elements that match the selector, now or in the future, based on a specific set of root elements.
        /// </summary>
        /// <param name="selector">A selector to filter the elements that trigger the event.</param>
        /// <param name="eventType">A string containing one or more space-separated JavaScript event types, such as "click" or "keydown," or custom event names.</param>
        /// /// <param name="eventData">An object containing data that will be passed to the event handler.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Delegate(string selector, string eventType, object eventData, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to one or more events for all elements that match the selector, now or in the future, based on a specific set of root elements.
        /// </summary>
        /// <param name="selector">A selector to filter the elements that trigger the event.</param>
        /// <param name="eventType">An Enum's option containing one or more space-separated JavaScript event types, such as "click" or "keydown," or custom event names.</param>
        /// /// <param name="eventData">An object containing data that will be passed to the event handler.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Delegate(string selector, Enum eventType, object eventData, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to one or more events for all elements that match the selector, now or in the future, based on a specific set of root elements.
        /// </summary>
        /// <param name="selector">A selector to filter the elements that trigger the event.</param>
        /// <param name="eventType">An Enum's option containing one or more space-separated JavaScript event types, such as "click" or "keydown," or custom event names.</param>
        /// /// <param name="eventData">An object containing data that will be passed to the event handler.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Delegate(string selector, Enum eventType, object eventData, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to one or more events for all elements that match the selector, now or in the future, based on a specific set of root elements.
        /// </summary>
        /// <param name="selector">A selector to filter the elements that trigger the event.</param>
        /// <param name="events">A plain object of one or more event types and functions to execute for them.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Delegate(string selector, object events)
        {
            return null;
        }

        public virtual jQuery Off(string events)
        {
            return null;
        }

        /// <summary>
        /// Remove all event handlers.
        /// </summary>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Off()
        {
            return null;
        }

        /// <summary>
        /// Remove an event handler.
        /// </summary>
        /// <param name="events">One or more space-separated event types and optional namespaces, or just namespaces, such as "click", "keydown.myPlugin", or ".myPlugin".</param>
        /// <param name="selector">A selector which should match the one originally passed to .on() when attaching event handlers.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Off(string events, string selector)
        {
            return null;
        }

        /// <summary>
        /// Remove an event handler.
        /// </summary>
        /// <param name="events">An Enum's option containing one or more space-separated event types and optional namespaces, or just namespaces, such as "click", "keydown.myPlugin", or ".myPlugin".</param>
        /// <param name="selector">A selector which should match the one originally passed to .on() when attaching event handlers.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Off(Enum events, string selector)
        {
            return null;
        }

        /// <summary>
        /// Remove an event handler.
        /// </summary>
        /// <param name="events">One or more space-separated event types and optional namespaces, or just namespaces, such as "click", "keydown.myPlugin", or ".myPlugin".</param>
        /// <param name="selector">A selector which should match the one originally passed to .on() when attaching event handlers.</param>
        /// <param name="handler">A handler function previously attached for the event(s), or the special value false.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Off(string events, string selector, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Remove an event handler.
        /// </summary>
        /// <param name="events">One or more space-separated event types and optional namespaces, or just namespaces, such as "click", "keydown.myPlugin", or ".myPlugin".</param>
        /// <param name="selector">A selector which should match the one originally passed to .on() when attaching event handlers.</param>
        /// <param name="handler">A handler function previously attached for the event(s), or the special value false.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Off(string events, string selector, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Remove an event handler.
        /// </summary>
        /// <param name="events">An Enum's option containing one or more space-separated event types and optional namespaces, or just namespaces, such as "click", "keydown.myPlugin", or ".myPlugin".</param>
        /// <param name="selector">A selector which should match the one originally passed to .on() when attaching event handlers.</param>
        /// <param name="handler">A handler function previously attached for the event(s), or the special value false.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Off(Enum events, string selector, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Remove an event handler.
        /// </summary>
        /// <param name="events">An Enum's option containing one or more space-separated event types and optional namespaces, or just namespaces, such as "click", "keydown.myPlugin", or ".myPlugin".</param>
        /// <param name="selector">A selector which should match the one originally passed to .on() when attaching event handlers.</param>
        /// <param name="handler">A handler function previously attached for the event(s), or the special value false.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Off(Enum events, string selector, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Remove an event handler.
        /// </summary>
        /// <param name="events">An object where the string keys represent one or more space-separated event types and optional namespaces, and the values represent handler functions previously attached for the event(s).</param>
        /// <param name="selector">A selector which should match the one originally passed to .on() when attaching event handlers.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Off(object events, string selector)
        {
            return null;
        }

        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="events">One or more space-separated event types and optional namespaces, such as "click" or "keydown.myPlugin".</param>
        /// <param name="handler">A function to execute when the event is triggered. The value false is also allowed as a shorthand for a function that simply does return false.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery On(string events, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="events">One or more space-separated event types and optional namespaces, such as "click" or "keydown.myPlugin".</param>
        /// <param name="handler">A function to execute when the event is triggered. The value false is also allowed as a shorthand for a function that simply does return false.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery On(string events, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="events">An Enum's option containing one or more space-separated event types and optional namespaces, such as "click" or "keydown.myPlugin".</param>
        /// <param name="handler">A function to execute when the event is triggered. The value false is also allowed as a shorthand for a function that simply does return false.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery On(Enum events, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="events">An Enum's option containing one or more space-separated event types and optional namespaces, such as "click" or "keydown.myPlugin".</param>
        /// <param name="handler">A function to execute when the event is triggered. The value false is also allowed as a shorthand for a function that simply does return false.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery On(Enum events, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="events">One or more space-separated event types and optional namespaces, such as "click" or "keydown.myPlugin".</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event. If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="handler">A function to execute when the event is triggered. The value false is also allowed as a shorthand for a function that simply does return false.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery On(string events, string selector, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="events">One or more space-separated event types and optional namespaces, such as "click" or "keydown.myPlugin".</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event. If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="handler">A function to execute when the event is triggered. The value false is also allowed as a shorthand for a function that simply does return false.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery On(string events, string selector, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="events">An Enum's option containing one or more space-separated event types and optional namespaces, such as "click" or "keydown.myPlugin".</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event. If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="handler">A function to execute when the event is triggered. The value false is also allowed as a shorthand for a function that simply does return false.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery On(Enum events, string selector, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="events">An Enum's option containing one or more space-separated event types and optional namespaces, such as "click" or "keydown.myPlugin".</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event. If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="handler">A function to execute when the event is triggered. The value false is also allowed as a shorthand for a function that simply does return false.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery On(Enum events, string selector, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="events">One or more space-separated event types and optional namespaces, such as "click" or "keydown.myPlugin".</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event. If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="data">Data to be passed to the handler in event.data when an event is triggered.</param>
        /// <param name="handler">A function to execute when the event is triggered. The value false is also allowed as a shorthand for a function that simply does return false.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery On(string events, string selector, object data, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="events">One or more space-separated event types and optional namespaces, such as "click" or "keydown.myPlugin".</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event. If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="data">Data to be passed to the handler in event.data when an event is triggered.</param>
        /// <param name="handler">A function to execute when the event is triggered. The value false is also allowed as a shorthand for a function that simply does return false.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery On(string events, string selector, object data, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="events">An Enum's option containing one or more space-separated event types and optional namespaces, such as "click" or "keydown.myPlugin".</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event. If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="data">Data to be passed to the handler in event.data when an event is triggered.</param>
        /// <param name="handler">A function to execute when the event is triggered. The value false is also allowed as a shorthand for a function that simply does return false.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery On(Enum events, string selector, object data, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="events">An Enum's option containing one or more space-separated event types and optional namespaces, such as "click" or "keydown.myPlugin".</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event. If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="data">Data to be passed to the handler in event.data when an event is triggered.</param>
        /// <param name="handler">A function to execute when the event is triggered. The value false is also allowed as a shorthand for a function that simply does return false.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery On(Enum events, string selector, object data, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="events">An object in which the string keys represent one or more space-separated event types and optional namespaces, and the values represent a handler function to be called for the event(s).</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery On(object events)
        {
            return null;
        }

        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="events">An object in which the string keys represent one or more space-separated event types and optional namespaces, and the values represent a handler function to be called for the event(s).</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that will call the handler. If the selector is null or omitted, the handler is always called when it reaches the selected element.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery On(object events, string selector)
        {
            return null;
        }

        /// <summary>
        /// Attach an event handler function for one or more events to the selected elements.
        /// </summary>
        /// <param name="events">An object in which the string keys represent one or more space-separated event types and optional namespaces, and the values represent a handler function to be called for the event(s).</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that will call the handler. If the selector is null or omitted, the handler is always called when it reaches the selected element.</param>
        /// <param name="data">Data to be passed to the handler in event.data when an event occurs.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery On(object events, string selector, object data)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element per event type.
        /// </summary>
        /// <param name="events">A string containing one or more JavaScript event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery One(string events, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element per event type.
        /// </summary>
        /// <param name="events">A string containing one or more JavaScript event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery One(string events, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element per event type.
        /// </summary>
        /// <param name="events">An Enum's option containing one or more JavaScript event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery One(Enum events, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element per event type.
        /// </summary>
        /// <param name="events">An Enum's option containing one or more JavaScript event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery One(Enum events, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element per event type.
        /// </summary>
        /// <param name="events">A string containing one or more JavaScript event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="data">An object containing data that will be passed to the event handler.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery One(string events, object data, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element per event type.
        /// </summary>
        /// <param name="events">A string containing one or more JavaScript event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="data">An object containing data that will be passed to the event handler.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery One(string events, object data, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element per event type.
        /// </summary>
        /// <param name="events">An Enum's option containing one or more JavaScript event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="data">An object containing data that will be passed to the event handler.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery One(Enum events, object data, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element per event type.
        /// </summary>
        /// <param name="events">An Enum's option containing one or more JavaScript event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="data">An object containing data that will be passed to the event handler.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery One(Enum events, object data, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element per event type.
        /// </summary>
        /// <param name="events">A string containing one or more JavaScript event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event. If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery One(string events, string selector, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element per event type.
        /// </summary>
        /// <param name="events">A string containing one or more JavaScript event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event. If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery One(string events, string selector, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element per event type.
        /// </summary>
        /// <param name="events">An Enum's option containing one or more JavaScript event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event. If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery One(Enum events, string selector, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element per event type.
        /// </summary>
        /// <param name="events">An Enum's option containing one or more JavaScript event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event. If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery One(Enum events, string selector, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element per event type.
        /// </summary>
        /// <param name="events">A string containing one or more JavaScript event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event. If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="data">An object containing data that will be passed to the event handler.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery One(string events, string selector, object data, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element per event type.
        /// </summary>
        /// <param name="events">A string containing one or more JavaScript event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event. If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="data">An object containing data that will be passed to the event handler.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery One(string events, string selector, object data, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element per event type.
        /// </summary>
        /// <param name="events">An Enum's option containing one or more JavaScript event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event. If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="data">An object containing data that will be passed to the event handler.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery One(Enum events, string selector, object data, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element per event type.
        /// </summary>
        /// <param name="events">An Enum's option containing one or more JavaScript event types, such as "click" or "submit," or custom event names.</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that trigger the event. If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        /// <param name="data">An object containing data that will be passed to the event handler.</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery One(Enum events, string selector, object data, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element per event type.
        /// </summary>
        /// <param name="events">An object in which the string keys represent one or more space-separated event types and optional namespaces, and the values represent a handler function to be called for the event(s).</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery One(object events)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element per event type.
        /// </summary>
        /// <param name="events">An object in which the string keys represent one or more space-separated event types and optional namespaces, and the values represent a handler function to be called for the event(s).</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that will call the handler. If the selector is null or omitted, the handler is always called when it reaches the selected element.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery One(object events, string selector)
        {
            return null;
        }

        /// <summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element per event type.
        /// </summary>
        /// <param name="events">An object in which the string keys represent one or more space-separated event types and optional namespaces, and the values represent a handler function to be called for the event(s).</param>
        /// <param name="selector">A selector string to filter the descendants of the selected elements that will call the handler. If the selector is null or omitted, the handler is always called when it reaches the selected element.</param>
        /// <param name="data">Data to be passed to the handler in event.data when an event occurs.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery One(object events, string selector, object data)
        {
            return null;
        }

        /// <summary>
        /// Execute all handlers and behaviors attached to the matched elements for the given event type.
        /// </summary>
        /// <param name="eventType">A string containing a JavaScript event type, such as click or submit.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Trigger(string eventType)
        {
            return null;
        }

        /// <summary>
        /// Execute all handlers and behaviors attached to the matched elements for the given event type.
        /// </summary>
        /// <param name="eventType">An Enum's option containing a JavaScript event type, such as click or submit.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Trigger(Enum eventType)
        {
            return null;
        }

        /// <summary>
        /// Execute all handlers and behaviors attached to the matched elements for the given event type.
        /// </summary>
        /// <param name="eventType">A string containing a JavaScript event type, such as click or submit.</param>
        /// <param name="extraParameters">Additional parameters to pass along to the event handler.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Trigger(string eventType, object extraParameters)
        {
            return null;
        }

        /// <summary>
        /// Execute all handlers and behaviors attached to the matched elements for the given event type.
        /// </summary>
        /// <param name="eventType">An Enum's option containing a JavaScript event type, such as click or submit.</param>
        /// <param name="extraParameters">Additional parameters to pass along to the event handler.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Trigger(Enum eventType, object extraParameters)
        {
            return null;
        }

        /// <summary>
        /// Execute all handlers and behaviors attached to the matched elements for the given event type.
        /// </summary>
        /// <param name="eventType">A string containing a JavaScript event type, such as click or submit.</param>
        /// <param name="extraParameters">Additional parameters to pass along to the event handler.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Trigger(string eventType, params object[] extraParameters)
        {
            return null;
        }

        /// <summary>
        /// Execute all handlers and behaviors attached to the matched elements for the given event type.
        /// </summary>
        /// <param name="eventType">An Enum's option containing a JavaScript event type, such as click or submit.</param>
        /// <param name="extraParameters">Additional parameters to pass along to the event handler.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Trigger(Enum eventType, params object[] extraParameters)
        {
            return null;
        }

        /// <summary>
        /// Execute all handlers and behaviors attached to the matched elements for the given event type.
        /// </summary>
        /// <param name="jqEvent">A jQuery.Event object.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Trigger(jQueryEvent jqEvent)
        {
            return null;
        }

        /// <summary>
        /// Execute all handlers and behaviors attached to the matched elements for the given event type.
        /// </summary>
        /// <param name="jqEvent">A jQuery.Event object.</param>
        /// <param name="extraParameters">Additional parameters to pass along to the event handler.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Trigger(jQueryEvent jqEvent, object extraParameters)
        {
            return null;
        }

        /// <summary>
        /// Execute all handlers and behaviors attached to the matched elements for the given event type.
        /// </summary>
        /// <param name="jqEvent">A jQuery.Event object.</param>
        /// <param name="extraParameters">Additional parameters to pass along to the event handler.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Trigger(jQueryEvent jqEvent, params object[] extraParameters)
        {
            return null;
        }

        /// <summary>
        /// Execute all handlers attached to an element for an event.
        ///
        /// The .triggerHandler() method behaves similarly to .trigger(), with the following exceptions:
        ///     - The .triggerHandler() method does not cause the default behavior of an event to occur (such as a form submission).
        ///     - While .trigger() will operate on all elements matched by the jQuery object, .triggerHandler() only affects the first matched element.
        ///     - Events triggered with .triggerHandler() do not bubble up the DOM hierarchy; if they are not handled by the target element directly, they do nothing.
        ///     - Instead of returning the jQuery object (to allow chaining), .triggerHandler() returns whatever value was returned by the last handler it caused to be executed. If no handlers are triggered, it returns undefined
        /// </summary>
        /// <param name="eventType">A string containing a JavaScript event type, such as click or submit.</param>
        /// <returns>Instead of returning the jQuery object (to allow chaining), .triggerHandler() returns whatever value was returned by the last handler it caused to be executed. If no handlers are triggered, it returns undefined</returns>
        public virtual object TriggerHandler(string eventType)
        {
            return null;
        }

        /// <summary>
        /// Execute all handlers attached to an element for an event.
        ///
        /// The .triggerHandler() method behaves similarly to .trigger(), with the following exceptions:
        ///     - The .triggerHandler() method does not cause the default behavior of an event to occur (such as a form submission).
        ///     - While .trigger() will operate on all elements matched by the jQuery object, .triggerHandler() only affects the first matched element.
        ///     - Events triggered with .triggerHandler() do not bubble up the DOM hierarchy; if they are not handled by the target element directly, they do nothing.
        ///     - Instead of returning the jQuery object (to allow chaining), .triggerHandler() returns whatever value was returned by the last handler it caused to be executed. If no handlers are triggered, it returns undefined
        /// </summary>
        /// <param name="eventType">An Enum's option containing a JavaScript event type, such as click or submit.</param>
        /// <returns>Instead of returning the jQuery object (to allow chaining), .triggerHandler() returns whatever value was returned by the last handler it caused to be executed. If no handlers are triggered, it returns undefined</returns>
        public virtual object TriggerHandler(Enum eventType)
        {
            return null;
        }

        /// <summary>
        /// Execute all handlers attached to an element for an event.
        ///
        /// The .triggerHandler() method behaves similarly to .trigger(), with the following exceptions:
        ///     - The .triggerHandler() method does not cause the default behavior of an event to occur (such as a form submission).
        ///     - While .trigger() will operate on all elements matched by the jQuery object, .triggerHandler() only affects the first matched element.
        ///     - Events triggered with .triggerHandler() do not bubble up the DOM hierarchy; if they are not handled by the target element directly, they do nothing.
        ///     - Instead of returning the jQuery object (to allow chaining), .triggerHandler() returns whatever value was returned by the last handler it caused to be executed. If no handlers are triggered, it returns undefined
        /// </summary>
        /// <param name="eventType">A string containing a JavaScript event type, such as click or submit.</param>
        /// <param name="extraParameters">Additional parameters to pass along to the event handler.</param>
        /// <returns>Instead of returning the jQuery object (to allow chaining), .triggerHandler() returns whatever value was returned by the last handler it caused to be executed. If no handlers are triggered, it returns undefined</returns>
        public virtual object TriggerHandler(string eventType, Array extraParameters)
        {
            return null;
        }

        /// <summary>
        /// Execute all handlers attached to an element for an event.
        ///
        /// The .triggerHandler() method behaves similarly to .trigger(), with the following exceptions:
        ///     - The .triggerHandler() method does not cause the default behavior of an event to occur (such as a form submission).
        ///     - While .trigger() will operate on all elements matched by the jQuery object, .triggerHandler() only affects the first matched element.
        ///     - Events triggered with .triggerHandler() do not bubble up the DOM hierarchy; if they are not handled by the target element directly, they do nothing.
        ///     - Instead of returning the jQuery object (to allow chaining), .triggerHandler() returns whatever value was returned by the last handler it caused to be executed. If no handlers are triggered, it returns undefined
        /// </summary>
        /// <param name="eventType">An Enum's option containing a JavaScript event type, such as click or submit.</param>
        /// <param name="extraParameters">Additional parameters to pass along to the event handler.</param>
        /// <returns>Instead of returning the jQuery object (to allow chaining), .triggerHandler() returns whatever value was returned by the last handler it caused to be executed. If no handlers are triggered, it returns undefined</returns>
        public virtual object TriggerHandler(Enum eventType, Array extraParameters)
        {
            return null;
        }

        /// <summary>
        /// Remove all event handlers.
        /// </summary>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Unbind()
        {
            return null;
        }

        /// <summary>
        /// Remove a previously-attached event handler from the elements.
        /// </summary>
        /// <param name="eventType">A string containing a JavaScript event type, such as click or submit.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Unbind(string eventType)
        {
            return null;
        }

        /// <summary>
        /// Remove a previously-attached event handler from the elements.
        /// </summary>
        /// <param name="eventType">An Enum's option containing a JavaScript event type, such as click or submit.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Unbind(Enum eventType)
        {
            return null;
        }

        /// <summary>
        /// Remove a previously-attached event handler from the elements.
        /// </summary>
        /// <param name="eventType">A string containing a JavaScript event type, such as click or submit.</param>
        /// <param name="handler">The function that is to be no longer executed.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Unbind(string eventType, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Remove a previously-attached event handler from the elements.
        /// </summary>
        /// <param name="eventType">A string containing a JavaScript event type, such as click or submit.</param>
        /// <param name="handler">The function that is to be no longer executed.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Unbind(string eventType, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Remove a previously-attached event handler from the elements.
        /// </summary>
        /// <param name="eventType">An Enum's option containing a JavaScript event type, such as click or submit.</param>
        /// <param name="handler">The function that is to be no longer executed.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Unbind(Enum eventType, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Remove a previously-attached event handler from the elements.
        /// </summary>
        /// <param name="eventType">An Enum's option containing a JavaScript event type, such as click or submit.</param>
        /// <param name="handler">The function that is to be no longer executed.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Unbind(Enum eventType, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Unbinds the corresponding 'return false' function that was bound using .bind( eventType, false ).
        /// </summary>
        /// <param name="eventType">A string containing a JavaScript event type, such as click or submit.</param>
        /// <returns>The jQuery instance</returns>
        [Template("unbind({0},false)")]
        public virtual jQuery UnbindFalse(string eventType)
        {
            return null;
        }

        /// <summary>
        /// Unbinds the corresponding 'return false' function that was bound using .bind( eventType, false ).
        /// </summary>
        /// <param name="eventType">An Enum's option containing a JavaScript event type, such as click or submit.</param>
        /// <returns>The jQuery instance</returns>
        [Template("unbind({0},false)")]
        public virtual jQuery UnbindFalse(Enum eventType)
        {
            return null;
        }

        /// <summary>
        /// Remove a previously-attached event handler from the elements.
        /// </summary>
        /// <param name="e">A JavaScript event object as passed to an event handler.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Unbind(object e)
        {
            return null;
        }

        /// <summary>
        /// Remove all event handlers that have been bound by .delegate()
        /// </summary>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Undelegate()
        {
            return null;
        }

        /// <summary>
        /// Remove a handler from the event for all elements which match the current selector, based upon a specific set of root elements.
        /// </summary>
        /// <param name="selector">A selector which will be used to filter the event results.</param>
        /// <param name="eventType">A string containing a JavaScript event type, such as "click" or "keydown"</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Undelegate(string selector, string eventType)
        {
            return null;
        }

        /// <summary>
        /// Remove a handler from the event for all elements which match the current selector, based upon a specific set of root elements.
        /// </summary>
        /// <param name="selector">A selector which will be used to filter the event results.</param>
        /// <param name="eventType">An Enum's option containing a JavaScript event type, such as "click" or "keydown"</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Undelegate(string selector, Enum eventType)
        {
            return null;
        }

        /// <summary>
        /// Remove a handler from the event for all elements which match the current selector, based upon a specific set of root elements.
        /// </summary>
        /// <param name="selector">A selector which will be used to filter the event results.</param>
        /// <param name="events">An object of one or more event types and previously bound functions to unbind from them.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Undelegate(string selector, object events)
        {
            return null;
        }

        /// <summary>
        /// Remove a handler from the event for all elements which match the current selector, based upon a specific set of root elements.
        /// </summary>
        /// <param name="selector">A selector which will be used to filter the event results.</param>
        /// <param name="eventType">A string containing a JavaScript event type, such as "click" or "keydown"</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Undelegate(string selector, string eventType, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Remove a handler from the event for all elements which match the current selector, based upon a specific set of root elements.
        /// </summary>
        /// <param name="selector">A selector which will be used to filter the event results.</param>
        /// <param name="eventType">A string containing a JavaScript event type, such as "click" or "keydown"</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Undelegate(string selector, string eventType, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Remove a handler from the event for all elements which match the current selector, based upon a specific set of root elements.
        /// </summary>
        /// <param name="selector">A selector which will be used to filter the event results.</param>
        /// <param name="eventType">An Enum's option containing a JavaScript event type, such as "click" or "keydown"</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Undelegate(string selector, Enum eventType, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Remove a handler from the event for all elements which match the current selector, based upon a specific set of root elements.
        /// </summary>
        /// <param name="selector">A selector which will be used to filter the event results.</param>
        /// <param name="eventType">An Enum's option containing a JavaScript event type, such as "click" or "keydown"</param>
        /// <param name="handler">A function to execute at the time the event is triggered.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Undelegate(string selector, Enum eventType, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Remove a handler from the event for all elements which match the current selector, based upon a specific set of root elements.
        /// </summary>
        /// <param name="ns">A string containing a namespace to unbind all events from.</param>
        /// <returns>The jQuery instance</returns>
        public virtual jQuery Undelegate(string ns)
        {
            return null;
        }
    }
}
