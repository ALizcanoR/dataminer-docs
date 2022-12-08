---
uid: Finding_a_Root_Cause
---

# Finding a root cause

```mermaid
flowchart TD
    %% Define styles %%
    classDef classTerminal fill:#1e5179,stroke:#1e5179,color:#ffffff,stroke-width:0px;
    classDef classDecision fill:#4baeea,stroke:#4baeea,color:#ffffff,stroke-width:0px;
    classDef classExternalRef fill:#9ddaf5,stroke:#9ddaf5,color:#1E5179,stroke-width:0px;
    classDef classActionClickable fill:#999999,stroke:#999999,color:#ffffff,stroke-width:0px;
    classDef classAction fill:#dddddd,stroke:#dddddd,color:#1E5179,stroke-width:0px;
    classDef classSolution fill:#58595b,stroke:#58595b,color:#ffffff,stroke-width:0px;
    %% Define blocks %%
    START([Find the root cause])
    Investigate([Where to start?])
    CheckStartup{{Does the DMA start up?}}
    CHECK1{{Any critical issues? }}
    identify{{Identify issue per... }}
    DatabaseFlowcharts{{Is it a database problem?}}
    WhichDb{{Which database?}}
    DMAStartupIssues([To DMA Startup Issues<br>flowchart])
    critical([To Critical Issues<br>flowchart])
    ProcessFlowcharts([Process])
    Cassandra([Cassandra])
    %% Connect blocks %%
    START --> CheckStartup
    CheckStartup -->|Yes| CHECK1
    CheckStartup --> |No| DMAStartupIssues
    CHECK1 --> |Yes| critical
    CHECK1 ---> |No| DatabaseFlowcharts
    DatabaseFlowcharts -->|Yes|WhichDb
    DatabaseFlowcharts --->|No|identify
    identify --> ProcessFlowcharts
    WhichDb --> Cassandra
    %% Define hyperlinks %%
    click CHECK1 "#examples-of-critical-issues" "examples of critical issues"
    click critical "https://docs.dataminer.services/user-guide/Troubleshooting/Troubleshooting_Flowcharts/Troubleshooting_Critical_Issues/Troubleshooting_Critical_Issues_Overview.html" "To critical issues flowchart"
    click DMAStartupIssues "https://docs.dataminer.services/user-guide/Troubleshooting/Troubleshooting_Flowcharts/Troubleshooting_Startup_Issues.html" "DMA Startup Issues"
    click ProcessFlowcharts "https://docs.dataminer.services/user-guide/Troubleshooting/Troubleshooting_Flowcharts/Troubleshooting_Process_Identification/Troubleshooting_Process_Identification.html" "Process identification"
    click WhichDb "https://docs.dataminer.services/user-guide/Troubleshooting/Troubleshooting_Flowcharts/Finding_a_Root_Cause.html#identifying-the-general-database" "Identify the Database"
    click Cassandra "https://docs.dataminer.services/user-guide/Troubleshooting/Troubleshooting_Flowcharts/Troubleshooting_Cassandra/Troubleshooting_Cassandra.html" "Troubleshooting Cassandra"
    click Investigate "https://docs.dataminer.services/user-guide/Troubleshooting/Troubleshooting_Flowcharts/Troubleshooting_Where_to_Start.html"
    %% Apply styles to blocks %%
    class START classTerminal;
    class WhichDb,DatabaseFlowcharts,CheckStartup,CHECK1,identify classDecision;
    class Investigate,Cassandra,DMAStartupIssues,critical,ProcessFlowcharts classExternalRef;
```

## Examples of critical issues

| Critical issues | Why are these critical? |
|--|--|
| RTEs/Runtime Errors | RTEs may inhibit the flow of information in your DMS. |
| Process crashes | Process crashes may cause interaction of DataMiner internal processes to fail and cause a DataMiner restart. |
| Process disappearances | Process disappearances may cause interaction of DataMiner internal processes to fail and cause a DataMiner restart. |

## Identifying the general database

| DMA state | How to identify the database |
|--|--|
| DMA stopped/offline or stuck | **Method A**: Check *C:\Skyline DataMiner\DB.xml*. Check the contents of the "type" tag. If it is empty or if the tag does not exist, it is a MySQL database. <br> **Method B**: Check the name of the database process on the database server or DataMiner server: <br> - prunsrv = Cassandra <br> - ElasticSearch = Elasticsearch <br> - MySQL = MySQL |
| DMA online | Go to *System Center > Database > General*.|
