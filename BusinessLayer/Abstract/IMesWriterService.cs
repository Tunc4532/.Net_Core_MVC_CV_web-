using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMesWriterService : IGenericService<MesWriterMessage>
    {
        List<MesWriterMessage> GetListSenderMessage(string p);
        List<MesWriterMessage> GetListReceiverMessage(string p);
    }
}
