using Bridge.CLR;
using Bridge.Html5;
using System;
using System.Collections.Generic;

namespace Bridge.jQuery2
{    
    public partial class jQuery
    {
        /// <summary>
        /// Reduce the set of matched elements to the one at the specified index.
        /// </summary>
        /// <param name="index">An integer indicating the 0-based position of the element. </param>
        /// <returns></returns>
        public virtual jQuery Eq(int index)
        {
            return null;
        }

        /// <summary>
        /// Reduce the set of matched elements to those that match the selector or pass the function's test.
        /// </summary>
        /// <param name="selector"></param>
        /// <returns></returns>
        public virtual jQuery Filter(string selector)
        {
            return null;
        }

        /// <summary>
        /// Reduce the set of matched elements to those that match the selector or pass the function's test. 
        /// </summary>
        /// <param name="function">A function used as a test for each element in the set. this is the current DOM element.</param>
        /// <returns></returns>
        public virtual jQuery Filter(Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Reduce the set of matched elements to those that match the selector or pass the function's test. 
        /// </summary>
        /// <param name="function">A function used as a test for each element in the set. this is the current DOM element.</param>
        /// <returns></returns>
        public virtual jQuery Filter(Func<int, Element, bool> function)
        {
            return null;
        }

        /// <summary>
        /// Reduce the set of matched elements to those that match the selector or pass the function's test. 
        /// </summary>
        /// <param name="element">One or more DOM elements to match the current set of elements against.</param>
        /// <returns></returns>
        public virtual jQuery Filter(Element element)
        {
            return null;
        }

        /// <summary>
        /// Reduce the set of matched elements to those that match the selector or pass the function's test. 
        /// </summary>
        /// <param name="elements">One or more DOM elements to match the current set of elements against.</param>
        /// <returns></returns>
        public virtual jQuery Filter(Element[] elements)
        {
            return null;
        }

        /// <summary>
        /// Reduce the set of matched elements to those that match the selector or pass the function's test. 
        /// </summary>
        /// <param name="selection">An existing jQuery object to match the current set of elements against.</param>
        /// <returns></returns>
        public virtual jQuery Filter(jQuery selection)
        {
            return null;
        }

        /// <summary>
        /// Reduce the set of matched elements to the first in the set.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery First()
        {
            return null;
        }

        /// <summary>
        /// Reduce the set of matched elements to those that have a descendant that matches the selector or DOM element.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery Has(string selector)
        {
            return null;
        }

        /// <summary>
        /// Reduce the set of matched elements to those that have a descendant that matches the selector or DOM element.
        /// </summary>
        /// <param name="element">A DOM element to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery Has(Element element)
        {
            return null;
        }

        /// <summary>
        /// Check the current matched set of elements against a selector, element, or jQuery object and return true if at least one of these elements matches the given arguments.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual bool Is(string selector)
        {
            return false;
        }

        /// <summary>
        /// Check the current matched set of elements against a selector, element, or jQuery object and return true if at least one of these elements matches the given arguments.
        /// </summary>
        /// <param name="function">A function used as a test for the set of elements. It accepts one argument, index, which is the element's index in the jQuery collection. Within the function, this refers to the current DOM element. </param>
        /// <returns></returns>
        public virtual bool Is(Delegate function)
        {
            return false;
        }
        
        /// <summary>
        /// Check the current matched set of elements against a selector, element, or jQuery object and return true if at least one of these elements matches the given arguments.
        /// </summary>
        /// <param name="function">A function used as a test for the set of elements. It accepts one argument, index, which is the element's index in the jQuery collection. Within the function, this refers to the current DOM element. </param>
        /// <returns></returns>
        public virtual bool Is(Func<int, Element, bool> function)
        {
            return false;
        }

        /// <summary>
        /// Check the current matched set of elements against a selector, element, or jQuery object and return true if at least one of these elements matches the given arguments.
        /// </summary>
        /// <param name="selection">An existing jQuery object to match the current set of elements against.</param>
        /// <returns></returns>
        public virtual bool Is(jQuery selection)
        {
            return false;
        }

        /// <summary>
        /// Check the current matched set of elements against a selector, element, or jQuery object and return true if at least one of these elements matches the given arguments.
        /// </summary>
        /// <param name="element">One or more elements to match the current set of elements against.</param>
        /// <returns></returns>
        public virtual bool Is(Element element)
        {
            return false;
        }

        /// <summary>
        /// Check the current matched set of elements against a selector, element, or jQuery object and return true if at least one of these elements matches the given arguments.
        /// </summary>
        /// <param name="elements">One or more elements to match the current set of elements against.</param>
        /// <returns></returns>
        public virtual bool Is(Element[] elements)
        {
            return false;
        }

        /// <summary>
        /// Reduce the set of matched elements to the final one in the set.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery Last()
        {
            return null;
        }

        /// <summary>
        /// Pass each element in the current matched set through a function, producing a new jQuery object containing the return values.
        /// </summary>
        /// <param name="callback">A function object that will be invoked for each element in the current set.</param>
        /// <returns></returns>
        public virtual jQuery Map(Delegate callback)
        {
            return null;
        }

        /// <summary>
        /// Pass each element in the current matched set through a function, producing a new jQuery object containing the return values.
        /// </summary>
        /// <param name="callback">A function object that will be invoked for each element in the current set.</param>
        /// <returns></returns>
        public virtual jQuery Map(Func<int, Element, object> callback)
        {
            return null;
        }

        /// <summary>
        /// Reduce the set of matched elements to a subset specified by a range of indices.
        /// </summary>
        /// <param name="start">An integer indicating the 0-based position at which the elements begin to be selected. If negative, it indicates an offset from the end of the set.</param>
        /// <returns></returns>
        public virtual jQuery Slice(int start)
        {
            return null;
        }        
        
        /// <summary>
        /// Reduce the set of matched elements to a subset specified by a range of indices.
        /// </summary>
        /// <param name="start">An integer indicating the 0-based position at which the elements begin to be selected. If negative, it indicates an offset from the end of the set.</param>
        /// <param name="end">An integer indicating the 0-based position at which the elements stop being selected. If negative, it indicates an offset from the end of the set. If omitted, the range continues until the end of the set.</param>
        /// <returns></returns>
        public virtual jQuery Slice(int start, int end)
        {
            return null;
        }
    }
}