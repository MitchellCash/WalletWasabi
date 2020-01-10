using NBitcoin;
using System.Collections.Generic;
using System.Linq;

namespace WalletWasabi.Blockchain.Transactions.Operations
{
	public class Remove : ITxStoreOperation
	{
		public IEnumerable<uint256> Transactions { get; }
		public bool IsEmpty => Transactions is null || !Transactions.Any();

		public Remove(params uint256[] transactions) : this(transactions as IEnumerable<uint256>)
		{
		}

		public Remove(IEnumerable<uint256> transactions)
		{
			Transactions = transactions;
		}
	}
}
