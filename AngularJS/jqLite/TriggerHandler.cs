using System;

namespace Bridge.AngularJS
{
    /*
     * Limitations on jqLite's One():
     * Passes a dummy event object to handlers.
     */
    public partial class jqLite
    {
        /// <summary>
        /// Execute all handlers attached to an element for an event.
        ///
        /// The .triggerHandler() method behaves similarly to .trigger(), with
        /// the following exceptions:
        ///     - The .triggerHandler() method does not cause the default
        ///       behavior of an event to occur (such as a form submission).
        ///     - While .trigger() will operate on all elements matched by the
        ///       jQuery object, .triggerHandler() only affects the first
        ///       matched element.
        ///     - Events triggered with .triggerHandler() do not bubble up the
        ///       DOM hierarchy; if they are not handled by the target element
        ///       directly, they do nothing.
        ///     - Instead of returning the jQuery object (to allow chaining),
        ///       .triggerHandler() returns whatever value was returned by the
        ///       last handler it caused to be executed. If no handlers are
        ///       triggered, it returns undefined
        /// </summary>
        /// <param name="eventType">
        /// A string containing a JavaScript event type, such as click or
        /// submit.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Passes a dummy event object to handlers.
        /// </remarks>
        /// <returns>
        /// Instead of returning the jQuery object (to allow chaining),
        /// .triggerHandler() returns whatever value was returned by the last
        /// handler it caused to be executed. If no handlers are triggered, it
        /// returns undefined.
        /// </returns>
        public virtual object TriggerHandler(string eventType)
        {
            return null;
        }

        /// <summary>
        /// Execute all handlers attached to an element for an event.
        ///
        /// The .triggerHandler() method behaves similarly to .trigger(), with
        /// the following exceptions:
        ///     - The .triggerHandler() method does not cause the default
        ///       behavior of an event to occur (such as a form submission).
        ///     - While .trigger() will operate on all elements matched by the
        ///       jQuery object, .triggerHandler() only affects the first
        ///       matched element.
        ///     - Events triggered with .triggerHandler() do not bubble up the
        ///       DOM hierarchy; if they are not handled by the target element
        ///       directly, they do nothing.
        ///     - Instead of returning the jQuery object (to allow chaining),
        ///       .triggerHandler() returns whatever value was returned by the
        ///       last handler it caused to be executed. If no handlers are
        ///       triggered, it returns undefined
        /// </summary>
        /// <param name="eventType">
        /// An Enum's option containing a JavaScript event type, such as click
        /// or submit.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Passes a dummy event object to handlers.
        /// </remarks>
        /// <returns>
        /// Instead of returning the jQuery object (to allow chaining),
        /// .triggerHandler() returns whatever value was returned by the last
        /// handler it caused to be executed. If no handlers are triggered, it
        /// returns undefined.
        /// </returns>
        public virtual object TriggerHandler(Enum eventType)
        {
            return null;
        }

        /// <summary>
        /// Execute all handlers attached to an element for an event.
        ///
        /// The .triggerHandler() method behaves similarly to .trigger(), with
        /// the following exceptions:
        ///     - The .triggerHandler() method does not cause the default
        ///       behavior of an event to occur (such as a form submission).
        ///     - While .trigger() will operate on all elements matched by the
        ///       jQuery object, .triggerHandler() only affects the first
        ///       matched element.
        ///     - Events triggered with .triggerHandler() do not bubble up the
        ///       DOM hierarchy; if they are not handled by the target element
        ///       directly, they do nothing.
        ///     - Instead of returning the jQuery object (to allow chaining),
        ///       .triggerHandler() returns whatever value was returned by the
        ///       last handler it caused to be executed. If no handlers are
        ///       triggered, it returns undefined
        /// </summary>
        /// <param name="eventType">
        /// A string containing a JavaScript event type, such as click or
        /// submit.
        /// </param>
        /// <param name="extraParameters">
        /// Additional parameters to pass along to the event handler.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Passes a dummy event object to handlers.
        /// </remarks>
        /// <returns>
        /// Instead of returning the jQuery object (to allow chaining),
        /// .triggerHandler() returns whatever value was returned by the last
        /// handler it caused to be executed. If no handlers are triggered, it
        /// returns undefined.
        /// </returns>
        public virtual object TriggerHandler(string eventType,
            Array extraParameters)
        {
            return null;
        }

        /// <summary>
        /// Execute all handlers attached to an element for an event.
        ///
        /// The .triggerHandler() method behaves similarly to .trigger(), with
        /// the following exceptions:
        ///     - The .triggerHandler() method does not cause the default
        ///       behavior of an event to occur (such as a form submission).
        ///     - While .trigger() will operate on all elements matched by the
        ///       jQuery object, .triggerHandler() only affects the first
        ///       matched element.
        ///     - Events triggered with .triggerHandler() do not bubble up the
        ///       DOM hierarchy; if they are not handled by the target element
        ///       directly, they do nothing.
        ///     - Instead of returning the jQuery object (to allow chaining),
        ///       .triggerHandler() returns whatever value was returned by the
        ///       last handler it caused to be executed. If no handlers are
        ///       triggered, it returns undefined.
        /// </summary>
        /// <param name="eventType">
        /// An Enum's option containing a JavaScript event type, such as click
        /// or submit.
        /// </param>
        /// <param name="extraParameters">
        /// Additional parameters to pass along to the event handler.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Passes a dummy event object to handlers.
        /// </remarks>
        /// <returns>
        /// Instead of returning the jQuery object (to allow chaining),
        /// .triggerHandler() returns whatever value was returned by the last
        /// handler it caused to be executed. If no handlers are triggered, it
        /// returns undefined.
        /// </returns>
        public virtual object TriggerHandler(Enum eventType,
            Array extraParameters)
        {
            return null;
        }
    }
}