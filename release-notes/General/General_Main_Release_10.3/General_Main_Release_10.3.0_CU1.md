---
uid: General_Main_Release_10.3.0_CU1
---

# General Main Release 10.3.0 CU1 – Preview

> [!IMPORTANT]
> We are still working on this release. Some release notes may still be modified or moved to a later release. Check back soon for updates!

> [!TIP]
> For information on how to upgrade DataMiner, see [Upgrading a DataMiner Agent](xref:Upgrading_a_DataMiner_Agent).

### Enhancements

#### SLAnalytics: Number of 'GetParameterMessages' requests has been optimized [ID_34936]

<!-- MR 10.3.0 [CU1] - FR 10.3.1 -->

The number of *GetParameterMessages* sent by SLAnalytics in order to check whether a trended table parameter is still active has been optimized.

#### Enhanced performance when creating or editing services [ID_35366]

<!-- MR 10.2.0 [CU13]/10.3.0 [CU1] - FR 10.3.4 -->

Because of a number of enhancements made with regard to the communication between SLDataMiner and SLDMS, overall performance has increased when creating or editing services, especially in heavily loaded environments.

#### Enhanced SNMP trap distribution [ID_35480]

<!-- MR 10.2.0 [CU13]/10.3.0 [CU1] - FR 10.3.4 -->

From now on, stopped elements will no longer be taken into account when distributing SNMP traps. When a trap has to be sent to an element on another DataMiner Agent, it will no longer be sent when that element is stopped.

#### SLAnalytics - Automatic incident tracking: Focus value updates will no longer be taken into account when determining whether the maximum group event rate was exceeded [ID_35545]

<!-- MR 10.2.0 [CU13]/10.3.0 [CU1] - FR 10.3.4 -->

From now on, focus value updates will no longer be taken into account when determining whether the *Maximum group event rate* was exceeded.

### Fixes

#### Problem with SLElement when stopping an EPM element [ID_35439]

<!-- MR 10.2.0 [CU13]/10.3.0 [CU1]  - FR 10.3.3 -->

When an EPM element was stopped, in some rare cases, an error could occur in SLElement.

#### SLAnalytics - Behavioral anomaly detection: Two identical behavioral anomaly alarms would incorrectly be created [ID_35511]

<!-- MR 10.3.0 [CU1] - FR 10.3.3 -->

In some cases, two identical behavioral anomaly alarms would incorrectly be created.

#### SLAnalytics : Problem after a DVE parent element had been deleted [ID_35521]

<!-- MR 10.2.0 [CU13]/10.3.0 [CU1] - FR 10.3.3 -->

In some cases, an error could occur in the SLAnalytics process after a DVE parent element had been deleted.

#### Failover: Profile Manager would incorrectly not be initialized on the agent that was brought online [ID_35534]

<!-- MR 10.2.0 [CU13]/10.3.0 [CU1] - FR 10.3.4 -->

When a failover was triggered, in some rare cases, the Profile Manager would incorrectly not be initialized on the agent that was brought online.

In the Alarm Console, an error would appear with the following message:

```txt
Unexpected exception while triggering failover for BaseProfileManager: Skyline.DataMiner.Net.ManagerStore.CrudFailedException: Exception of type 'Skyline.DataMiner.Net.ManagerStore.CrudFailedException' was thrown.
```

#### Problem when modifying the production version of a protocol with an SNMPv3 connection [ID_35538]

<!-- MR 10.2.0 [CU13]/10.3.0 [CU1] - FR 10.3.4 -->

When you modified the production version of a protocol with multiple connections, of which one was an SNMNv3 connection, in some cases, the element could lose its SNMPv3 port settings. As a result, the SLSNMPManager process would fail to initialize the SNMPv3 communication, and the following alarm would appear in the Alarm Console:

```txt
Error parsing SNMPv3 password for port: <port number> on element: <element name>
```

Also, an error could occur in SLDataMiner when you tried to re-enter the SNMPv3 port settings.
