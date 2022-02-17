﻿
namespace Skyline.DataMiner.Net.Ticketing.Interfaces
{
	/// <summary>
	/// Ticket field validator interface.
	/// </summary>
	public interface ITicketFieldValidator
    {
		/// <summary>
		/// Validates the specified objects.
		/// </summary>
		/// <param name="ticket">The ticket.</param>
		/// <param name="obj">The value to validate.</param>
		/// <returns><c>true</c> if the specified value in <paramref name="obj"/> is valid; otherwise, <c>false</c>.</returns>
		bool Validate(Ticket ticket, object obj);
    }
}
