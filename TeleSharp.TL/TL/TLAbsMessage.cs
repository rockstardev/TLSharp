using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
    public abstract class TLAbsMessage : TLObject
    {
        public int Id { get; set; }
    }
}
