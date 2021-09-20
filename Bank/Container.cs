using Bank.Account;
using Bank.Audit;
using Bank.DateService;
using Bank.LockDown;

namespace Bank
{
	/// <summary>
	/// This interface creates instance of other class. The instance is guaranteed to stay the same for the duration of the test
	/// </summary>
	/// <remarks>
	/// DO NOT MODIFY this code
	/// </remarks>
	public interface IGlobalFactory
	{
		IAccount GetAccount(AccountType type, int accountNumber);
		ITransactionAudit GetAudit();
		ILockDownManager GetLockDownManager();
		IDateService GetDateService();
	}

	/// <summary>
	/// This class gives an entry point to the GlobalFactory class. Please note that the GlobalFactory class remains the same for the duration of a single test
	/// </summary>
	/// <remarks>
	/// DO NOT MODIFY this code
	/// </remarks>
	public static class Container
	{
		public static IGlobalFactory Factory { get; private set; }

		public static void Initialize()
		{
			Factory = new GlobalFactory();
		}
	}
}