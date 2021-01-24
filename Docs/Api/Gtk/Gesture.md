# Gesture class

```csharp
public class Gesture : EventController
```

## Public Members

| name | description |
| --- | --- |
| [Item](Gesture/Item.md) { set; } | Indexer to connect BeginSignal with a SignalHandler&lt;Gesture, BeginSignalArgs&gt; (5 indexers) |
| event [OnBegin](Gesture/OnBegin.md) |  |
| event [OnCancel](Gesture/OnCancel.md) |  |
| event [OnEnd](Gesture/OnEnd.md) |  |
| event [OnSequenceStateChanged](Gesture/OnSequenceStateChanged.md) |  |
| event [OnUpdate](Gesture/OnUpdate.md) |  |
| static readonly [BeginSignal](Gesture/BeginSignal.md) | Signal Descriptor for OnBegin. |
| static readonly [CancelSignal](Gesture/CancelSignal.md) | Signal Descriptor for OnCancel. |
| static readonly [EndSignal](Gesture/EndSignal.md) | Signal Descriptor for OnEnd. |
| static readonly [SequenceStateChangedSignal](Gesture/SequenceStateChangedSignal.md) | Signal Descriptor for OnSequenceStateChanged. |
| static readonly [UpdateSignal](Gesture/UpdateSignal.md) | Signal Descriptor for OnUpdate. |
| class [BeginSignalArgs](Gesture.BeginSignalArgs.md) | Signal (Event) Arguments for OnBegin |
| class [CancelSignalArgs](Gesture.CancelSignalArgs.md) | Signal (Event) Arguments for OnCancel |
| class [EndSignalArgs](Gesture.EndSignalArgs.md) | Signal (Event) Arguments for OnEnd |
| class [SequenceStateChangedSignalArgs](Gesture.SequenceStateChangedSignalArgs.md) | Signal (Event) Arguments for OnSequenceStateChanged |
| class [UpdateSignalArgs](Gesture.UpdateSignalArgs.md) | Signal (Event) Arguments for OnUpdate |

## See Also

* class [EventController](EventController.md)
* namespace [Gtk](../Gtk3.md)

<!-- DO NOT EDIT: generated by xmldocmd for Gtk3.dll -->