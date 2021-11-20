using System;

namespace Groupware.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        //a
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
