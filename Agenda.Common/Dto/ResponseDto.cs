using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Common.Dto
{
    public class ResponseDto
    {
        public ResponseEnum status { get; set; }
        public List<string> Message { get; set; } = new List<string>();
        public List<string> Errors { get; set; } = new List<string>();
    }
}
