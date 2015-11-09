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
        /// Indicates whether the given event bubbles up through the DOM or not.
        /// Only certain events can bubble. Events that do bubble have this property set to true. You can use this property to check if an event is allowed to bubble or not.
        /// </summary>
        public readonly bool Bubbles;

        /// <summary>
        /// Indicates whether the event is cancelable or not.
        /// Whether an event can be canceled or not is something that's determined when that event is initialized.
        /// To cancel an event, call the preventDefault() method on the event. This keeps the implementation from executing the default action that is associated with the event.
        /// </summary>
        public readonly bool Cancelable;

        /// <summary>
        /// Identifies the current target for the event, as the event traverses the DOM. It always refers to the element the event handler has been attached to as opposed to event.target which identifies the element on which the event occurred.
        /// On Internet Explorer 6 through 8, the event model is different. Event listeners are attached with the non-standard element.attachEvent method. In this model, there is no equivalent to event.currentTarget and this is the global object.
        /// </summary>
        public readonly Element CurrentTarget;

        /// <summary>
        /// An optional object of data passed to an event method when the current executing handler is bound.
        /// </summary>
        public object Data;

        /// <summary>
        /// The element where the currently-called jQuery event handler was attached.
        /// </summary>
        public Element DelegateTarget;

        /// <summary>
        /// Indicates which phase of the event flow is currently being evaluated.
        /// Returns an integer value represented by 4 constants:
        /// Event.NONE = 0
        /// Event.CAPTURING_PHASE = 1
        /// Event.AT_TARGET = 2
        /// Event.BUBBLING_PHASE = 3
        /// </summary>
        public readonly int EventPhase;

        /// <summary>
        /// This will likely be used primarily by plugin authors who wish to handle tasks differently depending on the event namespace used.
        /// </summary>
        public string Namespace;

        /// <summary>
        /// The original HTML event
        /// </summary>
        public Event OriginalEvent;

        /// <summary>
        /// The last value returned by an event handler that was triggered by this event, unless the value was undefined.
        /// </summary>
        public object Result;

        /// <summary>
        /// This property of event objects is the object the event was dispatched on. It is different than event.currentTarget when the event handler is called in bubbling or capturing phase of the event.
        /// On IE6-8, the event model is different. Event listeners are attached with the non-standard element.attachEvent method. In this model, the event object is not passed as an argument to the event handler function but is the window.event object. This object has an srcElement property which has the same semantics than event.target.
        /// </summary>
        public readonly Element Target;

        /// <summary>
        /// Returns the time (in milliseconds since the epoch) at which the event was created.
        /// This property only works if the event system supports it for the particular event.
        /// </summary>
        public readonly int TimeStamp;

        /// <summary>
        /// Returns a string containing the type of event.
        /// </summary>
        public readonly string Type;

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
        /// Cancels the event if it is cancelable, without stopping further propagation of the event.
        /// </summary>
        public virtual void PreventDefault()
        {
        }

        /// <summary>
        /// Prevents other listeners of the same event to be called.
        /// If several listeners are attached to the same element for the same event type, they are called in order in which they have been added. If during one such call, event.stopImmediatePropagation() is called, no remaining listeners will be called.
        /// </summary>
        public virtual void StopImmediatePropagation()
        {
        }

        /// <summary>
        /// Prevents further propagation of the current event.
        /// </summary>
        public virtual void StopPropagation()
        {
        }
    }

    [Ignore]
    [Name("jQuery.Event")]
    public class jQueryUiEvent : jQueryEvent
    {
        /// <summary>
        /// Creates a jQuery Event instance of the specified event
        /// </summary>
        /// <param name="eventName">The name of the event</param>
        [Template("$.Event({0})")]
        public jQueryUiEvent(string eventName) : base(eventName)
        {
        }

        /// <summary>
        /// Creates a jQuery Event instance of the specified event
        /// </summary>
        /// <param name="eventName">The name of the event</param>
        /// <param name="arguments">A set of settings specific for the event</param>
        [Template("$.Event({0},{arguments})")]
        public jQueryUiEvent(string eventName, params object[] arguments) : base(eventName, arguments)
        {
        }

        /// <summary>
        /// Returns additional numerical information about the event, depending on the type of event.
        /// For mouse events, such as click, dblclick, mousedown, or mouseup, the detail property indicates how many times the mouse has been clicked in the same location for this event.
        /// For a dblclick event the value of detail is always 2.
        /// </summary>
        public readonly int Detail;

        /// <summary>
        /// The mouse position relative to the left edge of the document.
        /// </summary>
        public int PageX;

        /// <summary>
        /// The mouse position relative to the top edge of the document.
        /// </summary>
        public int PageY;
    }

    [Ignore]
    [Name("jQuery.Event")]
    public class jQueryFocusEvent : jQueryUiEvent
    {
        /// <summary>
        /// Creates a jQuery Event instance of the specified event
        /// </summary>
        /// <param name="eventName">The name of the event</param>
        [Template("$.Event({0})")]
        public jQueryFocusEvent(string eventName) : base(eventName)
        {
        }

        /// <summary>
        /// Creates a jQuery Event instance of the specified event
        /// </summary>
        /// <param name="eventName">The name of the event</param>
        /// <param name="arguments">A set of settings specific for the event</param>
        [Template("$.Event({0},{arguments})")]
        public jQueryFocusEvent(string eventName, params object[] arguments) : base(eventName, arguments)
        {
        }

        /// <summary>
        /// The FocusEvent.relatedTarget read-only property represents a secondary target for this event, which will depend of the event itself. As in some cases (like when tabbing in or out a page), this property may be set to null for security reasons.
        /// </summary>
        public readonly Element RelatedTarget;
    }

    [Ignore]
    [Name("jQuery.Event")]
    public class jQueryKeyboardEvent : jQueryUiEvent
    {
        /// <summary>
        /// Creates a jQuery Event instance of the specified event
        /// </summary>
        /// <param name="eventName">The name of the event</param>
        [Template("$.Event({0})")]
        public jQueryKeyboardEvent(string eventName) : base(eventName)
        {
        }

        /// <summary>
        /// Creates a jQuery Event instance of the specified event
        /// </summary>
        /// <param name="eventName">The name of the event</param>
        /// <param name="arguments">A set of settings specific for the event</param>
        [Template("$.Event({0},{arguments})")]
        public jQueryKeyboardEvent(string eventName, params object[] arguments) : base(eventName, arguments)
        {
        }

        /// <summary>
        /// Indicates whether the ALT key was pressed when the event fired.
        /// </summary>
        public readonly bool AltKey;

        /// <summary>
        /// The Unicode reference number of the key; this attribute is used only by the 'keypress' event. For keys whose char attribute contains multiple characters, this is the Unicode value of the first character in that attribute. In Firefox 26 this returns codes for printable characters.
        /// </summary>
        public readonly int CharCode;

        /// <summary>
        /// Indicates whether the CTRL key was pressed when the event fired.
        /// </summary>
        public readonly bool CtrlKey;

        /// <summary>
        /// Returns the Unicode value of a non-character key in a keypress event or any key in any other type of keyboard event.
        ///
        /// In a keypress event, the Unicode value of the key pressed is stored in either the keyCode or charCode property, never both. If the key pressed generates a character (e.g. 'a'), charCode is set to the code of that character, respecting the letter case. (i.e. charCode takes into account whether the shift key is held down). Otherwise, the code of the pressed key is stored in keyCode.
        ///
        /// keyCode is always set in the keydown and keyup events. In these cases, charCode is never set.
        ///
        /// To get the code of the key regardless of whether it was stored in keyCode or charCode, query the which property.
        ///
        /// Characters entered through an IME do not register through keyCode or charCode.
        /// </summary>
        public readonly int KeyCode;

        /// <summary>
        /// The key value of the key represented by the event. If the value has a printed representation, this attribute's value is the same as the char attribute. Otherwise, it's one of the key value strings specified in {{anch("Key values")}}. If the key can't be identified, this is the string "Unidentified". See key names for the detail. In Firefox 26 this has a valid string for non-printable characters, and some printable characters (e.g. Tab, Enter). For regular characters it returns only "MozPrintableKey". charCode works and returns the character code.
        /// </summary>
        public readonly string Key;

        /// <summary>
        /// Indicates whether the "meta" key was pressed when the event fired.
        /// Note: On the Macintosh, this is the Command key. On Microsoft Windows, this is the Windows key.
        /// </summary>
        public readonly bool MetaKey;

        /// <summary>
        /// Indicates whether the SHIFT key was pressed when the event fired.
        /// </summary>
        public readonly bool ShiftKey;

        /// <summary>
        /// Returns the numeric keyCode of the key pressed, or the character code (charCode) for an alphanumeric key pressed.
        /// </summary>
        public readonly int Which;
    }

    [Ignore]
    [Name("jQuery.Event")]
    public class jQueryMouseEvent : jQueryUiEvent
    {
        /// <summary>
        /// Creates a jQuery Event instance of the specified event
        /// </summary>
        /// <param name="eventName">The name of the event</param>
        [Template("$.Event({0})")]
        public jQueryMouseEvent(string eventName) : base(eventName)
        {
        }

        /// <summary>
        /// Creates a jQuery Event instance of the specified event
        /// </summary>
        /// <param name="eventName">The name of the event</param>
        /// <param name="arguments">A set of settings specific for the event</param>
        [Template("$.Event({0},{arguments})")]
        public jQueryMouseEvent(string eventName, params object[] arguments) : base(eventName, arguments)
        {
        }

        /// <summary>
        /// Indicates whether the ALT key was pressed when the event fired.
        /// </summary>
        public readonly bool AltKey;

        /// <summary>
        /// Indicates which mouse button caused the event.
        /// This property returns an integer value indicating the button that changed state.
        ///
        ///        0 for standard "click"; this is usually the left button for a right-handed mouse and right button for a left-handed mouse.
        ///        1 for middle button; this is usually a click on the scroll wheel's button.
        ///        2 for right button; this is usually a right-click on a right-handed mouse and left-click on a left-handed mouse.
        ///
        /// Note: This convention is not followed in Internet Explorer prior to version 9: See QuirksMode for details (http://www.quirksmode.org/js/events_properties.html#button).
        ///
        /// Notes
        ///
        /// Because mouse clicks are frequently intercepted by the user interface, it may be difficult to detect buttons other than those for a standard mouse click (usually the left button) in some circumstances.
        ///
        /// Users may change the configuration of buttons on their pointing device so that if an event's button property is zero, it may not have been caused by the button that is physically left–most on the pointing device; however, it should behave as if the left button was clicked in the standard button layout.
        /// </summary>
        public readonly int Button;

        /// <summary>
        /// The buttons being pressed when the mouse event was fired
        /// Each button that can be pressed is representd by a given number (see below). If more than one button is pressed, the value of the buttons is combined to produce a new number. For example, if the right button (2) and the wheel button (4) are pressed, the value is equal to 2|4, which is 6.
        /// A number representing one or more buttons. For more than one button pressed, the values are combined.
        ///
        /// 1  : Left button
        /// 2  : Right button
        /// 4  : Wheel button
        /// 8  : 4th button (typically the "Browser Back" button)
        /// 16 : 5th button (typically the "Browser Forward" button)
        /// </summary>
        public readonly int Buttons;

        /// <summary>
        /// Returns the horizontal coordinate within the application's client area at which the event occurred (as opposed to the coordinates within the page). For example, clicking in the top-left corner of the client area will always result in a mouse event with a clientX value of 0, regardless of whether the page is scrolled horizontally.
        /// </summary>
        public readonly int ClientX;

        /// <summary>
        /// Returns the vertical coordinate within the application's client area at which the event occurred (as opposed to the coordinates within the page). For example, clicking in the top-left corner of the client area will always result in a mouse event with a clientY value of 0, regardless of whether the page is scrolled vertically.
        /// </summary>
        public readonly int ClientY;

        /// <summary>
        /// Indicates whether the CTRL key was pressed when the event fired.
        /// </summary>
        public readonly bool CtrlKey;

        /// <summary>
        /// Returns additional numerical information about the event, depending on the type of event.
        /// For mouse events, such as click, dblclick, mousedown, or mouseup, the detail property indicates how many times the mouse has been clicked in the same location for this event.
        /// For a dblclick event the value of detail is always 2.
        /// </summary>
        public new readonly int Detail;

        /// <summary>
        /// Indicates whether the "meta" key was pressed when the event fired.
        /// Note: On the Macintosh, this is the Command key. On Microsoft Windows, this is the Windows key.
        /// </summary>
        public readonly bool MetaKey;

        /// <summary>
        /// Returns the horizontal coordinate of the event within the screen as a whole.
        /// </summary>
        public readonly int ScreenX;

        /// <summary>
        /// Returns the vertical coordinate of the event within the screen as a whole.
        /// </summary>
        public readonly int ScreenY;

        /// <summary>
        /// Indicates whether the SHIFT key was pressed when the event fired.
        /// </summary>
        public readonly bool ShiftKey;

        /// <summary>
        /// The secondary target for the event, if there is one.
        /// </summary>
        public readonly Element RelatedTarget;
    }
}
