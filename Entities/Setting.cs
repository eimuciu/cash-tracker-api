using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cash_tracker_api.Entities
{
    public class Setting
    {
        public int Id { get; set; }
        public string User { get; set; } = "";
        public string Data { get; set; } = "";
    }
}