using CompareAssertMethods.Mock;
using NUnit.Framework.Constraints;

namespace CompareAssertMethods.Extensions
{
    public class IsManfredConstraint : Constraint
    {
        public IsManfredConstraint()  : base()
        {
        }

        public override ConstraintResult ApplyTo<TActual>(TActual actual)
        {
            return new ConstraintResult(this, actual, (actual as PersonMock)?.Vorname == "Manfred");
        }
    }

    public class MyIs : NUnit.Framework.Is
    {
        public static Constraint Manfred()
        {
            return new IsManfredConstraint();
        }
    }

    public static class Verifications
    {
        public static IsManfredConstraint Manfred(this ConstraintExpression expression)
        {
            var constraint = new IsManfredConstraint();
            expression.Append(constraint);
            return constraint;
        }
    }
}
