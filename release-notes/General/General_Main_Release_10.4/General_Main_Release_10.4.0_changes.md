---
uid: General_Main_Release_10.4.0_changes
---

# General Main Release 10.4.0 – Changes (preview)

> [!IMPORTANT]
> We are still working on this release. Some release notes may still be modified or moved to a later release. Check back soon for updates!

## Changes

### Enhancements

*No enhancements have been added yet.*

### Fixes

#### Mobile apps: Problem when trying to select an item in a drop-down box [ID_34742]

<!-- MR 10.4.0 - FR 10.2.12 [CU0] -->

In some cases, it would incorrectly not be possible to select an item in a drop-down box when the items were grouped or when their actual value was not identical to the value that was displayed.

#### GQI: Problem when retrieving DCF interfaces [ID_34820]

<!-- MR 10.4.0 - FR 10.3.1 -->

When a GQI query returned all DCF interfaces from all agents in the DataMiner System, the NATS message broker would throw a *MaxPayloadException* when *MaxPayload* exceeded the value configured in `C:\Skyline DataMiner\NATS\nats-streaming-server\nats-server.config`.

From now on, when a GQI query has to retrieve DCF interfaces, it will do so by querying one agent at a time.

#### Problem with SLElement when a trend template was being assigned [ID_34824]

<!-- MR 10.4.0 - FR 10.3.1 -->

In some cases, an error could occur in SLElement when a trend template was being assigned.

#### Problem with SLElement when a description.xml file was updated while an alarm was being unmasked [ID_34860]

<!-- MR 10.4.0 - FR 10.3.1 -->

In some cases, an error could occur in SLElement when a *description.xml* file was updated while an alarm was being unmasked.

#### Problem with SLElement when a parameter update was being processed while an element was starting up [ID_34899]

<!-- MR 10.4.0 - FR 10.3.1 -->

In some cases, an error could occur in SLElement when a parameter update was being processed while an element was starting up.
