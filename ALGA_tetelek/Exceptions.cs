using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGA_tetelek
{
    internal class Exceptions
    {
        [Serializable]
        internal class NincsElemException : Exception
        {
            public NincsElemException()
            {
            }

            public NincsElemException(string? message) : base(message)
            {
            }

            public NincsElemException(string? message, Exception? innerException) : base(message, innerException)
            {
            }
        }

        internal class NincsHelyException : Exception
        {
            public NincsHelyException()
            {
            }

            public NincsHelyException(string? message) : base(message)
            {
            }

            public NincsHelyException(string? message, Exception? innerException) : base(message, innerException)
            {
            }
        }
    }
}
