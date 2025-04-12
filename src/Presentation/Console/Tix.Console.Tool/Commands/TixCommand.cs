using Spectre.Console.Cli;

namespace Tix.Console.Tool.Commands;

public abstract class TixCommand<TSettings> : AsyncCommand<TSettings> 
    where TSettings : TixCommandSettings 
{
    const int SuccessFlag = 0;
    const int ErrorFlag = 1;

    protected int Success()
    {
        return SuccessFlag;
    }

    protected int Error()
    {
        return ErrorFlag;
    }
}