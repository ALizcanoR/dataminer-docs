---
uid: Alarm_hysteresis
---

## Alarm hysteresis

Thanks to alarm threshold hysteresis, you can fine-tune the sensitivity of your alarm thresholds by defining how long a parameter has to be below or above a certain threshold before the DataMiner System is allowed to consider it as being below or above that threshold.

> [!TIP]
> See also:
> - [Configuring alarm hysteresis in an alarm template](xref:Configuring_alarm_templates#configuring-alarm-hysteresis-in-an-alarm-template)
> - [Polling.xml](xref:Polling_xml#pollingxml)

#### Graphical representation

![](~/user-guide/images/hysteresis.jpg)



#### Methods

DataMiner supports two methods of hysteresis:

- **Clear hysteresis**: Delaying the moment when an alarm is cleared, i.e. the moment when the severity of an alarm decreases.

- **Alarm hysteresis**: Delaying the moment when the severity of an alarm increases.
