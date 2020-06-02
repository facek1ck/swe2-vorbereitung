using System;

public interface IStore
{
    object Load(int id);
    void Save(object obj);
}
