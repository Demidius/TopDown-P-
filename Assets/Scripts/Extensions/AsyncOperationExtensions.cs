using UnityEngine;

namespace Extensions
{
    public static class AsyncOperationExtensions
    {
        public static AsyncOperationAwaiter GetAwaiter(this AsyncOperation asyncOperation) =>
            new AsyncOperationAwaiter(asyncOperation);
    }
}
