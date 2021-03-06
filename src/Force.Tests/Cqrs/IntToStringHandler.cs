using Force.Cqrs;

namespace Force.Tests.Cqrs
{
    class IntToStringHandler: IHandler<int, string>
    {
        public string Handle(int input) => input.ToString();
    }
}