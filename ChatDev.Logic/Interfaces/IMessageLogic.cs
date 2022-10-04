using ChatDev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatDev.Logic.Interfaces
{
    interface IMessageLogic
    {
        void Create(Message item);
    }
}
