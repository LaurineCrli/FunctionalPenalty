namespace CARLIER_Laurine_Functional_Penalty.Models
{
    public class None<T> : Option<T>
    {
        public override TResult Match<TResult>(Func<T, TResult> some, Func<TResult> none) => none();
    }
}
