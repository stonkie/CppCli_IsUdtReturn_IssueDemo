using CppCli_IsUdtReturn_IssueDemo;

namespace CSharpConsumer
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            NativeType native = new NativeType();
            NativeType* nativePtr = &native;

            // Consistently produces : Program.cs(13,25): Error CS0570: 'ManagedType.Get(NativeType*)' is not supported by the language
            ManagedType.Get(nativePtr);
        }
    }
}
