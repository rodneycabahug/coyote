---
layout: reference
section: learn
title: OnMonitorExecuteAction
permalink: /learn/ref/Microsoft.Coyote.Runtime.Logging/ActorRuntimeLogTextFormatter/OnMonitorExecuteAction
---
# ActorRuntimeLogTextFormatter.OnMonitorExecuteAction method

Invoked when the specified monitor executes an action.

```csharp
public virtual void OnMonitorExecuteAction(string monitorTypeName, ActorId id, string stateName, 
    string actionName)
```

| parameter | description |
| --- | --- |
| monitorTypeName | Name of type of the monitor that is executing the action. |
| id | The id of the monitor that is executing the action |
| stateName | The name of the state in which the action is being executed. |
| actionName | The name of the action being executed. |

## See Also

* class [ActorId](../../Microsoft.Coyote.Actors/ActorIdType)
* class [ActorRuntimeLogTextFormatter](../ActorRuntimeLogTextFormatterType)
* namespace [Microsoft.Coyote.Runtime.Logging](../ActorRuntimeLogTextFormatterType)
* assembly [Microsoft.Coyote](../../MicrosoftCoyoteAssembly)

<!-- DO NOT EDIT: generated by xmldocmd for Microsoft.Coyote.dll -->