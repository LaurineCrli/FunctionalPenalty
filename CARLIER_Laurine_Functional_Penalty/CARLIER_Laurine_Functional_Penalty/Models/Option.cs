namespace CARLIER_Laurine_Functional_Penalty.Models
{
    public abstract class Option<T>
    {
        public static Option<T> Some(T value) => new Some<T>(value);
        public static Option<T> None() => new None<T>();
        public abstract TResult Match<TResult>(Func<T, TResult> some, Func<TResult> none);
    }
    public class None<T> : Option<T>
    {
        public override TResult Match<TResult>(Func<T, TResult> some, Func<TResult> none) => none();
    }
    public class Some<T> : Option<T>
    {
        private T Value { get; }
        public Some(T value) => Value = value;
        public override TResult Match<TResult>(Func<T, TResult> some, Func<TResult> none) => some(Value);
    }
}
