namespace LibraryClassLab04.Interfaces
{
    interface ILinearDataStructure<T>
    {
        void Add(T value);
        T Delete();
        T Get();
    }
}