using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Exceptions
{
    public class UserNotFoundException : GeneralException
    {
        public UserNotFoundException(string ErrorMessage) : base(ErrorMessage)
        { }
    }
}
