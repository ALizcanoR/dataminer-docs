---
uid: Web_apps_Feature_Release_10.3.6
---

# DataMiner web apps Feature Release 10.3.6 – Preview

> [!IMPORTANT]
> We are still working on this release. Some release notes may still be modified or moved to a later release. Check back soon for updates!

> [!TIP]
> For release notes for this release that are not related to the web applications, see [General Feature Release 10.3.6](xref:General_Feature_Release_10.3.6).

## Highlights

*No highlights have been selected for this release yet*

## Other features

*No other features have been added to this release yet.*

## Changes

### Enhancements

*No enhancements have been added to this release yet.*

### Fixes

#### Interactive Automation scripts: Problems with datetime component [ID_35682]

<!-- MR 10.3.0 [CU3] - FR 10.3.6 -->

When an interactive Automation script was launched from a web app, the following issues could occur. These were all related to the datetime web component (*UIBlockType.Time*):

- When you clicked a date in the datetime picker, a changed value would already be returned to the script. From now on, the selected datetime value will not be returned to the script until you close the picker (either by double-clicking or by clicking *Done*).

- The datetime value that was returned to the script when the component lost focus could be incorrect.

- The focus loss detection would not always be accurate.

#### Dashboards app & Low-code apps - Table component: Minimum pagesize would be used when exporting to a CSV file [ID_36012]

<!-- MR 10.3.0 [CU3] - FR 10.3.6 -->

When exporting data from a table component to a CSV file, the minimum pagesize would be used. From now, the largest possible pagesize is used when exporting data from a table component to a CSV file.

#### Dashboards app & Low-code apps: Component title could be made too large [ID_36021]

<!-- MR 10.2.0 [CU15]/10.3.0 [CU3] - FR 10.3.6 -->

In a custom component theme, for some fonts, the font size of the title could be set to a value higher than 36px, causing the component title to be larger than its container. Also, in some cases, the font size could incorrectly be set to 0px.

From now on, font sizes will have to be set to a value between 1px and 36px.

#### Dashboards app: Error when opening a shared dashboard containing a 'Line & area chart' component, a 'State' component, a 'Gauge' component or a 'Ring' component [ID_36022]

<!-- MR 10.3.0 [CU3] - FR 10.3.6 -->

An error could occur when you opened a shared dashboard that contained a *Line & area chart* component, a *State* component, a *Gauge* component or a *Ring* component.

#### Dashboards app: Retry button of table component would incorrectly be displayed in PDF file [ID_36026]

<!-- MR 10.3.0 [CU3] - FR 10.3.6 -->

When you generated a PDF of a dashboard that contained a table component showing a *Retry* button (because of an error in the table), then that *Retry* button would incorrectly also be displayed in the PDF file.

#### Dashboards app: Problem when a 'State' component was fed a parameter value by a drop-down component in a shared dashboard [ID_36075]

<!-- MR 10.3.0 [CU3] - FR 10.3.6 -->

In a shared dashboard, an error could occur when a *State* component was fed a parameter value by a drop-down component.

#### Dashboards app & Low-code apps: GQI table component could throw 'Paged table session not found' error [ID_36101]

<!-- MR 10.3.0 [CU3] - FR 10.3.6 -->

In some cases, a GQI table component could thrown the following error:

```txt
Error trapped: Paged table session not found
```

From now on, a table session will immediately be closed after the last page has been fetched. This will prevent the above-mentioned error from being thrown.

#### Dashboards app: Error when opening a shared dashboard containing a 'Parameter Page' component [ID_36103]

<!-- MR 10.3.0 [CU3] - FR 10.3.6 -->

An error could occur when you opened a shared dashboard that contained a *Parameter Page* component.
