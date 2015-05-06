using Bridge;
using Bridge.Html5;
using System;
using System.Collections.Generic;

namespace Bridge.jQuery2
{
    public partial class jQuery
    {
        /// <summary>
        /// Retrieve the elements matched by the jQuery object.
        /// </summary>
        /// <returns></returns>
        public virtual Array Get()
        {
            return null;
        }

        /// <summary>
        /// Retrieve one of the elements matched by the jQuery object.
        /// </summary>
        /// <param name="index">A zero-based integer indicating which element to retrieve.</param>
        /// <returns></returns>
        public Element Get(int index)
        {
            return null;
        }

        /// <summary>
        /// Search for a given element from among the matched elements.
        /// </summary>
        /// <returns></returns>
        public virtual int Index()
        {
            return 0;
        }

        /// <summary>
        /// Search for a given element from among the matched elements.
        /// </summary>
        /// <param name="selector">The DOM element or first element within the jQuery object to look for.</param>
        /// <returns></returns>
        public virtual int Index(string selector)
        {
            return 0;
        }

        /// <summary>
        /// Search for a given element from among the matched elements.
        /// </summary>
        /// <param name="element">The DOM element or first element within the jQuery object to look for.</param>
        /// <returns></returns>
        public virtual int Index(Element element)
        {
            return 0;
        }

        /// <summary>
        /// Search for a given element from among the matched elements.
        /// </summary>
        /// <param name="element">The DOM element or first element within the jQuery object to look for.</param>
        /// <returns></returns>
        public virtual int Index(jQuery element)
        {
            return 0;
        }

        /// <summary>
        /// Retrieve all the elements contained in the jQuery set, as an array.
        /// </summary>
        /// <returns></returns>
        public virtual Array ToArray()
        {
            return null;
        }
    }
}