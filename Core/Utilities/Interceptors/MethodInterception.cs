using Castle.DynamicProxy;
using System;

namespace Core.Utilities
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
        {
            protected virtual void OnBefore(IInvocation invocation) { }
            protected virtual void OnAfter(IInvocation invocation) { }
            protected virtual void OnException(IInvocation invocation, System.Exception e) { }
            protected virtual void OnSuccess(IInvocation invocation) { }
       
    }
    
}
