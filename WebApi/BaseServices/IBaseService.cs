namespace WebApi.BaseServices
{
    public interface IBaseService<T>
    {
     
        Task<string> Insert(T entry);
        Task<string> Update(T entry);
        Task<string> DeleteById(Guid Id);

    }
}
