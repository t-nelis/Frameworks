using Bridge.Html5;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Extension methods for the ngRepeat directive.
    /// </summary>
    public static class RepeatDirectives
    {
        /// <summary>
        /// Gets the current textual value of ng-repeat (ngRepeat)
        /// directive bound to the element, if any.
        /// </summary>
        /// <param name="el"></param>
        /// <returns>String value the element currently has.</returns>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngRepeat">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.getAttribute('ng-repeat')")]
        public static string GetNGRepeat(this Element el)
        {
            return default(string);
        }
        
        /// <summary>
        /// Sets a textual value to the ng-repeat (ngRepeat)
        /// directive on the element.
        /// </summary>
        /// <param name="el"></param>
        /// <param name="value">Value to bind to the directive.</param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngRepeat">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.setAttribute('ng-repeat', {value})")]
        public static void SetNGRepeat(this Element el, string value)
        {
        }
        
        /// <summary>
        /// Removes the ng-repeat (ngRepeat) directive definition
        /// from the element.
        /// </summary>
        /// <param name="el"></param>
        /// <see cref="!:https://docs.angularjs.org/api/ng/directive/ngRepeat">
        /// Official JavaScript documentation.
        /// </see>
        [Template("{el}.removeAttribute('ng-repeat')")]
        public static void RemoveNGRepeat(this Element el)
        {
        }

        /// <summary>
        /// Sets the NG repeat to the element with the specified free text
        /// expression.
        /// </summary>
        /// <param name="el">Element to apply the ngRepeat to</param>
        /// <param name="expression">Valid ngRepeat AngularJS expression</param>
        /// <remarks>Must be used inside a ngController scope</remarks>
        [Template("{el}.setAttribute('ng-repeat', {expression})")]
        public static void SetNGRepeat(this Element el, string expression)
        {
        }

        /// <summary>
        /// Sets the NG repeat to the element with the specified iteration
        /// variable and iterated array names.
        /// </summary>
        /// <param name="el">Element to apply ngRepeat to</param>
        /// <param name="variable">Iteration variable</param>
        /// <param name="array">Existing array in the scoped controller.</param>
        /// <remarks>Must be used inside a ngController scope</remarks>
        [Template("{el}.setAttribute('ng-repeat', " +
            "'' + {variable} + ' in ' + {array})")]
        public static void SetNGRepeat(this Element el, string variable,
            string array)
        {
        }

        // FIXME: There are much more over Filter and OrderBy. Another approach
        //        will have to be taken.
        /// <summary>
        /// Sets the NG repeat to the element with the specified iteration
        /// variable, iterated array and filter input field.
        /// </summary>
        /// <param name="el">Element to apply ngRepeat to</param>
        /// <param name="variable">Iteration variable</param>
        /// <param name="array">Existing array in the scoped controller.</param>
        /// <param name="filterInputField">Filter input field.</param>
        /// <remarks>
        /// Must be used inside a ngController scope and input field for filter
        /// must be defined somewhere else in the page
        /// </remarks>
        [Template("{el}.setAttribute('ng-repeat', " +
                  "'' + {variable} + ' in ' + {array} + ' | " +
                  "filter:' + {filterInputField})")]
        public static void SetNGRepeatWithFilter(this Element el,
            string variable, string array, string filterInputField)
        {
        }

        /// <summary>
        /// Sets the NG repeat to the element with the specified iteration
        /// variable, iterated array, filter input and order input fields.
        /// </summary>
        /// <param name="el">Element to apply ngRepeat to.</param>
        /// <param name="variable">Iteration variable.</param>
        /// <param name="array">Existing array in the scoped controller.</param>
        /// <param name="filterInputField">Filter input field.</param>
        /// <param name="orderByInputField">Order by input field.</param>
        /// <remarks>
        /// Must be used inside a ngController scope and input field for filter
        /// must be defined somewhere else in the page
        /// </remarks>
        [Template("{el}.setAttribute('ng-repeat', " +
                  "'' + {variable} + ' in ' + {array} + ' | " +
                  "filter: ' + {filterInputField} + ' | " +
                  "orderBy: ' + {orderByInputField})")]
        public static void SetNGRepeat(this Element el, string variable,
            string array, string filterInputField, string orderByInputField)
        {
        }

        /// <summary>
        /// Sets the NG repeat to the element with the specified iteration
        /// variable, iterated array and OrderBy input field.
        /// </summary>
        /// <param name="el">El.</param>
        /// <param name="variable">Variable.</param>
        /// <param name="array">Array.</param>
        /// <param name="orderByInputField">Order by input field.</param>
        [Template("{el}.setAttribute('ng-repeat', " +
                  "'' + {variable} + ' in ' + {array} + ' | " +
                  "orderBy: ' + {orderByInputField})")]
        public static void SetNGRepeatWithOrderBy(this Element el,
            string variable, string array, string orderByInputField)
        {
        }
    }
}