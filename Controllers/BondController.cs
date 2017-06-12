using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nethereum.Util;

namespace exp_bond_explorer.Controllers
{
    [Route("api/[controller]")]
    public class BondController : Controller
    {
        [HttpGet("[action]")]
        public MarketOverview TotalBonds(int input)
        {
            var marketOverview = new MarketOverview()
            {
                TotalBondsIssued = GetBondInfo("limitBonds").Result,
                TotalDistinctUsers = GetBondInfo("nBonds").Result,
                TotalBondsBought = GetBondInfo("totalBonds").Result,
                ContractBalance = GetContractBalance().Result
            };
            return marketOverview;
        }

        async Task<long> GetBondInfo(string functionName)
        {
            var contractAddress = "0x6e4a860420e024d2f269d45f85a24dc6f586376d";
            var abi = BondContract.ContractAbi;
            var web3 = new Nethereum.Web3.Web3("http://52.179.18.34:8545");
            var contract = web3.Eth.GetContract(abi, contractAddress);
            var contractFunc = contract.GetFunction(functionName);
            return await contractFunc.CallAsync<long>();
        }

        async Task<long> GetContractBalance()
        {
            var contractAddress = "0x6e4a860420e024d2f269d45f85a24dc6f586376d";
            var abi = BondContract.ContractAbi;
            var web3 = new Nethereum.Web3.Web3("http://52.179.18.34:8545");
            var contract = web3.Eth.GetContract(abi, contractAddress);
            var balance = await contract.Eth.GetBalance.SendRequestAsync(contractAddress);
            var unitConversion = new UnitConversion();
            var exp = unitConversion.FromWei(balance);
            return decimal.ToInt64(exp);
        }

        public class MarketOverview
        {
            public long TotalBondsIssued { get; set; }

            public long TotalBondsAvailable => TotalBondsIssued - TotalBondsBought;

            public long TotalDistinctUsers { get; set; }

            public long TotalBondsBought { get; set; }
            public decimal ContractBalance { get; set; }
        }
    }
}
