using System;

namespace Bridge.AngularJS
{
    public partial class jqLite
    {
        /// <summary>
        /// Create a deep copy of the set of matched elements.
        /// </summary>
        /// <returns>The cloned copy of the jqLite object.</returns>
        public virtual jqLite Clone()
        {
            return null;
        }

        /// <summary>
        /// Create a deep copy of the set of matched elements.
        /// </summary>
        /// <param name="withDataAndEvents">
        /// A Boolean indicating whether event handlers should be copied along
        /// with the elements. As of jQuery 1.4, element data will be copied as
        /// well.
        /// </param>
        /// <returns>The cloned copy of the jqLite object.</returns>
        public virtual jqLite Clone(bool withDataAndEvents)
        {
            return null;
        }

        /// <summary>
        /// Create a deep copy of the set of matched elements.
        /// </summary>
        /// <param name="withDataAndEvents">
        /// A Boolean indicating whether event handlers should be copied along
        /// with the elements. As of jQuery 1.4, element data will be copied as
        /// well.
        /// </param>
        /// <param name="deepWithDataAndEvents">
        /// A Boolean indicating whether event handlers and data for all
        /// children of the cloned element should be copied. By default its
        /// value matches the first argument's value (which defaults to false).
        /// </param>
        /// <returns>The cloned copy of the jqLite object.</returns>
        public virtual jqLite Clone(bool withDataAndEvents,
            bool deepWithDataAndEvents)
        {
            return null;
        }
    }
}