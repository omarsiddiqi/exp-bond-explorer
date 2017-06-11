﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exp_bond_explorer
{
    public class BondContract
    {
        public const string ContractAbi = @"[
  {
    ""constant"": false,
        ""inputs"": [
        {
            ""name"": ""_bondid"",
            ""type"": ""uint256""
        }
        ],
        ""name"": ""redeemBond"",
        ""outputs"": [
        {
            ""name"": """",
            ""type"": ""bool""
        }
        ],
        ""payable"": false,
        ""type"": ""function""
    },
    {
    ""constant"": false,
    ""inputs"": [
    {
        ""name"": ""_limit"",
        ""type"": ""uint256""
    }
    ],
    ""name"": ""increaseLimit"",
    ""outputs"": [],
    ""payable"": false,
    ""type"": ""function""
},
{
""constant"": true,
""inputs"": [],
""name"": ""maturity"",
""outputs"": [
{
    ""name"": """",
    ""type"": ""uint256"",
    ""value"": ""15768000""
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": false,
""inputs"": [],
""name"": ""withdraw"",
""outputs"": [
{
""name"": """",
""type"": ""bool""
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": false,
""inputs"": [],
""name"": ""kill"",
""outputs"": [],
""payable"": false,
""type"": ""function""
},
{
""constant"": true,
""inputs"": [],
""name"": ""nUBP"",
""outputs"": [
{
""name"": """",
""type"": ""uint256"",
""value"": ""154""
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": true,
""inputs"": [
{
""name"": ""_bondid"",
""type"": ""uint256""
},
{
""name"": ""_index"",
""type"": ""uint256""
}
],
""name"": ""getBondHistory"",
""outputs"": [
{
""name"": ""block"",
""type"": ""uint256"",
""value"": ""0""
},
{
""name"": ""amount"",
""type"": ""uint256"",
""value"": ""0""
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": false,
""inputs"": [
{
""name"": ""_bondid"",
""type"": ""uint256""
}
],
""name"": ""redeemCoupon"",
""outputs"": [
{
""name"": """",
""type"": ""bool""
},
{
""name"": """",
""type"": ""uint256""
},
{
""name"": """",
""type"": ""uint256""
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": false,
""inputs"": [
{
""name"": ""_nSteps"",
""type"": ""uint256""
}
],
""name"": ""upgradeBonds"",
""outputs"": [],
""payable"": false,
""type"": ""function""
},
{
""constant"": true,
""inputs"": [],
""name"": ""coupon"",
""outputs"": [
{
""name"": """",
""type"": ""uint256"",
""value"": ""1000000000000000000""
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": true,
""inputs"": [
{
""name"": """",
""type"": ""uint256""
}
],
""name"": ""bonds"",
""outputs"": [
{
""name"": ""active"",
""type"": ""bool"",
""value"": false
},
{
""name"": ""owner"",
""type"": ""address"",
""value"": ""0x0000000000000000000000000000000000000000""
},
{
""name"": ""multiplier"",
""type"": ""uint256"",
""value"": ""0""
},
{
""name"": ""maturityTime"",
""type"": ""uint256"",
""value"": ""0""
},
{
""name"": ""lastRedemption"",
""type"": ""uint256"",
""value"": ""0""
},
{
""name"": ""nextRedemption"",
""type"": ""uint256"",
""value"": ""0""
},
{
""name"": ""created"",
""type"": ""uint256"",
""value"": ""0""
},
{
""name"": ""couponsRemaining"",
""type"": ""uint256"",
""value"": ""0""
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": true,
""inputs"": [
{
""name"": ""_bondid"",
""type"": ""uint256""
}
],
""name"": ""getBondHistoryLength"",
""outputs"": [
{
""name"": """",
""type"": ""uint256"",
""value"": ""0""
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": true,
""inputs"": [
{
""name"": ""_addr"",
""type"": ""address""
}
],
""name"": ""getUser"",
""outputs"": [
{
""name"": ""exists"",
""type"": ""bool"",
""value"": false
},
{
""name"": ""balance"",
""type"": ""uint256"",
""value"": ""0""
},
{
""name"": ""bonds"",
""type"": ""uint256[]"",
""value"": []
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": true,
""inputs"": [],
""name"": ""owner"",
""outputs"": [
{
""name"": """",
""type"": ""address"",
""value"": ""0x6a620a92ec2d11a70428b45a795909bd28aeda45""
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": true,
""inputs"": [],
""name"": ""limitBonds"",
""outputs"": [
{
""name"": """",
""type"": ""uint256"",
""value"": ""0""
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": true,
""inputs"": [],
""name"": ""price"",
""outputs"": [
{
""name"": """",
""type"": ""uint256"",
""value"": ""100000000000000000000""
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": false,
""inputs"": [
{
""name"": ""_newOwner"",
""type"": ""address""
}
],
""name"": ""changeOwner"",
""outputs"": [],
""payable"": false,
""type"": ""function""
},
{
""constant"": true,
""inputs"": [
{
""name"": """",
""type"": ""address""
}
],
""name"": ""users"",
""outputs"": [
{
""name"": ""exists"",
""type"": ""bool"",
""value"": false
},
{
""name"": ""balance"",
""type"": ""uint256"",
""value"": ""0""
},
{
""name"": ""upgraded"",
""type"": ""bool"",
""value"": false
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": false,
""inputs"": [
{
""name"": ""_bondid"",
""type"": ""uint256""
},
{
""name"": ""_to"",
""type"": ""address""
}
],
""name"": ""transfer"",
""outputs"": [
{
""name"": """",
""type"": ""bool""
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": true,
""inputs"": [],
""name"": ""nBonds"",
""outputs"": [
{
""name"": """",
""type"": ""uint256"",
""value"": ""154""
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": true,
""inputs"": [],
""name"": ""maxCoupons"",
""outputs"": [
{
""name"": """",
""type"": ""uint256"",
""value"": ""6""
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": false,
""inputs"": [],
""name"": ""deposit"",
""outputs"": [],
""payable"": true,
""type"": ""function""
},
{
""constant"": true,
""inputs"": [
{
""name"": ""_bondid"",
""type"": ""uint256""
}
],
""name"": ""getBond"",
""outputs"": [
{
""name"": ""active"",
""type"": ""bool"",
""value"": false
},
{
""name"": ""owner"",
""type"": ""address"",
""value"": ""0x0000000000000000000000000000000000000000""
},
{
""name"": ""multiplier"",
""type"": ""uint256"",
""value"": ""0""
},
{
""name"": ""maturityTime"",
""type"": ""uint256"",
""value"": ""0""
},
{
""name"": ""lastRedemption"",
""type"": ""uint256"",
""value"": ""0""
},
{
""name"": ""nextRedemption"",
""type"": ""uint256"",
""value"": ""0""
},
{
""name"": ""created"",
""type"": ""uint256"",
""value"": ""0""
},
{
""name"": ""couponsRemaining"",
""type"": ""uint256"",
""value"": ""0""
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": false,
""inputs"": [
{
""name"": ""_multiplier"",
""type"": ""uint256""
}
],
""name"": ""buy"",
""outputs"": [
{
""name"": ""bondId"",
""type"": ""uint256""
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": true,
""inputs"": [],
""name"": ""activeBonds"",
""outputs"": [
{
""name"": """",
""type"": ""uint256"",
""value"": ""8322""
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": true,
""inputs"": [],
""name"": ""period"",
""outputs"": [
{
""name"": """",
""type"": ""uint256"",
""value"": ""2628000""
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": true,
""inputs"": [],
""name"": ""totalBonds"",
""outputs"": [
{
""name"": """",
""type"": ""uint256"",
""value"": ""8322""
}
],
""payable"": false,
""type"": ""function""
},
{
""constant"": false,
""inputs"": [],
""name"": ""empty"",
""outputs"": [],
""payable"": false,
""type"": ""function""
},
{
""constant"": true,
""inputs"": [
{
""name"": ""_user"",
""type"": ""address""
}
],
""name"": ""getBalance"",
""outputs"": [
{
""name"": """",
""type"": ""uint256"",
""value"": ""0""
}
],
""payable"": false,
""type"": ""function""
},
{
""inputs"": [],
""payable"": true,
""type"": ""constructor""
},
{
""payable"": true,
""type"": ""fallback""
},
{
""anonymous"": false,
""inputs"": [
{
""indexed"": true,
""name"": ""User"",
""type"": ""address""
},
{
""indexed"": true,
""name"": ""BondId"",
""type"": ""uint256""
},
{
""indexed"": false,
""name"": ""Multiplier"",
""type"": ""uint256""
},
{
""indexed"": false,
""name"": ""MaturityTime"",
""type"": ""uint256""
}
],
""name"": ""Buys"",
""type"": ""event""
},
{
""anonymous"": false,
""inputs"": [
{
""indexed"": true,
""name"": ""Sender"",
""type"": ""address""
},
{
""indexed"": false,
""name"": ""Amount"",
""type"": ""uint256""
}
],
""name"": ""Deposits"",
""type"": ""event""
},
{
""anonymous"": false,
""inputs"": [
{
""indexed"": true,
""name"": ""User"",
""type"": ""address""
},
{
""indexed"": true,
""name"": ""BondId"",
""type"": ""uint256""
},
{
""indexed"": false,
""name"": ""Coupons"",
""type"": ""uint256""
},
{
""indexed"": false,
""name"": ""Amount"",
""type"": ""uint256""
}
],
""name"": ""RedeemCoupons"",
""type"": ""event""
},
{
""anonymous"": false,
""inputs"": [
{
""indexed"": true,
""name"": ""User"",
""type"": ""address""
},
{
""indexed"": true,
""name"": ""BondId"",
""type"": ""uint256""
},
{
""indexed"": false,
""name"": ""Amount"",
""type"": ""uint256""
}
],
""name"": ""RedeemBonds"",
""type"": ""event""
},
{
""anonymous"": false,
""inputs"": [
{
""indexed"": true,
""name"": ""TransferFrom"",
""type"": ""address""
},
{
""indexed"": true,
""name"": ""TransferTo"",
""type"": ""address""
},
{
""indexed"": true,
""name"": ""BondId"",
""type"": ""uint256""
}
],
""name"": ""Transfers"",
""type"": ""event""
},
{
""anonymous"": false,
""inputs"": [
{
""indexed"": false,
""name"": ""Amount"",
""type"": ""uint256""
},
{
""indexed"": true,
""name"": ""User"",
""type"": ""address""
}
],
""name"": ""Withdraws"",
""type"": ""event""
}
]";
        public const string ContractAddress = "0x6e4a860420e024d2f269d45f85a24dc6f586376d";
    }
}
