---
uid: GetActiveAlarmsForViewV2
---

# GetActiveAlarmsForViewV2

Use this method to retrieve all active alarms of a particular view along with the alarm cache status.

Available from DataMiner 10.0.7 onwards.

## Input

| Item       | Format  | Description                                          |
|------------|---------|------------------------------------------------------|
| Connection | String  | The connection ID. See [ConnectApp](xref:ConnectApp). |
| ViewID     | Integer | The view ID.                                         |

## Output

| Item | Format | Description |
|--|--|--|
| GetActiveAlarmsFor­ViewV2Result | Array of [DMAAlarm](xref:DMAAlarm) | The active alarms of the specified view, as well as the alarm cache status. |
