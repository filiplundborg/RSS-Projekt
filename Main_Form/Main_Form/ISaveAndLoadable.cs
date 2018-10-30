
namespace Main_Form
{
    public interface ISaveAndLoadable<T>
    {
        void Save();
        T Load();
    }
}
