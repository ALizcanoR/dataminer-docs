# Release 2.29

## New features

### IDE

#### XML editor: Contents of \<VersionHistory> element copied into the comment section at the top of the file when compiling a protocol XML file \[ID_26541\]

From now on, when you compile a protocol XML file, the entire contents of the \<VersionHistory> element will be copied into the comment section at the top of the file.

#### An information banner can now appear at the top of an editor window \[ID_26691\]

A yellow banner can now appear at the top of an editor window to convey important information to the user.

Currently, a banner will appear to inform users that a new DIS version is available, that the protocol XML file being edited does not contain the UTF-8 header bytes or that it is advisable to update all C# projects to Microsoft .NET Framework 4.6.2.

#### XML editor: Generating parameters based on data in an Ember+ file \[ID_27064\]

From now on, it is also possible to automatically generate \<Param> tags based on parameter data in an Ember+ file.

### Validator

#### New checks and error messages \[ID_26471\]\[ID_26845\]\[ID_26846\]\[ID_26847\]\[ID_26848\]\[ID_26849\]

The following checks and error messages have been added.

| Check ID | Error message name                                  | Error message                                                                                                                           |
|----------|-----------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------|
| 2.46.7   | InvalidColumnType                                   | Invalid primary key column Interprete/Type '{columnIntrepeteType}'. Possible values 'string'. Table ID '{tablePid}'.                    |
| 3.5.1    | NonExistingActionId                                 | Method 'NotifyProtocol(221/\*NT_RUN_ACTION\*/, ...)' references a non-existing 'Action' with ID '{actionId}'. QAction ID '{qactionId}'. |
| 3.12.1   | MissingEntryPoint                                   | Entry point '{entryPointClass}.{entryPointMethod}' not found in QAction. QAction ID {qactionId}.                                        |
| 3.13.1   | ObsoleteDcfV1                                       | Obsolete preprocessor directive 'DCFv1' used in QAction. QAction ID '{qactionId}'.                                                      |
| 3.14.1   | UnsupportedIDisposable                              | Entry point class {entryPointClass} implements unsupported interface IDisposable. QAction ID '{qactionId}'.                             |
| 3.15.1   | UnrecommendedThreadAbort                            | Method 'System.Threading.Thread.Abort' is unrecommended. QAction ID {qactionId}.                                                        |
| 3.15.2   | UnrecommendedSlProtocol<br>GetParameterIndex        | Method 'SLProtocol.GetParameterIndex' is unrecommended. QAction ID {qactionId}.                                                         |
| 3.15.3   | UnrecommendedSlProtocol<br>SetParameterIndex        | Method 'SLProtocol.SetParameterIndex' is unrecommended. QAction ID {qactionId}.                                                         |
| 3.15.4   | UnrecommendedSlProtocol<br>SetParametersIndex       | Method 'SLProtocol.SetParametersIndex' is unrecommended. QAction ID {qactionId}.                                                        |
| 3.15.5   | UnrecommendedNotifyDataMiner<br>NTGetRemoteTrend    | Method 'SLProtocol.NotifyDataMiner(216/\*NT_GET_REMOTE_TREND\*/, ...)' is unrecommended. QAction ID {qactionId}.                        |
| 3.15.6   | UnrecommendedNotifyDataMiner<br>NTGetRemoteTrendAvg | Method 'SLProtocol.NotifyDataMiner(260/\*NT_GET_REMOTE_TREND_AVG\*/, ...)' is unrecommended. QAction ID {qactionId}.                    |

### XML Schema

#### Protocol Schema: New elements and element attributes \[ID_26549\]\[ID_26758\]\[ID_26763\]

The following elements and element attributes have been added to the Protocol XML Schema:

- Protocol.Params.Param.Display.DynamicUnits

- Protocol.Params.Param.Display.DynamicUnits.Unit

- Protocol.Params.Param.Display.DynamicUnits.Unit@decimals

- Protocol.VersionHistory.Branches.Branch.SystemVersions.SystemVersion.MajorVersions.<br>MajorVersion.Changes.Change@coversMajorChanges

- Protocol.VersionHistory.Branches.Branch.SystemVersions.SystemVersion.MajorVersions.<br>MajorVersion.MinorVersions.MinorVersion.Change@suppressMajorChanges

- Protocol.VersionHistory.Branches.Branch.SystemVersions.SystemVersion.MajorVersions.<br>MajorVersion.MinorVersions.MinorVersion.Fix@suppressMajorChanges

- Protocol.VersionHistory.Branches.Branch.SystemVersions.SystemVersion.MajorVersions.<br>MajorVersion.MinorVersions.MinorVersion.NewFeature@suppressMajorChanges

- Protocol.VersionHistory.Branches.Branch.SystemVersions.SystemVersion.MajorVersions.<br>MajorVersion.MinorVersions.MinorVersion.References

- Protocol.VersionHistory.Branches.Branch.SystemVersions.SystemVersion.MajorVersions.<br>MajorVersion.MinorVersions.MinorVersion.References.TaskId

- Protocol.VersionHistory.Branches.Branch.SystemVersions.SystemVersion.MajorVersions.<br>MajorVersion.MinorVersions.MinorVersion.References.Reference

- Protocol.VersionHistory.Branches.Branch.SystemVersions.SystemVersion.MajorVersions.<br>MajorVersion.MinorVersions.MinorVersion.References.Reference@type

## Changes

### Enhancements

#### Display editor & Table editor: Miscellaneous enhancements \[ID_24677\]

A number of enhancements have been made to the Display editor and the Table editor.

**Display editor**

- The height of the parameters on the Display editor pages will now better reflects the height of those parameters in DataMiner Cube. See below for a number of examples.

    | Type of parameter   | Height                         |
    |-----------------------|--------------------------------|
    | Read                  | 1 unit                         |
    | Write                 | 1 unit                         |
    | Read + Write          | 2 units                        |
    | Analog Read           | 2 units                        |
    | Group box             | 1 unit                         |
    | Spacer (white space)  | 1 unit                         |
    | Multi-line parameters | depends on the number of lines |

- Although, in DataMiner Cube, the height of a table is automatically adapted, tables in Display editor will have a fixed height of 2 units.

**Table editor**

- When calculating a column width, the Table editor will now also take into account the width of the expected values (depending on the measurement type of the parameters). See below.

    | Measurement type               | Behavior                                                                                                                        |
    |----------------------------------|---------------------------------------------------------------------------------------------------------------------------------|
    | Discreet                         | The width of the column will depend on the largest width found among the discreet values.                                       |
    | Button                           | The widths of all displayed values will be combined and a margin will be added to make sure all buttons are properly displayed. |
    | Number<br> (Datetime, Date/Time) | A datetime column will always adapt its width to accommodate values displayed in “YYYY-MM-DD hh:mm:ss tt” format.               |

- When calculating a column width, the Table editor will now also take into account the width of the exception values (if such values are defined).

- When calculating a column width, the Table editor will now also take into account the spaces DataMiner Cube inserts into large numbers to make them more readable.

- When a numeric parameter has ranges defined, the Table editor will now take into account the longest value (along with any decimals or unit) when calculating a column width.

- With regard to column titles, the following enhancements have been made:

    - DataMiner Cube will now truncate the column descriptions if all columns have the same suffix or if a column has the table description as suffix.

    - Room for key icons (primary keys, display keys or foreign keys) will now only be reserved when neither of the columns has any header option defined (if header options are defined, the key icon will be displayed on another line).

    - In case of columns of type “displaykey”, room for key icons will be reserved when needed.

    - Room will now also be reserved for sorting icons.

#### IDE - XML editor: Restructuring of the “DIS \> Protocol \> Param” snippets \[ID_26706\]

The extensive list of snippets in the *DIS \> Protocol \> Param* folder have now been restructured into the following subfolders:

| Folder               | Contents                                                                                          |
|----------------------|---------------------------------------------------------------------------------------------------|
| Displayed            | Code to add parameters to be displayed in the UI.                                                 |
| Internal logic       | Code to add parameters used for internal logic (e.g. dummy parameters, fixed parameters, etc.)    |
| Param options        | Code to add options to existing parameters (e.g. Alarm tags, Subtext tags, Exceptions tags, etc.) |
| Serial communication | Code to add serial communication parameters (e.g. headers, trailers, etc.)                        |
| SNMP communication   | Code to add SNMP communication parameters (e.g. trap receivers, SNMP tables, etc.)                |

#### Protocol Schema: Slowpoll settings now only configurable for main port \[ID_26790\]

From now on, it will only be possible to add SlowPoll and SlowPollBase elements to the Protocol.PortSettings element (i.e. the configuration of the main connection). It will no longer be possible to add these elements to the Protocol.Ports.PortSettings element (i.e. the configuration of the additional connections).

### Fixes

#### IDE: Index parameter would not be generated when the table index defined in the MIB file was not within the table OID range \[ID_27022\]

When DIS generated parameter data based on information stored in a MIB file, up to now, an additional index parameter would only be generated when the MIB file defined multiple indexes on a table. From now on, an additional index parameter will also be generated when the table index defined in the MIB file is not part of the table itself.
