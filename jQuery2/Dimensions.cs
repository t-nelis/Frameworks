using Bridge;
using Bridge.Html5;
using System;
using System.Collections.Generic;

namespace Bridge.jQuery2
{
    public partial class jQuery
    {
        /// <summary>
        /// Get the current computed height for the first element in the set of matched elements.
        /// </summary>
        /// <returns></returns>
        public virtual int Height()
        {
            return 0;
        }

        /// <summary>
        /// Set the CSS height of every matched element.
        /// </summary>
        /// <param name="value">An integer representing the number of pixels, or an integer with an optional unit of measure appended (as a string).</param>
        /// <returns></returns>
        public virtual jQuery Height(int value)
        {
            return null;
        }

        /// <summary>
        /// Set the CSS height of every matched element.
        /// </summary>
        /// <param name="value">An integer representing the number of pixels, or an integer with an optional unit of measure appended (as a string).</param>
        /// <returns></returns>
        public virtual jQuery Height(string value)
        {
            return null;
        }

        /// <summary>
        /// Set the CSS height of every matched element.
        /// </summary>
        /// <param name="function">A function returning the height to set. Receives the index position of the element in the set and the old height as arguments. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        public virtual jQuery Height(Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Set the CSS height of every matched element.
        /// </summary>
        /// <param name="function">A function returning the height to set. Receives the index position of the element in the set and the old height as arguments. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        public virtual jQuery Height(Func<int, int, int> function)
        {
            return null;
        }

        /// <summary>
        /// Set the CSS height of every matched element.
        /// </summary>
        /// <param name="function">A function returning the height to set. Receives the index position of the element in the set and the old height as arguments. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        public virtual jQuery Height(Func<int, int, string> function)
        {
            return null;
        }

        /// <summary>
        /// Get the current computed height for the first element in the set of matched elements, including padding but not border.
        /// </summary>
        /// <returns></returns>
        public virtual int InnerHeight()
        {
            return 0;
        }

        /// <summary>
        /// Get the current computed inner width for the first element in the set of matched elements, including padding but not border.
        /// </summary>
        /// <returns></returns>
        public virtual int InnerWidth()
        {
            return 0;
        }

        /// <summary>
        /// Set the CSS inner width of each element in the set of matched elements.
        /// </summary>
        /// <param name="value">A number representing the number of pixels, or a number along with an optional unit of measure appended (as a string).</param>
        /// <returns></returns>
        public virtual jQuery InnerWidth(int value)
        {
            return null;
        }

        /// <summary>
        /// Set the CSS inner width of each element in the set of matched elements.
        /// </summary>
        /// <param name="value">A number representing the number of pixels, or a number along with an optional unit of measure appended (as a string).</param>
        /// <returns></returns>
        public virtual jQuery InnerWidth(string value)
        {
            return null;
        }

        /// <summary>
        /// Set the CSS inner width of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning the inner width (including padding but not border) to set. Receives the index position of the element in the set and the old inner width as arguments. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        public virtual jQuery InnerHeight(Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Set the CSS inner width of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning the inner width (including padding but not border) to set. Receives the index position of the element in the set and the old inner width as arguments. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        public virtual jQuery InnerHeight(Func<int, int, int> function)
        {
            return null;
        }

        /// <summary>
        /// Get the current computed height for the first element in the set of matched elements, including padding, border, and optionally margin. Returns a number (without "px") representation of the value or null if called on an empty set of elements.
        /// </summary>
        /// <returns></returns>
        public virtual int OuterHeight()
        {
            return 0;
        }

        /// <summary>
        /// Get the current computed height for the first element in the set of matched elements, including padding, border, and optionally margin. Returns a number (without "px") representation of the value or null if called on an empty set of elements.
        /// </summary>
        /// <param name="includeMargin">A Boolean indicating whether to include the element's margin in the calculation.</param>
        /// <returns></returns>
        public virtual int OuterHeight(bool includeMargin)
        {
            return 0;
        }

        /// <summary>
        /// Get the current computed width for the first element in the set of matched elements, including padding and border.
        /// </summary>
        /// <returns></returns>
        public virtual int OuterWidth()
        {
            return 0;
        }

        /// <summary>
        /// Get the current computed width for the first element in the set of matched elements, including padding and border.
        /// </summary>
        /// <param name="includeMargin">A Boolean indicating whether to include the element's margin in the calculation.</param>
        /// <returns></returns>
        public virtual int OuterWidth(bool includeMargin)
        {
            return 0;
        }

        /// <summary>
        /// Get the current computed width for the first element in the set of matched elements.
        /// </summary>
        /// <returns></returns>
        public virtual int Width()
        {
            return 0;
        }

        /// <summary>
        /// Set the CSS width of each element in the set of matched elements.
        /// </summary>
        /// <param name="value">An integer representing the number of pixels, or an integer along with an optional unit of measure appended (as a string).</param>
        /// <returns></returns>
        public virtual jQuery Width(int value)
        {
            return null;
        }

        /// <summary>
        /// Set the CSS width of each element in the set of matched elements.
        /// </summary>
        /// <param name="value">An integer representing the number of pixels, or an integer along with an optional unit of measure appended (as a string).</param>
        /// <returns></returns>
        public virtual jQuery Width(string value)
        {
            return null;
        }

        /// <summary>
        /// Set the CSS width of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning the width to set. Receives the index position of the element in the set and the old width as arguments. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        public virtual jQuery Width(Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Set the CSS width of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning the width to set. Receives the index position of the element in the set and the old width as arguments. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        public virtual jQuery Width(Func<int, int, int> function)
        {
            return null;
        }

        /// <summary>
        /// Set the CSS width of each element in the set of matched elements.
        /// </summary>
        /// <param name="function">A function returning the width to set. Receives the index position of the element in the set and the old width as arguments. Within the function, this refers to the current element in the set.</param>
        /// <returns></returns>
        public virtual jQuery Width(Func<int, int, string> function)
        {
            return null;
        }
    }
}