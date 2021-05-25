using CompareAssertMethods.Mock;
using FluentAssertions;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;

namespace CompareAssertMethods.Extensions
{
    public class PersonMockAssertions : ReferenceTypeAssertions<BaseTest, PersonMockAssertions>
    {
        private readonly object _actual;

        public PersonMockAssertions(object actual)
        {
            _actual = actual;
        }

        protected override string Identifier => nameof(PersonMockAssertions);

        [CustomAssertion]
        public AndConstraint<PersonMockAssertions> BeManfred()
        { 
            Execute.Assertion
                .ForCondition((_actual as PersonMock)?.Vorname == "Manfred")
                .FailWith("Person must be a Manfred :)");

            return new AndConstraint<PersonMockAssertions>(this);
        }

        [CustomAssertion]
        public AndConstraint<PersonMockAssertions> NotBeManfred()
        {
            Execute.Assertion
                .ForCondition((_actual as PersonMock)?.Vorname != "Manfred")
                .FailWith("Person must not be a Manfred :)");

            return new AndConstraint<PersonMockAssertions>(this);
        }
    }

    public static class AssertionExtensions
    {
        public static PersonMockAssertions Must(this object actual)
        {
            return new PersonMockAssertions(actual);
        }
    }
}
