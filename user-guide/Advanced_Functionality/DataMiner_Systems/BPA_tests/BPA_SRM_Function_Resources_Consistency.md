---
uid: BPA_SRM_Function_Resources_Consistency
---

# SRM Function Resources Consistency

This BPA test checks for any inconsistencies between the resource objects and the [Generic DVE table] entries on the main element as well as duplicate names:

- It checks for any inconsistencies in the DVE tables: states, names, linked resources & elements.
- It checks for duplicate names or other name configurations that could cause problems.

<!-- This BPA test is available on demand. You can [run it in System Center](xref:Running_BPA_tests) (on the *Agents > BPA* tab, available from DataMiner 9.6.0 CU23, 10.0.0 CU13, 10.1.0 CU2 and 10.1.4 onwards). From DataMiner 10.1.7, 10.1.0 CU4, 10.0.0 CU15 and 9.6.0 CU24 onwards, this BPA test is available by default. -->

## Metadata

- Name: SRM Function Resources Consistency
- Description: Detects any inconsistencies between the resource objects and the [Generic DVE table] entries on the main element as well as duplicate names.
- Author: Skyline Communications
- Default schedule: Daily

## Results

### Success

`Test succeeded: No inconsistent function resource configurations detected in the system.`

There are no inconsistencies detected in the system.

### Error

- `[Generic DVE Table] entry {...} - [DVE Name] has value '{..}', which is different from the linked resource function name '{...}'.`
- `[Generic DVE Table] entry {...} - [DVE Element] has the value '{...}', which is different from the linked resource DVE Element '{...}'.`
- `[Generic DVE Table] entry {...} - [DVE State] has the value 'Enabled', but [DVE Element] '{...}' was not found in the DataMiner System even though it should be.`
- `[Generic DVE Table] entry {...} - [DVE State] has the value 'Disabled', but [DVE Element] '{...}' is present in the DataMiner System even though it shouldn't be.`
- `[Generic DVE Table] entry {...} - [DVE function GUID] has the value '{...}', which is different from the linked resource function GUID '{...}'.`
- `[Generic DVE Table] entry {...} - [DVE Link to Resource Manager] has the value '{...}', which is different from the linked resource ID '{...}'.`
- `[Generic DVE Table] entry {...} - The active function files for the protocol were switched, but [DVE function GUID] still matches the GUID of the function in a previous active function file('{...}') instead of the current active function file.`
- `Could not find main element referenced by the following resources: {...}. `
- `[Generic DVE Table] entry {...} is configured with resource ID {...} /a blank resource ID, so no matching resource could be found in the Resource Manager.`
- `[Generic DVE Table] entry {...} is configured with the element name - function name combination '{...}.{...}', which is already used as the element name of element '{...}/{...}'.`
- `[Generic DVE Table] entries [{...}] are configured with a duplicate DVE Name '{...}'.`
- `The function name '{...}' of resource '{...}' ({...}) with [Generic DVE Table] primary key [{...}] is already used by one or more other function resources on the same parent element, with [Generic DVE Table] primary key(s) [...].`
- `Resource '{...}' ({...}) has no primary key while it should have one.`
- `Resource '{...}' ({...}) with [Generic DVE Table] primary key '{...}' could not be found in the [Generic DVE table].`
- `The [Generic DVE Table] was empty, but the following resources refer to this element: Resource '{...}' ({...}).`

### Warning

- `Could not retrieve all elements.` (Something went wrong when trying to retrieve all elements.)
- `Could not check resources of this element because the state is set to stopped.` (The element is set to stopped, so it could not do the checks.)
- `No Linker table entry found for resource(s): {...} .` (The linked function has entry points but the function resources that have no linker table entry.)


### Not Executed

These are the messages that can appear when the test fails to execute for unexpected reasons, and cannot provide a conclusive report because of this:

`Could not execute test ([message])` (on unexpected exceptions).

In the message above, the exception message is included (e.g. "Access Denied"). The test result details contain the full exception text, if available.

## Limitations


