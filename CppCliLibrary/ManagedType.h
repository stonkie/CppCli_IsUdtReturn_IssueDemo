#pragma once
#include "NativeType.h"

namespace CppCli_IsUdtReturn_IssueDemo
{
    public ref class ManagedType
    {
    public:
        static NativeType Get()
        {
            return NativeType();
        }
    };    
}


