# CppCli_IsUdtReturn_IssueDemo

This is a quick demo project for the issue reported here : https://developercommunity.visualstudio.com/t/C-CLI-mandatory-copy-elision-produces/1351295

This will fail to compile with Error CS0570: 'ManagedType.Get(NativeType*)' is not supported by the language

It produces the following IL which the C# compiler does not seem to support.

![image](https://user-images.githubusercontent.com/4596002/109372885-e4cdca80-7879-11eb-8ac5-533e9b3a04f8.png)

The IsUDtReturn attribute is the only difference compared to methods that can be used from C# properly and I’ve only seen it added for cases of mandatory copy-elision.

Using a C++ CLI method to take a non-const reference works fine from C# and is my prefered workaround at the moment.
