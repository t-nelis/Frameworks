using Bridge;
using Bridge.Html5;
using System;

namespace Bridge.jQuery2
{
    public partial class jQuery
    {
        /// <summary>
        /// Check to see if a DOM element is a descendant of another DOM element.
        /// The $.contains() method returns true if the DOM element provided by the second argument is a descendant of the DOM element provided by the first argument, whether it is a direct child or nested more deeply. Otherwise, it returns false. Only element nodes are supported; if the second argument is a text or comment node, $.contains() will return false.
        /// </summary>
        /// <param name="container">The DOM element that may contain the other element.</param>
        /// <param name="contained">The DOM element that may be contained by (a descendant of) the other element.</param>
        /// <returns>True if the container contains the contained, otherwise - false</returns>
        [Template("$.contains({0},{1})")]
        public static bool Contains(Element container, Element contained)
        {
            return false;
        }

        /// <summary>
        /// Merge the contents of two or more objects together into the first object.
        /// </summary>
        /// <param name="target">An object that will receive the new properties if additional objects are passed in or that will extend the jQuery namespace if it is the sole argument.</param>
        /// <param name="objects">Objects containing additional properties to merge in.</param>
        /// <returns>The merged object</returns>
        [Template("$.extend({0},{objects})")]
        public static object Extend(object target, params object[] objects)
        {
            return null;
        }

        /// <summary>
        /// Merge the contents of two or more objects together into the first object.
        /// </summary>
        /// <param name="deep">If true, the merge becomes recursive (aka. deep copy).</param>
        /// <param name="target">An object that will receive the new properties if additional objects are passed in or that will extend the jQuery namespace if it is the sole argument.</param>
        /// <param name="objects">Objects containing additional properties to merge in.</param>
        /// <returns>The merged object</returns>
        [Template("$.extend({0},{1},{objects})")]
        public static object Extend(bool deep, object target, params object[] objects)
        {
            return null;
        }

        /// <summary>
        /// Merge the contents of an object onto the jQuery prototype to provide new jQuery instance methods.
        /// </summary>
        /// <param name="obj">An object to merge onto the jQuery prototype.</param>
        /// <returns>The modified object</returns>
        [Template("$.fn.extend({0})")]
        public static object FnExtend(object obj)
        {
            return null;
        }

        /// <summary>
        /// Execute some JavaScript code globally.
        /// </summary>
        /// <param name="code">The JavaScript code to execute.</param>
        [Template("$.globalEval({0})")]
        public static void GlobalEval(string code)
        {
        }

        /// <summary>
        /// Finds the elements of an array which satisfy a filter function. The original array is not affected.
        /// </summary>
        /// <param name="array">The array to search through.</param>
        /// <param name="function">The function to process each item against. The first argument to the function is the item, and the second argument is the index. The function should return a Boolean value. this will be the global window object.</param>
        /// <returns>A new array that contains filtered items</returns>
        [Template("$.grep({0},{1})")]
        public static Array Grep(Array array, Delegate function)
        {
            return null;
        }

        /// <summary>
        /// Finds the elements of an array which satisfy a filter function. The original array is not affected.
        /// </summary>
        /// <param name="array">The array to search through.</param>
        /// <param name="function">The function to process each item against. The first argument to the function is the item, and the second argument is the index. The function should return a Boolean value. this will be the global window object.</param>
        /// <returns>A new array that contains filtered items</returns>
        [Template("$.grep({0},{1})")]
        public static Array Grep(Array array, Func<object, int, bool> function)
        {
            return null;
        }

        /// <summary>
        /// Finds the elements of an array which satisfy a filter function. The original array is not affected.
        /// </summary>
        /// <param name="array">The array to search through.</param>
        /// <param name="function">The function to process each item against. The first argument to the function is the item, and the second argument is the index. The function should return a Boolean value. this will be the global window object.</param>
        /// <param name="invert">If "invert" is false, or not provided, then the function returns an array consisting of all elements for which "callback" returns true. If "invert" is true, then the function returns an array consisting of all elements for which "callback" returns false.</param>
        /// <returns>A new array that contains filtered items</returns>
        [Template("$.grep({0},{1},{2})")]
        public static Array Grep(Array array, Delegate function, bool invert)
        {
            return null;
        }

        /// <summary>
        /// Finds the elements of an array which satisfy a filter function. The original array is not affected.
        /// </summary>
        /// <param name="array">The array to search through.</param>
        /// <param name="function">The function to process each item against. The first argument to the function is the item, and the second argument is the index. The function should return a Boolean value. this will be the global window object.</param>
        /// <param name="invert">If "invert" is false, or not provided, then the function returns an array consisting of all elements for which "callback" returns true. If "invert" is true, then the function returns an array consisting of all elements for which "callback" returns false.</param>
        /// <returns>A new array that contains filtered items</returns>
        [Template("$.grep({0},{1},{2})")]
        public static Array Grep(Array array, Func<object, int, bool> function, bool invert)
        {
            return null;
        }

        /// <summary>
        /// Search for a specified value within an array and return its index (or -1 if not found).
        /// </summary>
        /// <param name="value">The value to search for.</param>
        /// <param name="array">An array through which to search.</param>
        /// <param name="fromIndex">The index of the array at which to begin the search. The default is 0, which will search the whole array.</param>
        /// <returns>The index of value of -1 if not found.</returns>
        [Template("$.inArray({0},{1},{2})")]
        public static int InArray(object value, Array array, int fromIndex = 0)
        {
            return -1;
        }

        /// <summary>
        /// Determine whether the argument is an array.
        /// </summary>
        /// <param name="obj">Object to test whether or not it is an array.</param>
        /// <returns>True if the passed object is an array, otherwise - false.</returns>
        [Template("$.isArray({0})")]
        public static bool IsArray(object obj)
        {
            return false;
        }

        /// <summary>
        /// Check to see if an object is empty (contains no enumerable properties).
        /// </summary>
        /// <param name="obj">The object that will be checked to see if it's empty.</param>
        /// <returns>True if the passed object is empty, otherwise - false.</returns>
        [Template("$.isEmptyObject({0})")]
        public static bool IsEmptyObject(object obj)
        {
            return false;
        }

        /// <summary>
        /// Determine if the argument passed is a Javascript function object.
        /// </summary>
        /// <param name="obj">Object to test whether or not it is a function.</param>
        /// <returns>True if the passed object is a function, otherwise - false.</returns>
        [Template("$.isFunction({0})")]
        public static bool IsFunction(object obj)
        {
            return false;
        }

        /// <summary>
        /// Determines whether its argument is a number.
        /// </summary>
        /// <param name="obj">The value to be tested.</param>
        /// <returns>True if the passed object is a number, otherwise - false.</returns>
        [Template("$.isNumeric({0})")]
        public static bool IsNumeric(object obj)
        {
            return false;
        }

        /// <summary>
        /// Check to see if an object is a plain object (created using "{}" or "new Object").
        /// </summary>
        /// <param name="obj">The object that will be checked to see if it's a plain object.</param>
        /// <returns>True if the passed object is a plain object, otherwise - false.</returns>
        [Template("$.isPlainObject({0})")]
        public static bool IsPlainObject(object obj)
        {
            return false;
        }

        /// <summary>
        /// Determine whether the argument is a window.
        /// </summary>
        /// <param name="obj">Object to test whether or not it is a window.</param>
        /// <returns>True if the passed object is a window, otherwise - false.</returns>
        [Template("$.isWindow({0})")]
        public static bool IsWindow(object obj)
        {
            return false;
        }

        /// <summary>
        /// Check to see if a DOM node is within an XML document (or is an XML document).
        /// </summary>
        /// <param name="el">The DOM node that will be checked to see if it's in an XML document.</param>
        /// <returns>True if the passed object is ???, otherwise - false.</returns>
        [Template("$.isXMLDoc({0})")]
        public static bool IsXMLDoc(Element el)
        {
            return false;
        }

        /// <summary>
        /// Convert an array-like object into a true JavaScript array.
        /// </summary>
        /// <param name="obj">Any object to turn into a native Array.</param>
        /// <returns>An array</returns>
        [Template("$.makeArray({0})")]
        public static Array MakeArray(object obj)
        {
            return null;
        }

        /// <summary>
        /// Translate all items in an array or object to new array of items.
        /// </summary>
        /// <param name="array">The Array to translate.</param>
        /// <param name="callback">The function to process each item against. The first argument to the function is the array item, the second argument is the index in array The function can return any value. A returned array will be flattened into the resulting array. Within the function, this refers to the global (window) object.</param>
        /// <returns>An array</returns>
        [Template("$.map({0},{1})")]
        public static Array Map(Array array, Delegate callback)
        {
            return null;
        }

        /// <summary>
        /// Translate all items in an array or object to new array of items.
        /// </summary>
        /// <param name="array">The Array to translate.</param>
        /// <param name="callback">The function to process each item against. The first argument to the function is the array item, the second argument is the index in array The function can return any value. A returned array will be flattened into the resulting array. Within the function, this refers to the global (window) object.</param>
        /// <returns>An array</returns>
        [Template("$.map({0},{1})")]
        public static Array Map(Array array, Action callback)
        {
            return null;
        }

        /// <summary>
        /// Translate all items in an array or object to new array of items.
        /// </summary>
        /// <param name="obj">The Object to translate.</param>
        /// <param name="callback">The function to process each item against. The first argument to the function is the array item, the second argument is the index in array The function can return any value. A returned array will be flattened into the resulting array. Within the function, this refers to the global (window) object.</param>
        /// <returns>An array</returns>
        [Template("$.map({0},{1})")]
        public static Array Map(object obj, Delegate callback)
        {
            return null;
        }

        /// <summary>
        /// Translate all items in an array or object to new array of items.
        /// </summary>
        /// <param name="obj">The Object to translate.</param>
        /// <param name="callback">The function to process each item against. The first argument to the function is the array item, the second argument is the index in array The function can return any value. A returned array will be flattened into the resulting array. Within the function, this refers to the global (window) object.</param>
        /// <returns>An array</returns>
        [Template("$.map({0},{1})")]
        public static Array Map(object obj, Action callback)
        {
            return null;
        }

        /// <summary>
        /// Merge the contents of two arrays together into the first array.
        /// </summary>
        /// <param name="array1">The first array to merge, the elements of second added.</param>
        /// <param name="array2">The second array to merge into the first, unaltered.</param>
        /// <returns>An array</returns>
        [Template("$.merge({0},{1})")]
        public static Array Merge(Array array1, Array array2)
        {
            return null;
        }

        /// <summary>
        /// An empty function.
        /// </summary>
        [Template("$.noop()")]
        public static void Noop()
        {
        }

        /// <summary>
        /// Return a number representing the current time.
        /// The $.now() method is a shorthand for the number returned by the expression (new Date).getTime().
        /// </summary>
        /// <returns>Return a number representing the current time.</returns>
        [Template("$.now()")]
        public static double Now()
        {
            return -1;
        }

        /// <summary>
        /// Parses a string into an array of DOM nodes.
        /// </summary>
        /// <param name="data">HTML string to be parsed</param>
        /// <returns>An array of DOM nodes</returns>
        [Template("$.parseHTML({0})")]
        public static Element[] ParseHTML(string data)
        {
            return null;
        }

        /// <summary>
        /// Parses a string into an array of DOM nodes.
        /// </summary>
        /// <param name="data">HTML string to be parsed</param>
        /// <param name="context">Document element to serve as the context in which the HTML fragment will be created</param>
        /// <param name="keepScripts">A Boolean indicating whether to include scripts passed in the HTML string</param>
        /// <returns>An array of DOM nodes</returns>
        [Template("$.parseHTML({0},{1})")]
        public static Element[] ParseHtml(string data, Element context, bool keepScripts = false)
        {
            return null;
        }

        /// <summary>
        /// Takes a well-formed JSON string and returns the resulting JavaScript object.
        /// </summary>
        /// <param name="json">The JSON string to parse.</param>
        /// <returns>A JSON object</returns>
        [Template("$.parseJSON({0})")]
        public static object ParseJSON(string json)
        {
            return null;
        }

        /// <summary>
        /// Parses a string into an XML document.
        /// </summary>
        /// <param name="data">a well-formed XML string to be parsed</param>
        /// <returns>An XMLDocument</returns>
        [Template("$.parseXML({0})")]
        public static Element ParseXML(string data) // TODO: XMLDocument?
        {
            return null;
        }

        /// <summary>
        /// Takes a function and returns a new one that will always have a particular context.
        /// </summary>
        /// <param name="function">The function whose context will be changed.</param>
        /// <param name="context">The object to which the context (this) of the function should be set.</param>
        /// <returns>A new function that will always have a particular context.</returns>
        [Template("$.proxy({0},{1})")]
        public static Delegate Proxy(Delegate function, object context)
        {
            return null;
        }

        /// <summary>
        /// Takes a function and returns a new one that will always have a particular context.
        /// </summary>
        /// <param name="function">The function whose context will be changed.</param>
        /// <param name="context">The object to which the context (this) of the function should be set.</param>
        /// <returns>A new function that will always have a particular context.</returns>
        [Template("$.proxy({0},{1})")]
        public static Delegate Proxy(Action function, object context)
        {
            return null;
        }

        /// <summary>
        /// Takes a function and returns a new one that will always have a particular context.
        /// </summary>
        /// <param name="function">The function whose context will be changed.</param>
        /// <param name="context">The object to which the context (this) of the function should be set.</param>
        /// <param name="additionalArguments">Any number of arguments to be passed to the function referenced in the function argument.</param>
        /// <returns>A new function that will always have a particular context.</returns>
        [Template("$.proxy({0},{1},{additionalArguments})")]
        public static Delegate Proxy(Delegate function, object context, params object[] additionalArguments)
        {
            return null;
        }

        /// <summary>
        /// Takes a function and returns a new one that will always have a particular context.
        /// </summary>
        /// <param name="function">The function whose context will be changed.</param>
        /// <param name="context">The object to which the context (this) of the function should be set.</param>
        /// <param name="additionalArguments">Any number of arguments to be passed to the function referenced in the function argument.</param>
        /// <returns>A new function that will always have a particular context.</returns>
        [Template("$.proxy({0},{1},{additionalArguments})")]
        public static Delegate Proxy(Action function, object context, params object[] additionalArguments)
        {
            return null;
        }

        /// <summary>
        /// Takes a function and returns a new one that will always have a particular context.
        /// </summary>
        /// <param name="function">The function whose context will be changed.</param>
        /// <param name="name">The name of the function whose context will be changed (should be a property of the context object).</param>
        /// <returns>A new function that will always have a particular context.</returns>
        [Template("$.proxy({0},{1})")]
        public static Delegate Proxy(Delegate function, string name)
        {
            return null;
        }

        /// <summary>
        /// Takes a function and returns a new one that will always have a particular context.
        /// </summary>
        /// <param name="function">The function whose context will be changed.</param>
        /// <param name="name">The name of the function whose context will be changed (should be a property of the context object).</param>
        /// <returns>A new function that will always have a particular context.</returns>
        [Template("$.proxy({0},{1})")]
        public static Delegate Proxy(Action function, string name)
        {
            return null;
        }

        /// <summary>
        /// Takes a function and returns a new one that will always have a particular context.
        /// </summary>
        /// <param name="function">The function whose context will be changed.</param>
        /// <param name="name">The name of the function whose context will be changed (should be a property of the context object).</param>
        /// <param name="additionalArguments">Any number of arguments to be passed to the function referenced in the function argument.</param>
        /// <returns>A new function that will always have a particular context.</returns>
        [Template("$.proxy({0},{1},{additionalArguments})")]
        public static Delegate Proxy(Delegate function, string name, params object[] additionalArguments)
        {
            return null;
        }

        /// <summary>
        /// Takes a function and returns a new one that will always have a particular context.
        /// </summary>
        /// <param name="function">The function whose context will be changed.</param>
        /// <param name="name">The name of the function whose context will be changed (should be a property of the context object).</param>
        /// <param name="additionalArguments">Any number of arguments to be passed to the function referenced in the function argument.</param>
        /// <returns>A new function that will always have a particular context.</returns>
        [Template("$.proxy({0},{1},{additionalArguments})")]
        public static Delegate Proxy(Action function, string name, params object[] additionalArguments)
        {
            return null;
        }

        /// <summary>
        /// A collection of properties that represent the presence of different browser features or bugs. Intended for jQuery's internal use; specific properties may be removed when they are no longer needed internally to improve page startup performance. For your own project's feature-detection needs, we strongly recommend the use of an external library such as Modernizr instead of dependency on properties in jQuery.support.
        /// </summary>
        [Template("$.support")]
        public static object Support; // TODO: a Dictionary<string, bool>? an individual class?

        /// <summary>
        /// Remove the whitespace from the beginning and end of a string.
        /// </summary>
        /// <param name="str">The string to trim.</param>
        /// <returns>A trimmed string</returns>
        [Template("$.trim({0})")]
        public static string Trim(string str)
        {
            return null;
        }

        /// <summary>
        /// Determine the internal JavaScript [[Class]] of an object.
        /// </summary>
        /// <param name="obj">Object to get the internal JavaScript [[Class]] of.</param>
        /// <returns>The type string</returns>
        [Template("$.type({0})")]
        public static string Type(object obj)
        {
            return null;
        }

        /// <summary>
        /// Sorts an array of DOM elements, in place, with the duplicates removed. Note that this only works on arrays of DOM elements, not strings or numbers.
        /// </summary>
        /// <param name="array">The Array of DOM elements.</param>
        /// <returns>An array with unique elements</returns>
        [Template("$.unique({0})")]
        public static Element[] Unique(Element[] array)
        {
            return null;
        }
    }
}