﻿using Skyline.DataMiner.Net.ServiceManager.Objects;
using System.Collections.Generic;
using Skyline.DataMiner.Net.ResourceManager.Objects;
using Skyline.DataMiner.Net.AppPackages;
using Skyline.DataMiner.Net.Ticketing;
using System;
using Skyline.DataMiner.Net.History;
using SLNetTypes.DataMiner.Net;
using SLNetTypes.Apps.DataMinerObjectModel.Actions;

namespace Skyline.DataMiner.Automation
{
	/// <summary>
	/// Defines the possible Automation script entry point delegate types.
	/// </summary>
	/// <remarks>Available from DataMiner 9.5.12 onwards (RN 18229).</remarks>
	public class AutomationEntryPointDelegates
	{
		/// <summary>
		/// Encapsulates a method that has one <see cref="IEngine"/> parameter and no return value.
		/// </summary>
		/// <param name="engine">The <see cref="IEngine"/> instance.</param>
		public delegate void Default(IEngine engine);

		/// <summary>
		/// Encapsulates a method that will be used as the Automation entry point method for testing purposes.
		/// </summary>
		/// <param name="engine">The <see cref="IEngine"/> instance.</param>
		/// <param name="testMessage">A message.</param>
		/// <param name="testIntList"></param>
		public delegate void AutomationEntryPointTest(IEngine engine, string testMessage, List<int> testIntList);

		/// <summary>
		/// Encapsulates a method that will be used as the Automation entry point method with SRM service info state changes.
		/// </summary>
		/// <param name="engine">The <see cref="IEngine"/> instance.</param>
		/// <param name="oldState">The old service state.</param>
		/// <param name="newState">The new service state.</param>
		public delegate void SRMServiceInfoStateChanges(IEngine engine, SRMServiceState oldState, SRMServiceState newState);

		/// <summary>
		/// Delegate type for SRM quarantine trigger.
		/// </summary>
		/// <param name="engine">The <see cref="IEngine"/> instance.</param>
		/// <param name="reservations">The reservations.</param>
		public delegate void OnSrmQuarantineTrigger(IEngine engine, List<ReservationInstanceID> reservations);

		/// <summary>
		/// Delegate type for SRM start actions failure.
		/// </summary>
		/// <param name="engine">The <see cref="IEngine"/> instance.</param>
		/// <param name="errorData">The error data.</param>
		public delegate void OnSrmStartActionsFailure(IEngine engine, List<StartActionsFailureErrorData> errorData);

		/// <summary>
		/// Delegate type for App package installation.
		/// </summary>
		/// <param name="engine">The <see cref="IEngine"/> instance.</param>
		/// <param name="appInstallContext">The App install content.</param>
		public delegate void InstallAppPackage(IEngine engine, AppInstallContext appInstallContext);

		/// <summary>
		/// Delegate type for App package configuration.
		/// </summary>
		/// <param name="engine">The <see cref="IEngine"/> instance.</param>
		/// <param name="appConfigurationContext">The App configuration content.</param>
		public delegate void ConfigureApp(IEngine engine, AppConfigurationContext appConfigurationContext);

		/// <summary>
		/// Delegate type for App package uninstallation.
		/// </summary>
		/// <param name="engine">The <see cref="IEngine"/> instance.</param>
		/// <param name="appConfigurationContext">The App uninstall content.</param>
		public delegate void UninstallApp(IEngine engine, AppUninstallContext appUninstallContext);

		/// <summary>
		/// Delegate type for SRM bookings updated by reference.
		/// </summary>
		/// <param name="engine">The <see cref="IEngine"/> instance.</param>
		/// <param name="profileInstanceId">The profile instance ID.</param>
		/// <param name="impactedBookings">The impacted bookings.</param>
		public delegate void OnSrmBookingsUpdatedByReference(IEngine engine, ValueType profileInstanceId, List<Guid> impactedBookings);

		/// <summary>
		/// Delegate type for DOM instance CRUD.
		/// </summary>
		/// <param name="engine">The <see cref="IEngine"/> instance.</param>
		/// <param name="domInstanceId">The DOM instance ID.</param>
		/// <param name="crudType">the CRUD type.</param>
		public delegate void OnDomInstanceCrud(IEngine engine, ValueType domInstanceId, CrudType crudType);

		/// <summary>
		/// Ticket CRUD delegate type.
		/// </summary>
		/// <param name="engine">The <see cref="IEngine"/> instance.</param>
		/// <param name="ticketId">The ticket ID.</param>
		/// <param name="crudType">The CRUD type.</param>
		public delegate void OnTicketCrud(IEngine engine, TicketID ticketId, CrudType crudType);

		/// <summary>
		/// DOM action delegate type.
		/// </summary>
		/// <param name="engine">The <see cref="IEngine"/> instance.</param>
		/// <param name="context">The context</param>
		public delegate void OnDomAction(IEngine engine, ExecuteScriptDomActionContext context);
	}
}
