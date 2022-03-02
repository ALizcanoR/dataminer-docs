---
uid: GetMaskedAlarmsForElementSorted
---

# GetMaskedAlarmsForElementSorted

Use this method to retrieve a specific number of masked element alarms.

> [!NOTE]
> Using this method, you can e.g. request alarms in batches in order to minimize loading time.

## Input

| Item       | Format  | Description                                                                         |
|------------|---------|-------------------------------------------------------------------------------------|
| Connection | String  | The connection ID. See [ConnectApp](xref:ConnectApp) .    |
| DmaID      | Integer | The DMA ID.                                                                         |
| ElementID  | Integer | The element ID.                                                                     |
| Index      | Integer | The point from which to start returning alarms.                                     |
| Count      | Integer | The number of alarms to be returned.                                                |
| OrderBy    | String  | The Alarm Console column(s) by which to order the alarms (separated by semicolons). |

## Output

| Item                                   | Format                                                                   | Description                                                         |
|----------------------------------------|--------------------------------------------------------------------------|---------------------------------------------------------------------|
| GetMaskedAlarmsFor­ElementSortedResult | Array of DMAAlarm (see [DMAAlarm](xref:DMAAlarm)) | The requested number of masked element alarms, sorted as specified. |

