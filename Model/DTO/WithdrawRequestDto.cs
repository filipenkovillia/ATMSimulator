using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator.Model.DTO
{
    public class WithdrawRequestDto
    {
        public string Amount { get; set; }
        public bool IsFast { get; set; }
    }
}
