﻿using System;

namespace Raven.Abstractions.Counters.Notifications
{
	public class CounterBulkOperationNotification : CounterStorageNotification
	{
		public Guid OperationId { get; set; }

		public BatchType Type { get; set; }

		public string Message { get; set; }
	}

	public enum BatchType
	{
		Started,
		Ended,
		Error
	}
}