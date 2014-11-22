﻿using System;
using Nelibur.Sword.DataStructures;

namespace Nelibur.Sword.Extensions
{
    public static class OptionExtensions
    {
        public static Option<T> Do<T>(this Option<T> value, Action<T> action)
        {
            if (value.HasValue)
            {
                action(value.Value);
            }
            return value;
        }

        public static Option<T> Do<T>(this Option<T> value, Func<T, bool> predicate, Action<T> action)
        {
            if (value.HasNoValue)
            {
                return value;
            }
            if (predicate(value.Value))
            {
                action(value.Value);
            }
            return value;
        }

        public static Option<T> DoOnEmpty<T>(this Option<T> value, Action action)
        {
            if (value.HasNoValue)
            {
                action();
            }
            return value;
        }

        public static Option<T> Finally<T>(this Option<T> value, Action<T> action)
        {
            action(value.Value);
            return value;
        }

        public static Option<TResult> Map<TInput, TResult>(this Option<TInput> value, Func<TInput, Option<TResult>> func)
        {
            if (value.HasNoValue)
            {
                return Option<TResult>.Empty;
            }
            return func(value.Value);
        }

        public static Option<TResult> Map<TInput, TResult>(this Option<TInput> value, Func<TInput, TResult> func)
        {
            if (value.HasNoValue)
            {
                return Option<TResult>.Empty;
            }
            return func(value.Value).ToOption();
        }

        public static Option<TResult> Map<TInput, TResult>(
            this Option<TInput> value, Func<TInput, bool> predicate, Func<TInput, TResult> func)
        {
            if (value.HasNoValue)
            {
                return Option<TResult>.Empty;
            }
            if (!predicate(value.Value))
            {
                return Option<TResult>.Empty;
            }
            return func(value.Value).ToOption();
        }

        public static Option<TResult> MapOnEmpty<TInput, TResult>(this Option<TInput> value, Func<TResult> func)
        {
            if (value.HasNoValue)
            {
                return func().ToOption();
            }
            return Option<TResult>.Empty;
        }

        public static Option<T> ThrowOnEmpty<T, TException>(this Option<T> value)
            where TException : Exception, new()
        {
            if (value.HasValue)
            {
                return value;
            }
            throw Error.Type<TException>();
        }

        public static Option<T> ThrowOnEmpty<T, TException>(this Option<T> value, Func<TException> func)
            where TException : Exception
        {
            if (value.HasValue)
            {
                return value;
            }
            throw func();
        }

        public static Option<T> Where<T>(this Option<T> value, Func<T, bool> predicate)
        {
            if (value.HasNoValue)
            {
                return Option<T>.Empty;
            }
            return predicate(value.Value) ? value : Option<T>.Empty;
        }
    }
}
