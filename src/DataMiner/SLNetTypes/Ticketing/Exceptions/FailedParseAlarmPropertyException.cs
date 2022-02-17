﻿using System;

namespace Skyline.DataMiner.Net.Ticketing
{
	/// <summary>
	/// The exception that is thrown when parsing failed for an alarm property.
	/// </summary>
	public class FailedParseAlarmPropertyException : Exception
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="FailedParseAlarmPropertyException"/> class.
		/// </summary>
		public FailedParseAlarmPropertyException()
        {
        }

		/// <summary>
		/// Initializes a new instance of the <see cref="FailedParseAlarmPropertyException"/> class using the specified message.
		/// </summary>
		public FailedParseAlarmPropertyException(string message) : base(message)
        {
        }

		/// <summary>
		/// Initializes a new instance of the <see cref="FailedParseAlarmPropertyException"/> class using the specified message and inner exception.
		/// </summary>
		public FailedParseAlarmPropertyException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
