namespace _20220530.Models
{
    public interface IBaseData
    {
        bool isDelete { get; set; }

        DateTime creDateTime { get; set; }

        DateTime updateDateTime { get; set; }
    }
}