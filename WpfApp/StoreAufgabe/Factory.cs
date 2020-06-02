using System;

public class Factory
{
   public object Create(int type)
    {
        switch (type)
        {
            case 1: return new FileStore();
            case 2: return new MemoryStore();
            default: throw new Exception("Invalid type!");
        }

    }
}
