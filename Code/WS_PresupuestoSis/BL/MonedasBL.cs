using LD;
using System;

namespace BL
{
    class MonedasBL:BaseModel
    {
        readonly Lazy<MonedasLD> _monedaslD = new Lazy<MonedasLD>(() => new MonedasLD());
        MonedasLD ModenadasLd { get { return _monedaslD.Value; } }

    }
}
