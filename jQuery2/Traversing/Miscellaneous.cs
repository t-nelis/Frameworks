using Bridge.Foundation;
using Bridge.Html5;
using System;
using System.Collections.Generic;

namespace Bridge.jQuery2
{    
    public partial class jQuery
    {
        /// <summary>
        /// Add elements to the set of matched elements.
        /// </summary>
        /// <param name="selector">A string representing a selector expression to find additional elements to add to the set of matched elements, or an HTML fragment to add to the set of matched elements.</param>
        /// <returns></returns>
        public virtual jQuery Add(string selector)
        {
            return null;
        }

        /// <summary>
        /// Add elements to the set of matched elements.
        /// </summary>
        /// <param name="selector">A string representing a selector expression to find additional elements to add to the set of matched elements.</param>
        /// <param name="element">The point in the document at which the selector should begin matching; similar to the context argument of the $(selector, context) method.</param>
        /// <returns></returns>
        public virtual jQuery Add(string selector, Element element)
        {
            return null;
        }

        /// <summary>
        /// Add elements to the set of matched elements.
        /// </summary>
        /// <param name="element">One or more elements to add to the set of matched elements.</param>
        /// <returns></returns>
        public virtual jQuery Add(Element element)
        {
            return null;
        }

        /// <summary>
        /// Add elements to the set of matched elements.
        /// </summary>
        /// <param name="elements">One or more elements to add to the set of matched elements.</param>
        /// <returns></returns>
        public virtual jQuery Add(Element[] elements)
        {
            return null;
        }

        /// <summary>
        /// Add elements to the set of matched elements.
        /// </summary>
        /// <param name="selection">An existing jQuery object to add to the set of matched elements.</param>
        /// <returns></returns>
        public virtual jQuery Add(jQuery selection)
        {
            return null;
        }

        /// <summary>
        /// Add the previous set of elements on the stack to the current set, optionally filtered by a selector.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery AddBack()
        {
            return null;
        }

        /// <summary>
        /// Add the previous set of elements on the stack to the current set, optionally filtered by a selector.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to match the current set of elements against.</param>
        /// <returns></returns>
        public virtual jQuery AddBack(string selector)
        {
            return null;
        }

        /// <summary>
        /// Add the previous set of elements on the stack to the current set.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery AndSelf()
        {
            return null;
        }

        /// <summary>
        /// Get the children of each element in the set of matched elements, including text and comment nodes.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery Contents()
        {
            return null;
        }

        /// <summary>
        /// Iterate over a jQuery object, executing a function for each matched element. 
        /// A function takes the two arguments: the index of the element and the element itself.
        /// Return false to break out of each() loops early.
        /// </summary>
        /// <param name="function">A function to execute for each matched element.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Each(Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Iterate over a jQuery object, executing a function for each matched element. 
        /// A function takes the two arguments: the index of the element and the element itself.
        /// Return false to break out of each() loops early.
        /// </summary>
        /// <param name="function">A function to execute for each matched element.</param>
        /// <returns>The jQuery object</returns>
        public virtual jQuery Each(Action function)
        {
            return null;
        }

        /// <summary>
        /// End the most recent filtering operation in the current chain and return the set of matched elements to its previous state.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery End()
        {
            return null;
        }

        /// <summary>
        /// Remove elements from the set of matched elements.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery Not(string selector)
        {
            return null;
        }

        /// <summary>
        /// Remove elements from the set of matched elements.
        /// </summary>
        /// <param name="element">One or more DOM elements to remove from the matched set.</param>
        /// <returns></returns>
        public virtual jQuery Not(Element element)
        {
            return null;
        }

        /// <summary>
        /// Remove elements from the set of matched elements.
        /// </summary>
        /// <param name="elements">One or more DOM elements to remove from the matched set.</param>
        /// <returns></returns>
        public virtual jQuery Not(Element[] elements)
        {
            return null;
        }

        /// <summary>
        /// Remove elements from the set of matched elements.
        /// </summary>
        /// <param name="function">A function used as a test for each element in the set. this is the current DOM element.</param>
        /// <returns></returns>
        public virtual jQuery Not(Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Remove elements from the set of matched elements.
        /// </summary>
        /// <param name="function">A function used as a test for each element in the set. this is the current DOM element.</param>
        /// <returns></returns>
        public virtual jQuery Not(Func<int, Element, bool> function)
        {
            return null;
        }

        /// <summary>
        /// Remove elements from the set of matched elements.
        /// </summary>
        /// <param name="selection">An existing jQuery object to match the current set of elements against.</param>
        /// <returns></returns>
        public virtual jQuery Not(jQuery selection)
        {
            return null;
        }
    }
}