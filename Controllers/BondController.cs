using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace exp_bond_explorer.Controllers
{
    [Route("api/[controller]")]
    public class BondController : Controller
    {
        [HttpGet("[action]")]
        public MarketOverview TotalBonds(int input)
        {
            var marketOverview = new MarketOverview() { TotalBondsIssued = GetTotalBonds().Result };
            return marketOverview;
        }

        async Task<long> GetTotalBonds()
        {
            var contractAddress = "0x6e4a860420e024d2f269d45f85a24dc6f586376d";
            var abi = BondContract.ContractAbi;
            var web3 = new Nethereum.Web3.Web3("http://52.179.18.34:8545");
            var contract = web3.Eth.GetContract(abi, contractAddress);
            var contractFunc = contract.GetFunction("totalBonds");
            var totalBonds = await contractFunc.CallAsync<long>();
            return totalBonds;
        }

        [HttpGet("[action]")]
        public MarketOverview TestTotalBonds()
        {
            return new MarketOverview() { TotalBondsIssued = 1 };
        }

        public class MarketOverview
        {
            public long TotalBondsIssued { get; set; }
        }
    }
}
