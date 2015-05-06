using Bridge;
using Bridge.Html5;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bridge.jQuery2
{
    public partial class jQuery
    {
        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery FadeIn()
        {
            return null;
        }

        //[Template("Bridge.Task.fromCallbackOptions({this}, 'fadeIn', 'complete')")]
        [Template("Bridge.Task.fromPromise({this}.fadeIn())")]
        public virtual Task FadeInTask()
        {
            return null;
        }

        [Template("Bridge.Task.fromPromise({this}.fadeIn({0}))")]
        public virtual Task FadeInTask(int duration)
        {
            return null;
        }

        [Template("Bridge.Task.fromPromise({this}.fadeIn({0}, {1}))")]
        public virtual Task FadeInTask(int duration, string easing)
        {
            return null;
        }

        [Template("Bridge.Task.fromPromise({this}.fadeIn({0}))")]
        public virtual Task FadeInTask(EffectOptions options)
        {
            return null;
        }

        //[Template("Bridge.Task.fromCallbackOptions({this}, 'fadeOut', 'complete')")]
        [Template("Bridge.Task.fromPromise({this}.fadeOut())")]
        public virtual Task FadeOutTask()
        {
            return null;
        }

        [Template("Bridge.Task.fromPromise({this}.fadeOut({0}))")]
        public virtual Task FadeOutTask(int duration)
        {
            return null;
        }

        [Template("Bridge.Task.fromPromise({this}.fadeOut({0}, {1}))")]
        public virtual Task FadeOutTask(int duration, string easing)
        {
            return null;
        }

        [Template("Bridge.Task.fromPromise({this}.fadeOut({0}))")]
        public virtual Task FadeOutTask(EffectOptions options)
        {
            return null;
        }

        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <returns></returns>
        public virtual jQuery FadeIn(int duration)
        {
            return null;
        }

        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeIn(int duration, Delegate complete)
        {
            return null;
        }

        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeIn(int duration, Action complete)
        {
            return null;
        }

        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <returns></returns>
        public virtual jQuery FadeIn(string duration)
        {
            return null;
        }

        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeIn(string duration, Delegate complete)
        {
            return null;
        }

        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeIn(string duration, Action complete)
        {
            return null;
        }

        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        /// <param name="options">A map of additional options to pass to the method.</param>
        /// <returns></returns>
        public virtual jQuery FadeIn(EffectOptions options)
        {
            return null;
        }

        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <returns></returns>
        public virtual jQuery FadeIn(int duration, string easing)
        {
            return null;
        }

        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <returns></returns>
        public virtual jQuery FadeIn(string duration, string easing)
        {
            return null;
        }

        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeIn(int duration, string easing, Delegate complete)
        {
            return null;
        }

        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeIn(int duration, string easing, Action complete)
        {
            return null;
        }

        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeIn(string duration, string easing, Delegate complete)
        {
            return null;
        }

        /// <summary>
        /// Display the matched elements by fading them to opaque.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeIn(string duration, string easing, Action complete)
        {
            return null;
        }

        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        /// <returns></returns>
        public virtual jQuery FadeOut()
        {
            return null;
        }

        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <returns></returns>
        public virtual jQuery FadeOut(int duration)
        {
            return null;
        }

        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeOut(int duration, Delegate complete)
        {
            return null;
        }

        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeOut(int duration, Action complete)
        {
            return null;
        }

        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <returns></returns>
        public virtual jQuery FadeOut(string duration)
        {
            return null;
        }

        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeOut(string duration, Delegate complete)
        {
            return null;
        }

        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeOut(string duration, Action complete)
        {
            return null;
        }

        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        /// <param name="options">A map of additional options to pass to the method.</param>
        /// <returns></returns>
        public virtual jQuery FadeOut(EffectOptions options)
        {
            return null;
        }

        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <returns></returns>
        public virtual jQuery FadeOut(int duration, string easing)
        {
            return null;
        }

        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <returns></returns>
        public virtual jQuery FadeOut(string duration, string easing)
        {
            return null;
        }

        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeOut(int duration, string easing, Delegate complete)
        {
            return null;
        }

        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeOut(int duration, string easing, Action complete)
        {
            return null;
        }

        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeOut(string duration, string easing, Delegate complete)
        {
            return null;
        }

        /// <summary>
        /// Hide the matched elements by fading them to transparent.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeOut(string duration, string easing, Action complete)
        {
            return null;
        }

        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <returns></returns>
        public virtual jQuery FadeTo(int duration)
        {
            return null;
        }

        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <returns></returns>
        public virtual jQuery FadeTo(string duration)
        {
            return null;
        }

        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        /// <returns></returns>
        public virtual jQuery FadeTo(int duration, int opacity)
        {
            return null;
        }

        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        /// <returns></returns>
        public virtual jQuery FadeTo(string duration, int opacity)
        {
            return null;
        }

        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeTo(int duration, int opacity, Delegate complete)
        {
            return null;
        }

        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeTo(int duration, int opacity, Action complete)
        {
            return null;
        }

        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeTo(string duration, int opacity, Delegate complete)
        {
            return null;
        }

        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeTo(string duration, int opacity, Action complete)
        {
            return null;
        }

        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <returns></returns>
        public virtual jQuery FadeTo(int duration, int opacity, string easing)
        {
            return null;
        }

        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <returns></returns>
        public virtual jQuery FadeTo(string duration, int opacity, string easing)
        {
            return null;
        }

        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeTo(int duration, int opacity, string easing, Delegate complete)
        {
            return null;
        }

        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeTo(int duration, int opacity, string easing, Action complete)
        {
            return null;
        }

        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeTo(string duration, int opacity, string easing, Delegate complete)
        {
            return null;
        }

        /// <summary>
        /// Adjust the opacity of the matched elements.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeTo(string duration, int opacity, string easing, Action complete)
        {
            return null;
        }

        /// <summary>
        /// Display or hide the matched elements by animating their opacity.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <returns></returns>
        public virtual jQuery FadeToggle(int duration)
        {
            return null;
        }

        /// <summary>
        /// Display or hide the matched elements by animating their opacity.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <returns></returns>
        public virtual jQuery FadeToggle(string duration)
        {
            return null;
        }

        /// <summary>
        /// Display or hide the matched elements by animating their opacity.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <returns></returns>
        public virtual jQuery FadeToggle(int duration, string easing)
        {
            return null;
        }

        /// <summary>
        /// Display or hide the matched elements by animating their opacity.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <returns></returns>
        public virtual jQuery FadeToggle(string duration, string easing)
        {
            return null;
        }

        /// <summary>
        /// Display or hide the matched elements by animating their opacity.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeToggle(int duration, string easing, Delegate complete)
        {
            return null;
        }

        /// <summary>
        /// Display or hide the matched elements by animating their opacity.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeToggle(int duration, string easing, Action complete)
        {
            return null;
        }

        /// <summary>
        /// Display or hide the matched elements by animating their opacity.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeToggle(string duration, string easing, Delegate complete)
        {
            return null;
        }

        /// <summary>
        /// Display or hide the matched elements by animating their opacity.
        /// </summary>
        /// <param name="duration">A string or number determining how long the animation will run.</param>
        /// <param name="easing">A string indicating which easing function to use for the transition.</param>
        /// <param name="complete">A function to call once the animation is complete.</param>
        /// <returns></returns>
        public virtual jQuery FadeToggle(string duration, string easing, Action complete)
        {
            return null;
        }

        /// <summary>
        /// Display or hide the matched elements by animating their opacity.
        /// </summary>
        /// <param name="options">A map of additional options to pass to the method.</param>
        /// <returns></returns>
        public virtual jQuery FadeToggle(EffectOptions options)
        {
            return null;
        }
    }
}