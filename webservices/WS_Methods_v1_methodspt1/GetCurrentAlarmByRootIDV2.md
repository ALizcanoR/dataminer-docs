---
uid: GetCurrentAlarmByRootIDV2
---

# GetCurrentAlarmByRootIDV2

Use this method to retrieve the current alarm associated with a particular root alarm ID, as well as the alarm cache status.

Available from DataMiner 10.0.7 onwards.

## Input

| Item        | Format  | Description                                          |
|-------------|---------|------------------------------------------------------|
| Connection  | String  | The connection ID. See [ConnectApp](xref:ConnectApp) . |
| DmaID       | Integer | The DataMiner Agent ID.                              |
| RootAlarmID | Integer | The root alarm ID.                                   |

## Output

| Item                             | Format                                           | Description                                                                                       |
|----------------------------------|--------------------------------------------------|---------------------------------------------------------------------------------------------------|
| GetCurrentAlarmBy­RootIDV2Result | [DMAAlarm](xref:DMAAlarm) | The current alarm associated with the specified root alarm ID, as well as the alarm cache status. |

