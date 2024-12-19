namespace CARLIER_Laurine_Functional_Penalty.Models
{    public class Some<T> : Option<T>
    {
        private T Value { get; }
        public Some(T value) => Value = value;
        public override TResult Match<TResult>(Func<T, TResult> some, Func<TResult> none) => some(Value);
    }
}
