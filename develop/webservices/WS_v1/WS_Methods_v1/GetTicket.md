---
uid: GetTicket
---

# GetTicket

Use this method to retrieve a particular ticket.

> [!NOTE]
> -  From DataMiner 10.0.13 onwards, use the *GetTicketV2* method instead. See [GetTicketV2](xref:GetTicketV2).
> -  DataMiner Ticketing requires a Cassandra database as well as a specific license. From DataMiner 10.0.13 onwards, it also requires an Elasticsearch database. For more information on acquiring a Ticketing license, contact the Skyline Sales department.

## Input

| Item           | Format  | Description                                                                      |
|----------------|---------|----------------------------------------------------------------------------------|
| connection     | String  | The connection ID. See [ConnectApp](xref:ConnectApp). |
| dmaID          | Integer | The ID of the DMA.                                                               |
| ticketID       | Integer | The ID of the ticket.                                                            |
| includeHistory | Boolean | Determines whether the revision history of the ticket is included.               |

## Output

| Item            | Format    | Description                                             |
|-----------------|-----------|---------------------------------------------------------|
| GetTicketResult | [DMATicket](xref:DMATicket) | The requested ticket. |
