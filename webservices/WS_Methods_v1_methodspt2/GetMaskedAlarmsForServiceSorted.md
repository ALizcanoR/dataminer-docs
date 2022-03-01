---
uid: GetMaskedAlarmsForServiceSorted
---

# GetMaskedAlarmsForServiceSorted

Use this method to retrieve a specific number of masked service alarms.

> [!NOTE]
> Using this method, you can e.g. request alarms in batches in order to minimize loading time.

## Input

| Item       | Format  | Description                                                                         |
|------------|---------|-------------------------------------------------------------------------------------|
| Connection | String  | The connection ID. See [ConnectApp](xref:ConnectApp) .    |
| DmaID      | Integer | The DMA ID.                                                                         |
| ServiceID  | Integer | The service ID.                                                                     |
| Index      | Integer | The point from which to start returning alarms.                                     |
| Count      | Integer | The number of alarms to be returned.                                                |
| OrderBy    | String  | The Alarm Console column(s) by which to order the alarms (separated by semicolons). |

## Output

| Item                                   | Format                                                                   | Description                                                         |
|----------------------------------------|--------------------------------------------------------------------------|---------------------------------------------------------------------|
| GetMaskedAlarmsFor­ServiceSortedResult | Array of DMAAlarm (see [DMAAlarm](xref:DMAAlarm)) | The requested number of masked service alarms, sorted as specified. |

