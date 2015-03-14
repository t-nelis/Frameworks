using Bridge;
using Bridge.Html5;
using System;
using System.Collections.Generic;

namespace Bridge.jQuery2
{    
    public partial class jQuery
    {
        /// <summary>
        /// Get the children of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery Children()
        {
            return null;
        }

        /// <summary>
        /// Get the children of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery Children(string selector)
        {
            return null;
        }

        /// <summary>
        /// For each element in the set, get the first element that matches the selector by testing the element itself and traversing up through its ancestors in the DOM tree.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery Closest(string selector)
        {
            return null;
        }     
        
        /// <summary>
        /// For each element in the set, get the first element that matches the selector by testing the element itself and traversing up through its ancestors in the DOM tree.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to match elements against.</param>
        /// <param name="element">A DOM element within which a matching element may be found. If no context is passed in then the context of the jQuery set will be used instead.</param>
        /// <returns></returns>
        public virtual jQuery Closest(string selector, Element element)
        {
            return null;
        }

        /// <summary>
        /// For each element in the set, get the first element that matches the selector by testing the element itself and traversing up through its ancestors in the DOM tree.
        /// </summary>
        /// <param name="selection">A jQuery object to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery Closest(jQuery selection)
        {
            return null;
        }

        /// <summary>
        /// For each element in the set, get the first element that matches the selector by testing the element itself and traversing up through its ancestors in the DOM tree.
        /// </summary>
        /// <param name="element">An element to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery Closest(Element element)
        {
            return null;
        }

        /// <summary>
        /// Get the descendants of each element in the current set of matched elements, filtered by a selector, jQuery object, or element.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery Find(string selector)
        {
            return null;
        }

        /// <summary>
        /// Get the descendants of each element in the current set of matched elements, filtered by a selector, jQuery object, or element.
        /// </summary>
        /// <param name="selection">A jQuery object to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery Find(jQuery selection)
        {
            return null;
        }

        /// <summary>
        /// Get the descendants of each element in the current set of matched elements, filtered by a selector, jQuery object, or element.
        /// </summary>
        /// <param name="element">An element to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery Find(Element element)
        {
            return null;
        }

        /// <summary>
        /// Get the immediately following sibling of each element in the set of matched elements. If a selector is provided, it retrieves the next sibling only if it matches that selector.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery Next()
        {
            return null;
        }

        /// <summary>
        /// Get the immediately following sibling of each element in the set of matched elements. If a selector is provided, it retrieves the next sibling only if it matches that selector.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery Next(string selector)
        {
            return null;
        }

        /// <summary>
        /// Get all following siblings of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery NextAll()
        {
            return null;
        }

        /// <summary>
        /// Get all following siblings of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery NextAll(string selector)
        {
            return null;
        }

        /// <summary>
        /// Get all following siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object passed.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery NextUntil()
        {
            return null;
        }

        /// <summary>
        /// Get all following siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object passed.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to indicate where to stop matching following sibling elements.</param>
        /// <returns></returns>
        public virtual jQuery NextUntil(string selector)
        {
            return null;
        }

        /// <summary>
        /// Get all following siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object passed.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <returns></returns>
        public virtual jQuery NextUntil(Element element)
        {
            return null;
        }

        /// <summary>
        /// Get all following siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object passed.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <returns></returns>
        public virtual jQuery NextUntil(jQuery element)
        {
            return null;
        }  
        
        /// <summary>
        /// Get all following siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object passed.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="filter">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery NextUntil(string selector, string filter)
        {
            return null;
        }

        /// <summary>
        /// Get all following siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object passed.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <param name="filter">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery NextUntil(Element element, string filter)
        {
            return null;
        }

        /// <summary>
        /// Get all following siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object passed.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <param name="filter">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery NextUntil(jQuery element, string filter)
        {
            return null;
        }

        /// <summary>
        /// Get the closest ancestor element that is positioned.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery OffsetParent()
        {
            return null;
        }

        /// <summary>
        /// Get the parent of each element in the current set of matched elements, optionally filtered by a selector.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery Parent()
        {
            return null;
        }

        /// <summary>
        /// Get the parent of each element in the current set of matched elements, optionally filtered by a selector.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery Parent(string selector)
        {
            return null;
        }

        /// <summary>
        /// Get the ancestors of each element in the current set of matched elements, optionally filtered by a selector.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery Parents()
        {
            return null;
        }

        /// <summary>
        /// Get the ancestors of each element in the current set of matched elements, optionally filtered by a selector.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery Parents(string selector)
        {
            return null;
        }

        /// <summary>
        /// Get the ancestors of each element in the current set of matched elements, up to but not including the element matched by the selector, DOM node, or jQuery object.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery ParentsUntil()
        {
            return null;
        }

        /// <summary>
        /// Get the ancestors of each element in the current set of matched elements, up to but not including the element matched by the selector, DOM node, or jQuery object.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to indicate where to stop matching following sibling elements.</param>
        /// <returns></returns>
        public virtual jQuery ParentsUntil(string selector)
        {
            return null;
        }

        /// <summary>
        /// Get the ancestors of each element in the current set of matched elements, up to but not including the element matched by the selector, DOM node, or jQuery object.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <returns></returns>
        public virtual jQuery ParentsUntil(Element element)
        {
            return null;
        }

        /// <summary>
        /// Get the ancestors of each element in the current set of matched elements, up to but not including the element matched by the selector, DOM node, or jQuery object.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <returns></returns>
        public virtual jQuery ParentsUntil(jQuery element)
        {
            return null;
        }

        /// <summary>
        /// Get the ancestors of each element in the current set of matched elements, up to but not including the element matched by the selector, DOM node, or jQuery object.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="filter">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery ParentsUntil(string selector, string filter)
        {
            return null;
        }

        /// <summary>
        /// Get the ancestors of each element in the current set of matched elements, up to but not including the element matched by the selector, DOM node, or jQuery object.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <param name="filter">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery ParentsUntil(Element element, string filter)
        {
            return null;
        }

        /// <summary>
        /// Get the ancestors of each element in the current set of matched elements, up to but not including the element matched by the selector, DOM node, or jQuery object.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <param name="filter">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery ParentsUntil(jQuery element, string filter)
        {
            return null;
        }

        /// <summary>
        /// Get the immediately preceding sibling of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery Prev()
        {
            return null;
        }

        /// <summary>
        /// Get the immediately preceding sibling of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery Prev(string selector)
        {
            return null;
        }

        /// <summary>
        /// Get all preceding siblings of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery PrevAll()
        {
            return null;
        }

        /// <summary>
        /// Get all preceding siblings of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery PrevAll(string selector)
        {
            return null;
        }

        /// <summary>
        /// Get all preceding siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery PrevUntil()
        {
            return null;
        }

        /// <summary>
        /// Get all preceding siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to indicate where to stop matching following sibling elements.</param>
        /// <returns></returns>
        public virtual jQuery PrevUntil(string selector)
        {
            return null;
        }

        /// <summary>
        /// Get all preceding siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <returns></returns>
        public virtual jQuery PrevUntil(Element element)
        {
            return null;
        }

        /// <summary>
        /// Get all preceding siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <returns></returns>
        public virtual jQuery PrevUntil(jQuery element)
        {
            return null;
        }

        /// <summary>
        /// Get all preceding siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object.
        /// </summary>
        /// <param name="selector"></param>
        /// <param name="filter">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery PrevUntil(string selector, string filter)
        {
            return null;
        }

        /// <summary>
        /// Get all preceding siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <param name="filter">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery PrevUntil(Element element, string filter)
        {
            return null;
        }

        /// <summary>
        /// Get all preceding siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object.
        /// </summary>
        /// <param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        /// <param name="filter">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery PrevUntil(jQuery element, string filter)
        {
            return null;
        }

        /// <summary>
        /// Get the siblings of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery Siblings()
        {
            return null;
        }

        /// <summary>
        /// Get the siblings of each element in the set of matched elements, optionally filtered by a selector.
        /// </summary>
        /// <param name="selector">A string containing a selector expression to match elements against.</param>
        /// <returns></returns>
        public virtual jQuery Siblings(string selector)
        {
            return null;
        }
    }
}