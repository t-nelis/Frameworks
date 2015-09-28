using Bridge.Html5;

namespace Bridge.jQuery2
{
    public partial class jQuery
    {
        /// <summary>
        /// The jQuery.Event constructor is exposed and can be used when calling trigger.
        /// </summary>
        /// <param name="eventName">The name of the event</param>
        /// <returns>A jQuery Event object</returns>
        [Template("$.Event({0})")]
        public static jQueryEvent Event(string eventName)
        {
            return null;
        }

        /// <summary>
        /// The jQuery.Event constructor is exposed and can be used when calling trigger.
        /// </summary>
        /// <param name="eventName">The name of the event</param>
        /// <param name="arguments">A set of settings specific for the event</param>
        /// <returns>A jQuery Event object</returns>
        [Template("$.Event({0},{arguments})")]
        public static jQueryEvent Event(string eventName, params object[] arguments)
        {
            return null;
        }
    }

    /// <summary>
    /// jQuery’s event system normalizes the event object according to W3C standards. The event object is guaranteed to be passed to the event handler. Most properties from the original event are copied over and normalized to the new event object.
    /// </summary>
    [Ignore]
    [Name("jQuery.Event")]
    public class jQueryEvent
    {
        /// <summary>
        /// Creates a jQuery Event instance of the specified event
        /// </summary>
        /// <param name="eventName">The name of the event</param>
        [Template("$.Event({0})")]
        public jQueryEvent(string eventName)
        {
        }

        /// <summary>
        /// Creates a jQuery Event instance of the specified event
        /// </summary>
        /// <param name="eventName">The name of the event</param>
        /// <param name="arguments">A set of settings specific for the event</param>
        [Template("$.Event({0},{arguments})")]
        public jQueryEvent(string eventName, params object[] arguments)
        {
        }

        /// <summary>
        /// The current DOM element within the event bubbling phase.
        /// </summary>
        public Element CurrentTarget;

        /// <summary>
        /// An optional object of data passed to an event method when the current executing handler is bound.
        /// </summary>
        public object Data;

        /// <summary>
        /// The element where the currently-called jQuery event handler was attached.
        /// </summary>
        public Element DelegateTarget;

        /// <summary>
        /// Indicates whether the META key was pressed when the event fired.
        /// Returns a boolean value (true or false) that indicates whether or not the META key was pressed at the time the event fired. This key might map to an alternative key name on some platforms.
        /// </summary>
        public bool MetaKey;

        /// <summary>
        /// This will likely be used primarily by plugin authors who wish to handle tasks differently depending on the event namespace used.
        /// </summary>
        public string Namespace;

        /// <summary>
        /// The original HTML event
        /// </summary>
        public Event OriginalEvent;

        /// <summary>
        /// The mouse position relative to the left edge of the document.
        /// </summary>
        public int PageX;

        /// <summary>
        /// The mouse position relative to the top edge of the document.
        /// </summary>
        public int PageY;

        /// <summary>
        /// The other DOM element involved in the event, if any.
        /// </summary>
        public Element RelatedTarget;

        /// <summary>
        /// The last value returned by an event handler that was triggered by this event, unless the value was undefined.
        /// </summary>
        public object Result;

        /// <summary>
        /// The DOM element that initiated the event.
        /// </summary>
        public Element Target;

        /// <summary>
        /// The difference in milliseconds between the time the browser created the event and January 1, 1970.
        /// This property can be useful for profiling event performance by getting the event.timeStamp value at two points in the code and noting the difference. To simply determine the current time inside an event handler, use (new Date).getTime() instead.
        /// Note: Due to a bug open since 2004, this value is not populated correctly in Firefox and it is not possible to know the time the event was created in that browser.
        /// </summary>
        public double TimeStamp;

        /// <summary>
        /// Describes the nature of the event.
        /// </summary>
        public string Type;

        /// <summary>
        /// For key or mouse events, this property indicates the specific key or button that was pressed.
        /// The event.which property normalizes event.keyCode and event.charCode. It is recommended to watch event.which for keyboard key input. For more detail, read about event.charCode on the MDC.
        /// It also normalizes button presses (mousedown and mouseupevents), reporting 1 for left button, 2 for middle, and 3 for right. Use event.which instead of event.button.
        /// </summary>
        public int Which;

        /// <summary>
        /// Returns whether event.preventDefault() was ever called on this event object.
        /// </summary>
        public bool IsDefaultPrevented()
        {
            return false;
        }

        /// <summary>
        /// Returns whether event.stopImmediatePropagation() was ever called on this event object.
        /// </summary>
        public bool IsImmediatePropagationStopped()
        {
            return false;
        }

        /// <summary>
        /// Returns whether event.stopPropagation() was ever called on this event object.
        /// </summary>
        public bool IsPropagationStopped()
        {
            return false;
        }

        /// <summary>
        /// If this method is called, the default action of the event will not be triggered.
        /// </summary>
        public void PreventDefault()
        {
        }

        /// <summary>
        /// Keeps the rest of the handlers from being executed and prevents the event from bubbling up the DOM tree.
        /// </summary>
        public void StopImmediatePropagation()
        {
        }

        /// <summary>
        /// Prevents the event from bubbling up the DOM tree, preventing any parent handlers from being notified of the event.
        /// </summary>
        public void StopPropagation()
        {
        }
    }
}
