using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Training2.Messages
{
    public class StatusMessage
    {
        public StatusMessage(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}
