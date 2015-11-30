using Bridge;
using Bridge.AngularJS.Services;
using Bridge.Html5;
using System;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Main AngularJS object/reference.
    /// </summary>
    [External]
    [Name("angular")]
    public class Angular
    {
        public static Action Bind(object self, Action fn,
            string[] args = default(string[]))
        {
            return default(Action);
        }

        public static Injector Bootstrap(Element element,
            Module[] modules = default(Module[]),
            object config = default(object))
        {
            return default(Injector);
        }

        public static T Copy<T>(T source, T destination)
        {
            return default(T);
        }

        // problem here: must return a jqLite object according to AngularJS
        // implementation -- if jQuery is not loaded. Else, return a full
        // fledged jQuery reference...
        // if that was not enough, there are a couple additional overloads
        // angular provides for both jQlite and JQuery.
        public static object Element(Element element)
        {
            return default(object);
        }

        // same problem above... :S
        public static object Element(string element)
        {
            return default(object);
        }

        public static new bool Equals(object o1, object o2)
        {
            return default(bool);
        }

        public static object Extend(object dst, object src)
        {
            return default(object);
        }

        public static object ForEach(object obj, Action iterator,
            object context = default(object))
        {
            return default(object);
        }

        // FIXME: this returns a number of different types, depending on the
        //        parsing of the JSon string.
        public static object FromJson(string json)
        {
            return default(object);
        }

        public static T Identity<T>(T value)
        {
            return default(T);
        }

        // FIXME: Is the 'modules' parameter a 'Module' list or Action/Func list
        public static Injector Injector(Module[] modules, bool strictDi = false)
        {
            return default(Injector);
        }

        public static Injector Injector(string[] modules, bool strictDi = false)
        {
            return default(Injector);
        }

        public static bool IsArray<T>(T value)
        {
            return default(bool);
        }

        public static bool IsDate<T>(T value)
        {
            return default(bool);
        }

        public static bool IsDefined<T>(T value)
        {
            return default(bool);
        }

        public static bool IsElement<T>(T value)
        {
            return default(bool);
        }

        public static bool IsFunction<T>(T value)
        {
            return default(bool);
        }

        public static bool IsNumber<T>(T value)
        {
            return default(bool);
        }

        public static bool IsObject<T>(T value)
        {
            return default(bool);
        }

        /// <summary>
        /// Checks if value is considered a string.
        /// </summary>
        /// <typeparam name="T">Type of the structure.</typeparam>
        /// <param name="value">Reference to the variable containing the data.</param>
        /// <returns></returns>
        public static bool IsString<T>(T value)
        {
            return default(bool);
        }

        /// <summary>
        /// Checks if value is undefined.
        /// </summary>
        /// <typeparam name="T">Type of the value to test against.</typeparam>
        /// <param name="value">Value reference.</param>
        /// <returns></returns>
        public static bool IsUndefined<T>(T value)
        {
            return default(bool);
        }

        /// <summary>
        /// Convert string to lowercase.
        /// </summary>
        /// <param name="what"></param>
        /// <returns></returns>
        public static string Lowercase(string what)
        {
            return default(string);
        }

        /// <summary>
        /// Define a module.
        /// </summary>
        /// <param name="name">Name of the Module.</param>
        /// <returns></returns>
        [Template("{this}.module({name}, [])")]
        public static Module Module(string name)
        {
            return default(Module);
        }

        /// <summary>
        /// Define a module.
        /// </summary>
        /// <param name="name">Name of the Module.</param>
        /// <param name="dependencies">List of modules which this module depends on.</param>
        /// <returns>The module instance.</returns>
        public static Module Module(string name, string[] dependencies)
        {
            return default(Module);
        }

        /// <summary>
        /// Do nothing.
        /// </summary>
        public static void Noop()
        {
            return;
        }

        /// <summary>
        /// Reload page with debug enabled.
        /// </summary>
        public static void ReloadWithDebugInfo()
        {
            return;
        }

        // FIXME: define what to do with multi-typed 'obj' parameter.
        //        What about possible 'undefined' return type?
        //        Param 'pretty' may be bool as well. But default it 2? :S
        public static string ToJson(object obj, int pretty = 2)
        {
            return default(string);
        }

        /// <summary>
        /// Convert string to uppercase.
        /// </summary>
        /// <param name="what"></param>
        /// <returns></returns>
        public static string Uppercase(string what)
        {
            return default(string);
        }

        /// <summary>
        /// Outputs an list of paramMaps appended by the callback.
        /// Angular.Fn((p1, p2) => { ... }, "par1", "par2"); results in
        /// [ "par1", "par2", function(p1, p2) { ... } ]
        /// </summary>
        /// <param name="callback">
        /// The callback function to be called with the mapped arguments.
        /// </param>
        /// <param name="paramMap">
        /// The sequence of string arguments to map the callback call.
        /// </param>
        [Template("[ {*paramMap}, {callback} ]")]
        public static AngularFn Fn(Delegate callback, params string[] paramMap)
        {
             return default(AngularFn);
        }
    }

    public class AngularFn
    {

    }
}

