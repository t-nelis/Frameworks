using System;

namespace Bridge.AngularJS
{
    public partial class jqLite
    {
        /// <summary>
        /// Add or remove one or more classes from each element in the set of
        /// matched elements, depending on either the class's presence or the
        /// value of the switch argument.
        /// </summary>
        /// <param name="className">
        /// One or more class names (separated by spaces) to be toggled for each
        /// element in the matched set.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite ToggleClass(string className)
        {
            return null;
        }

        /// <summary>
        /// Add or remove one or more classes from each element in the set of
        /// matched elements, depending on either the class's presence or the
        /// value of the switch argument.
        /// </summary>
        /// <param name="className">One or more class names (separated by
        /// spaces) to be toggled for each element in the matched set.
        /// </param>
        /// <param name="switch">
        /// A Boolean (not just truthy/falsy) value to determine whether the
        /// class should be added or removed.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite ToggleClass(string className, bool @switch)
        {
            return null;
        }

        /// <summary>
        /// Add or remove one or more classes from each element in the set of
        /// matched elements, depending on either the class's presence or the
        /// value of the switch argument.
        /// </summary>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite ToggleClass()
        {
            return null;
        }

        /// <summary>
        /// Add or remove one or more classes from each element in the set of
        /// matched elements, depending on either the class's presence or the
        /// value of the switch argument.
        /// </summary>
        /// <param name="switch">
        /// A Boolean (not just truthy/falsy) value to determine whether the
        /// class should be added or removed.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite ToggleClass(bool @switch)
        {
            return null;
        }

        /// <summary>
        /// Add or remove one or more classes from each element in the set of
        /// matched elements, depending on either the class's presence or the
        /// value of the switch argument.
        /// </summary>
        /// <param name="function">
        /// A function that returns class names to be toggled in the class
        /// attribute of each element in the matched set. Receives the index
        /// position of the element in the set, the old class value, and the
        /// switch as arguments.</param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite ToggleClass(Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Add or remove one or more classes from each element in the set of
        /// matched elements, depending on either the class's presence or the
        /// value of the switch argument.
        /// </summary>
        /// <param name="function">A function that returns class names to be
        /// toggled in the class attribute of each element in the matched set.
        /// Receives the index position of the element in the set, the old class
        /// value, and the switch as arguments.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite ToggleClass(
            Func<int, string, bool, string> function)
        {
            return null;
        }

        /// <summary>
        /// Add or remove one or more classes from each element in the set of
        /// matched elements, depending on either the class's presence or the
        /// value of the switch argument.
        /// </summary>
        /// <param name="function">
        /// A function that returns class names to be toggled in the class
        /// attribute of each element in the matched set. Receives the index
        /// position of the element in the set, the old class value, and the
        /// switch as arguments.</param>
        /// <param name="switch">
        /// A Boolean (not just truthy/falsy) value to determine whether the
        /// class should be added or removed.
        /// </param>
        /// <returns>The jqLite instance of itself.</returns>
        public virtual jqLite ToggleClass(
            Func<int, string, bool, string> function, bool @switch)
        {
            return null;
        }
    }
}