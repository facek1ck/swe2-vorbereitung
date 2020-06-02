using System;

public class LoggerVerwenden

{
    public object Method1(int i, string str, object obj)
    {
        int amount = 0;
        ILogger log = (ILogger)obj;
        log.Info("Creating a new Invoice");
        try
        {
            log.Debug("amount = " + amount);
            if (amount == 0)
            {
                log.Warn("Creating a Invoice with amount of 0");
            }
            throw new Exception("Test");
        }
        catch (Exception ex)
        {
            log.Error(ex.Message);
        }
        return null;
    }
}
