namespace Project1.Comman.Interface
{
    public interface IApiListResultModel<T> : IApiResultModel
    {
        public int TotalCount { get; set; }
        public T List { get; set; }
    }
}
