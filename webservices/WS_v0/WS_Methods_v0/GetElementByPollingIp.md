---
uid: GetElementByPollingIp
---

# GetElementByPollingIp

Use this method to request a list of all the elements that poll a specific IP address.

## Input

| Item       | Format | Description                                   |
|------------|--------|-----------------------------------------------|
| Connection | String | The connection ID. See [Connect](xref:Connect). |
| IP         | String | The IP address                                |

## Output

| Item | Format | Description |
|--|--|--|
| GetElementByPolling­IpResult | Array of [DMAElement](xref:DMAElement1) | The list of elements that poll the specified IP address. |
