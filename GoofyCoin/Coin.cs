using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoofyCoin
{
    public class Coin
    {
        private Int32 coinId;
        private SignedMessage sgndCoin;

        public Coin(Signature mySignature)
        {
            coinId = Counter.Coin;
            sgndCoin = mySignature.SignMessage(this);
        }

        public Boolean isGoofyCoin()
        {
            return sgndCoin.PublicKey == Global.GoofyPk;
        }
    }
}
