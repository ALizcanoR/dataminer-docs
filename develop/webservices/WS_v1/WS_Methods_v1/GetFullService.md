---
uid: GetFullService
---

# GetFullService

Use this method to retrieve all data of a particular service, including a list of its parameters and its properties. This method effectively combines the GetService, GetServiceParameters and GetPropertiesForService methods. (Available from DataMiner 9.5.8 onwards.)

> [!TIP]
> See also:
> -  [GetPropertiesForService](xref:GetPropertiesForService)
> -  [GetService](xref:GetService)
> -  [GetServiceParameters](xref:GetServiceParameters)

## Input

| Item       | Format  | Description                                          |
|------------|---------|------------------------------------------------------|
| connection | String  | The connection ID. See [ConnectApp](xref:ConnectApp). |
| dmaID      | Integer | The DataMiner Agent ID.                              |
| serviceID  | Integer | The service ID.                                      |

## Output

| Item | Format | Description |
|--|--|--|
| GetFullServiceResult | Array of:<br> -  [DMAElement](xref:DMAElement)<br> -  [DMAServiceParametersElement](xref:DMAServiceParametersElement) objects<br> -  [DMAProperty](xref:DMAProperty) objects | The complete data of the specified service. |
