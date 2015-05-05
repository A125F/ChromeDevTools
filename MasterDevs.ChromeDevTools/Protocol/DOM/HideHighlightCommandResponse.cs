using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Hides DOM node highlight.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.HideHighlight)]
	public class HideHighlightCommandResponse
	{
	}
}
