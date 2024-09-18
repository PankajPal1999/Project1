using Project1.Comman.Interface;

namespace Project1.Entity.Model.Comman
{
    public class ListModel<T> : IApiListResultModel<T>
    {
        public int TotalCount { get; set; }
        public T List { get; set; }
    }
}
