using System;

namespace Bridge.AngularJS
{
    /// <summary>
    /// Module name instance.
    /// </summary>
    [External]
    [Name("auto")]
    public class Auto
    {
        /// <summary>
        /// Auto module instance's constructor.
        /// </summary>
        public Auto()
        {
        }
    }
}

namespace Bridge.AngularJS.Services
{
    /// <summary>
    /// The $injector is used to retrieve object instances as defined by
    /// provider, instantiate types, invoke methods, and load modules.
    /// </summary>
    /// <typeparam name="T">Expected type of the instance.</typeparam>
    [External]
    public class Injector<T>
    {
        /// <summary>
        /// Return an instance of the service.
        /// </summary>
        /// <param name="name">The name of the instance to retrieve.</param>
        /// <param name="caller">
        /// An optional string to provide the origin of the function call for
        /// error messages.
        /// </param>
        /// <returns>The instance.</returns>
        public static object Get(string name, string caller = default(string))
        {
            return default(object);
        }

        /// <summary>
        /// Invoke the method and supply the method arguments from the
        /// $injector.
        /// </summary>
        /// <param name="fn">
        /// The injectable function to invoke. Function parameters are injected
        /// according to the $inject Annotation rules.
        /// </param>
        /// <param name="self">The _this_ for the invoked method.</param>
        /// <param name="locals">
        /// Optional object. If preset then any argument names are read from
        /// this object first, before the $injector is consulted.
        /// </param>
        /// <returns>
        /// The value returned by the invoked _fn_ function.
        /// </returns>
        public static object Invoke(Action fn, object self = default(object),
            object locals = default(object))
        {
            return default(object);
        }

        /// <summary>
        /// Allows the user to query if the particular service exists.
        /// </summary>
        /// <param name="name">Name of the service to query.</param>
        /// <returns>True if injector has given service.</returns>
        public static bool Has(string name)
        {
            return default(bool);
        }

        /// <summary>
        /// Create a new instance of JS type. The method takes a constructor
        /// function, invokes the new operator, and supplies all of the
        /// arguments to the constructor function as specified by the
        /// constructor annotation.
        /// </summary>
        /// <param name="type">Annotated constructor function.</param>
        /// <param name="locals">
        /// Optional object. If preset then any argument names are read from
        /// this object first, before the $injector is consulted.
        /// </param>
        /// <returns>New instance of Type.</returns>
        public static object Instantiate(Action type,
            object locals = default(object))
        {
            return default(object);
        }

        /// <summary>
        /// Returns an array of service names which the function is requesting
        /// for injection. This API is used by the injector to determine which
        /// services need to be injected into the function when the function is
        /// invoked. There are three ways in which the function can be
        /// annotated with the needed dependencies.
        /// </summary>
        /// <param name="fn">
        /// Function for which dependent service names need to be retrieved.
        /// </param>
        /// <param name="strictDi">
        /// Disallow argument name annotation inference. (default: false)
        /// </param>
        /// <returns>
        /// The names of the services which the function requires.
        /// </returns>
        public static string[] Annotate(Action fn, bool strictDi = false)
        {
            return default(string[]);
        }
    }

    /// <summary>
    /// The $provide service has a number of methods for registering components
    /// with the $injector. Many of these functions are also exposed on
    /// angular.Module.
    /// </summary>
    /// <typeparam name="T">Expected type of the instance.</typeparam>
    [External]
    public class Provide<T>
    {
        /// <summary>
        /// Register a provider function with the $injector. Provider functions
        /// are constructor functions, whose instances are responsible for
        /// "providing" a factory for a service.
        /// </summary>
        /// <param name="name">
        /// The name of the instance. NOTE: the provider will be available
        /// under name + 'Provider' key.
        /// </param>
        /// <param name="provider">
        /// Should have a $get method. The $get method will be invoked using
        /// $injector.invoke() when an instance needs to be created.
        /// </param>
        /// <returns>Registered provider instance.</returns>
        public static T Provider(string name, object provider)
        {
            return default(T);
        }

        /// <summary>
        /// Register a provider function with the $injector. Provider functions
        /// are constructor functions, whose instances are responsible for
        /// "providing" a factory for a service.
        /// </summary>
        /// <param name="name">
        /// The name of the instance. NOTE: the provider will be available
        /// under name + 'Provider' key.
        /// </param>
        /// <param name="provider">
        /// A new instance of the provider will be created using
        /// $injector.instantiate(), then treated as object.
        /// </param>
        /// <returns>Registered provider instance.</returns>
        public static T Provider(string name, Action provider)
        {
            return default(T);
        }

        /// <summary>
        /// Register a service factory, which will be called to return the
        /// service instance. This is short for registering a service where its
        /// provider consists of only a $get property, which is the given
        /// service factory function. You should use $provide.factory(getFn)
        /// if you do not need to configure your service in a provider.
        /// </summary>
        /// <param name="name">The name of the instance.</param>
        /// <param name="getFn">
        /// The injectable $getFn for the instance creation. Internally this is
        /// a short hand for $provide.provider(name, {$get: $getFn}).
        /// </param>
        /// <returns>Registered provider instance.</returns>
        public static T Factory(string name, [Name("$getFn")] Action getFn)
        {
            return default(T);
        }

        /// <summary>
        /// Register a service constructor, which will be invoked with new to
        /// create the service instance. This is short for registering a
        /// service where its provider's $get property is the service
        /// constructor function that will be used to instantiate the service
        /// instance.
        /// </summary>
        /// <param name="name">The name of the instance.</param>
        /// <param name="constructor">
        /// An injectable class (constructor function) that will be
        /// instantiated.
        /// </param>
        /// <returns>Registered provider instance.</returns>
        public static T Service(string name, Action constructor)
        {
            return default(T);
        }

        /// <summary>
        /// Register a service constructor, which will be invoked with new to
        /// create the service instance. This is short for registering a
        /// service where its provider's $get property is the service
        /// constructor function that will be used to instantiate the service
        /// instance.
        /// </summary>
        /// <param name="name">The name of the instance.</param>
        /// <param name="constructor">
        /// An injectable class (constructor function) that will be
        /// instantiated.
        /// </param>
        /// <returns>Registered provider instance.</returns>
        public static T Service(string name, Delegate constructor)
        {
            return default(T);
        }

        /// <summary>
        /// Register a value service with the $injector, such as a string, a
        /// number, an array, an object or a function. This is short for
        /// registering a service where its provider's $get property is a
        /// factory function that takes no arguments and returns the value
        /// service.
        /// </summary>
        /// <param name="name">The name of the instance.</param>
        /// <param name="value">The value.</param>
        /// <returns>Registered provider instance.</returns>
        public static T Value(string name, object value)
        {
            return default(T);
        }

        /// <summary>
        /// Register a value service with the $injector, such as a string, a
        /// number, an array, an object or a function. This is short for
        /// registering a service where its provider's $get property is a
        /// factory function that takes no arguments and returns the value
        /// service.
        /// </summary>
        /// <typeparam name="VT">Expected type of the value.</typeparam>
        /// <param name="name">The name of the instance.</param>
        /// <param name="value">The value.</param>
        /// <returns>Registered provider instance.</returns>
        public static T Value<VT>(string name, VT value)
        {
            return default(T);
        }

        /// <summary>
        /// Register a constant service, such as a string, a number, an array,
        /// an object or a function, with the $injector. Unlike value it can be
        /// injected into a module configuration function (see angular.Module)
        /// and it cannot be overridden by an Angular decorator.
        /// </summary>
        /// <param name="name">The name of the constant.</param>
        /// <param name="value">The constant value.</param>
        /// <returns>Registered instance.</returns>
        public static T Constant(string name, object value)
        {
            return default(T);
        }

        /// <summary>
        /// Register a constant service, such as a string, a number, an array,
        /// an object or a function, with the $injector. Unlike value it can be
        /// injected into a module configuration function (see angular.Module)
        /// and it cannot be overridden by an Angular decorator.
        /// </summary>
        /// <typeparam name="VT">Expected type of the value.</typeparam>
        /// <param name="name">The name of the constant.</param>
        /// <param name="value">The constant value.</param>
        /// <returns>Registered instance.</returns>
        public static T Constant<VT>(string name, VT value)
        {
            return default(T);
        }

        /// <summary>
        /// Register a service decorator with the $injector. A service
        /// decorator intercepts the creation of a service, allowing it to
        /// override or modify the behaviour of the service. The object
        /// returned by the decorator may be the original service, or a new
        /// service object which replaces or wraps and delegates to the
        /// original service.
        /// </summary>
        /// <param name="name">The name of the service to decorate.</param>
        /// <param name="decorator">
        /// This function will be invoked when the service needs to be
        /// instantiated and should return the decorated service instance. The
        /// function is called using the injector.invoke method and is
        /// therefore fully injectable. Local injection arguments:
        /// - $delegate - The original service instance, which can be monkey
        ///   patched, configured, decorated or delegated to.
        /// </param>
        public static void Decorator(string name, Func<Func<object>, object> decorator)
        {
            return;
        }

        /// <summary>
        /// Register a service decorator with the $injector. A service
        /// decorator intercepts the creation of a service, allowing it to
        /// override or modify the behaviour of the service. The object
        /// returned by the decorator may be the original service, or a new
        /// service object which replaces or wraps and delegates to the
        /// original service.
        /// </summary>
        /// <typeparam name="DT">
        /// Expected parameter and return type of the decorator function.
        /// </typeparam>
        /// <param name="name">The name of the service to decorate.</param>
        /// <param name="decorator">
        /// This function will be invoked when the service needs to be
        /// instantiated and should return the decorated service instance. The
        /// function is called using the injector.invoke method and is
        /// therefore fully injectable. Local injection arguments:
        /// - $delegate - The original service instance, which can be monkey
        ///   patched, configured, decorated or delegated to.
        /// </param>
        public static void Decorator<DT>(string name, Func<Func<DT>, DT> decorator)
        {
            return;
        }
    }

    /// <summary>
    /// The $injector is used to retrieve object instances as defined by
    /// provider, instantiate types, invoke methods, and load modules.
    /// This is an overload for a base object type.
    /// </summary>
    [External]
    public class Injector : Injector<object>
    { }

    /// <summary>
    /// The $provide service has a number of methods for registering components
    /// with the $injector. Many of these functions are also exposed on
    /// angular.Module.
    /// </summary>
    [External]
    public class Provide : Provide<object>
    { }
}