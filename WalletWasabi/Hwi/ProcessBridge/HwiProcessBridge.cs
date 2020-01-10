using System.Threading;
using System.Threading.Tasks;
using WalletWasabi.Microservices;

namespace WalletWasabi.Hwi.ProcessBridge
{
	public class HwiProcessBridge : Microservices.ProcessBridge
	{
		public HwiProcessBridge() : base(MicroserviceHelpers.GetBinaryPath("hwi"))
		{
		}

		public new async Task<(string response, int exitCode)> SendCommandAsync(string arguments, bool openConsole, CancellationToken cancel)
		{
			var (responseString, exitCode) = await base.SendCommandAsync(arguments, openConsole, cancel).ConfigureAwait(false);

			string modifiedResponseString;

			if (!openConsole)
			{
				modifiedResponseString = responseString;
			}
			else
			{
				modifiedResponseString = exitCode == 0
					? "{\"success\":\"true\"}"
					: $"{{\"success\":\"false\",\"error\":\"Process terminated with exit code: {exitCode}.\"}}";
			}

			return (modifiedResponseString, exitCode);
		}
	}
}
