﻿using System;

namespace Xunit.Tests.Equals
{
    [Obsolete("Tests replaced by Equal")]
    public abstract class Base : TestBase
    {
        private const string AnyExceptionMessage = "my_message";
        private readonly object ObjectA = new object();
        private readonly object ObjectB = new object();

        [Fact]
        public void throw_exception_when_objects_are_not_equal()
            => AssertThrowAssumptionException(() => Act(ObjectA, ObjectB));

        [Fact]
        public void throw_exception_when_objects_are_not_equal_with_specific_message()
            => AssertThrowAssumptionExceptionWithMessage(() => Act(ObjectA, ObjectB, AnyExceptionMessage), AnyExceptionMessage);

        [Fact]
        public void do_nothing_when_objects_are_equal()
            => AssertAssumptionExceptionNotThrown(() => Act(ObjectA, ObjectA));

        [Fact]
        public void return_true_when_objects_are_equal()
            => Assert.True(Act(ObjectA, ObjectA));

        protected abstract bool Act(object objA, object objB, string message = null);
    }
}
