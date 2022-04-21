namespace Virtuals
{
    internal class Searcher<TResponse, TRequest>
        where TResponse : new()
        where TRequest : new()

    {
        public TResponse Response { get; set; }
        public TRequest Request { get; set; }

    }
}
