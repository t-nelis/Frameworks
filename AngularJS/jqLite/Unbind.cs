using System;

namespace Bridge.AngularJS
{
    /*
     * Limitations on jqLite's One():
     * No namespaces or event object parameter support.
     */
    public partial class jqLite
    {
        /// <summary>
        /// Remove all event handlers.
        /// </summary>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces or event object as parameter.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Unbind()
        {
            return null;
        }

        /// <summary>
        /// Remove a previously-attached event handler from the elements.
        /// </summary>
        /// <param name="eventType">
        /// A string containing a JavaScript event type, such as click or
        /// submit.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces or event object as parameter.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Unbind(string eventType)
        {
            return null;
        }

        /// <summary>
        /// Remove a previously-attached event handler from the elements.
        /// </summary>
        /// <param name="eventType">
        /// An Enum's option containing a JavaScript event type, such as click
        /// or submit.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces or event object as parameter.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Unbind(Enum eventType)
        {
            return null;
        }

        /// <summary>
        /// Remove a previously-attached event handler from the elements.
        /// </summary>
        /// <param name="eventType">
        /// A string containing a JavaScript event type, such as click or
        /// submit.
        /// </param>
        /// <param name="handler">
        /// The function that is to be no longer executed.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces or event object as parameter.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Unbind(string eventType, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Remove a previously-attached event handler from the elements.
        /// </summary>
        /// <param name="eventType">
        /// A string containing a JavaScript event type, such as click or
        /// submit.
        /// </param>
        /// <param name="handler">
        /// The function that is to be no longer executed.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces or event object as parameter.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Unbind(string eventType, Action handler)
        {
            return null;
        }

        /// <summary>
        /// Remove a previously-attached event handler from the elements.
        /// </summary>
        /// <param name="eventType">
        /// An Enum's option containing a JavaScript event type, such as click
        /// or submit.
        /// </param>
        /// <param name="handler">
        /// The function that is to be no longer executed.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces or event object as parameter.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Unbind(Enum eventType, Delegate handler)
        {
            return null;
        }

        /// <summary>
        /// Remove a previously-attached event handler from the elements.
        /// </summary>
        /// <param name="eventType">
        /// An Enum's option containing a JavaScript event type, such as click
        /// or submit.
        /// </param>
        /// <param name="handler">
        /// The function that is to be no longer executed.
        /// </param>
        /// <remarks>
        /// Limitations for jqLite version:
        /// Does not support namespaces or event object as parameter.
        /// </remarks>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite Unbind(Enum eventType, Action handler)
        {
            return null;
        }
    }
}