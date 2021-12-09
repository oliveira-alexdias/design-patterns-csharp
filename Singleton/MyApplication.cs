using System;

namespace Singleton
{
    public sealed class MyApplication
    {
        private static Guid _runningSingletonId;
        private static Guid _requestId;

        // Singleton
        public static Guid GetRunningId()
        {
            if (_runningSingletonId == Guid.Empty)
            {
                _runningSingletonId = Guid.NewGuid();
            }

            return _runningSingletonId;
        }

        public static Guid GetRequestId()
        {
            _requestId = Guid.NewGuid();
            return _requestId;
        }
    }
}