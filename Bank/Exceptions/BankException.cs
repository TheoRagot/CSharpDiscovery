using System;

namespace Bank.Exceptions
{
	[Serializable]
	public class BankException : Exception
	{
		public BankException() { }
		public BankException(string message) : base(message) { }
		public BankException(string message, Exception inner) : base(message, inner) { }
		protected BankException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}