using Bridge;
using Bridge.Html5;
using System;
using System.Collections.Generic;

namespace Bridge.jQuery2
{
    public partial class jQuery
    {
        /// <summary>
        /// Create a deep copy of the set of matched elements.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery Clone()
        {
            return null;
        }

        /// <summary>
        /// Create a deep copy of the set of matched elements.
        /// </summary>
        /// <param name="withDataAndEvents">A Boolean indicating whether event handlers should be copied along with the elements. As of jQuery 1.4, element data will be copied as well.</param>
        /// <returns></returns>
        public virtual jQuery Clone(bool withDataAndEvents)
        {
            return null;
        }

        /// <summary>
        /// Create a deep copy of the set of matched elements.
        /// </summary>
        /// <param name="withDataAndEvents">A Boolean indicating whether event handlers should be copied along with the elements. As of jQuery 1.4, element data will be copied as well.</param>
        /// <param name="deepWithDataAndEvents">A Boolean indicating whether event handlers and data for all children of the cloned element should be copied. By default its value matches the first argument's value (which defaults to false).</param>
        /// <returns></returns>
        public virtual jQuery Clone(bool withDataAndEvents, bool deepWithDataAndEvents)
        {
            return null;
        }
    }
}