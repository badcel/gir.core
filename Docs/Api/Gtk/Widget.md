# Widget class

```csharp
public class Widget : InitiallyUnowned, Buildable
```

## Public Members

| name | description |
| --- | --- |
| [HAlign](Widget/HAlign.md) { get; set; } |  |
| [HeightRequest](Widget/HeightRequest.md) { get; set; } |  |
| [HExpand](Widget/HExpand.md) { get; set; } |  |
| [Item](Widget/Item.md) { set; } | Indexer to connect with a SignalHandler&lt;Widget&gt; (58 indexers) |
| [VAlign](Widget/VAlign.md) { get; set; } |  |
| [VExpand](Widget/VExpand.md) { get; set; } |  |
| [WidthRequest](Widget/WidthRequest.md) { get; set; } |  |
| event [OnAccelClosuresChanged](Widget/OnAccelClosuresChanged.md) |  |
| event [OnButtonPressEvent](Widget/OnButtonPressEvent.md) |  |
| event [OnButtonReleaseEvent](Widget/OnButtonReleaseEvent.md) |  |
| event [OnCanActivateAccel](Widget/OnCanActivateAccel.md) |  |
| event [OnChildNotify](Widget/OnChildNotify.md) |  |
| event [OnConfigureEvent](Widget/OnConfigureEvent.md) |  |
| event [OnDamageEvent](Widget/OnDamageEvent.md) |  |
| event [OnDeleteEvent](Widget/OnDeleteEvent.md) |  |
| event [OnDestroy](Widget/OnDestroy.md) |  |
| event [OnDestroyEvent](Widget/OnDestroyEvent.md) |  |
| event [OnDirectionChanged](Widget/OnDirectionChanged.md) |  |
| event [OnDragBegin](Widget/OnDragBegin.md) |  |
| event [OnDragDataDelete](Widget/OnDragDataDelete.md) |  |
| event [OnDragDataGet](Widget/OnDragDataGet.md) |  |
| event [OnDragDataReceived](Widget/OnDragDataReceived.md) |  |
| event [OnDragDrop](Widget/OnDragDrop.md) |  |
| event [OnDragEnd](Widget/OnDragEnd.md) |  |
| event [OnDragFailed](Widget/OnDragFailed.md) |  |
| event [OnDragLeave](Widget/OnDragLeave.md) |  |
| event [OnDragMotion](Widget/OnDragMotion.md) |  |
| event [OnDraw](Widget/OnDraw.md) |  |
| event [OnEnterNotifyEvent](Widget/OnEnterNotifyEvent.md) |  |
| event [OnEvent](Widget/OnEvent.md) |  |
| event [OnEventAfter](Widget/OnEventAfter.md) |  |
| event [OnFocus](Widget/OnFocus.md) |  |
| event [OnFocusInEvent](Widget/OnFocusInEvent.md) |  |
| event [OnFocusOutEvent](Widget/OnFocusOutEvent.md) |  |
| event [OnGrabBrokenEvent](Widget/OnGrabBrokenEvent.md) |  |
| event [OnGrabFocus](Widget/OnGrabFocus.md) |  |
| event [OnGrabNotify](Widget/OnGrabNotify.md) |  |
| event [OnHide](Widget/OnHide.md) |  |
| event [OnHierarchyChanged](Widget/OnHierarchyChanged.md) |  |
| event [OnKeynavFailed](Widget/OnKeynavFailed.md) |  |
| event [OnKeyPressEvent](Widget/OnKeyPressEvent.md) |  |
| event [OnKeyReleaseEvent](Widget/OnKeyReleaseEvent.md) |  |
| event [OnLeaveNotifyEvent](Widget/OnLeaveNotifyEvent.md) |  |
| event [OnMap](Widget/OnMap.md) |  |
| event [OnMapEvent](Widget/OnMapEvent.md) |  |
| event [OnMnemonicActivate](Widget/OnMnemonicActivate.md) |  |
| event [OnMotionNotifyEvent](Widget/OnMotionNotifyEvent.md) |  |
| event [OnMoveFocus](Widget/OnMoveFocus.md) |  |
| event [OnParentSet](Widget/OnParentSet.md) |  |
| event [OnPopupMenu](Widget/OnPopupMenu.md) |  |
| event [OnPropertyNotifyEvent](Widget/OnPropertyNotifyEvent.md) |  |
| event [OnProximityInEvent](Widget/OnProximityInEvent.md) |  |
| event [OnProximityOutEvent](Widget/OnProximityOutEvent.md) |  |
| event [OnQueryTooltip](Widget/OnQueryTooltip.md) |  |
| event [OnRealize](Widget/OnRealize.md) |  |
| event [OnScreenChanged](Widget/OnScreenChanged.md) |  |
| event [OnScrollEvent](Widget/OnScrollEvent.md) |  |
| event [OnSelectionClearEvent](Widget/OnSelectionClearEvent.md) |  |
| event [OnSelectionGet](Widget/OnSelectionGet.md) |  |
| event [OnSelectionNotifyEvent](Widget/OnSelectionNotifyEvent.md) |  |
| event [OnSelectionReceived](Widget/OnSelectionReceived.md) |  |
| event [OnSelectionRequestEvent](Widget/OnSelectionRequestEvent.md) |  |
| event [OnShow](Widget/OnShow.md) |  |
| event [OnShowHelp](Widget/OnShowHelp.md) |  |
| event [OnSizeAllocate](Widget/OnSizeAllocate.md) |  |
| event [OnStateFlagsChanged](Widget/OnStateFlagsChanged.md) |  |
| event [OnStyleUpdated](Widget/OnStyleUpdated.md) |  |
| event [OnTouchEvent](Widget/OnTouchEvent.md) |  |
| event [OnUnmap](Widget/OnUnmap.md) |  |
| event [OnUnmapEvent](Widget/OnUnmapEvent.md) |  |
| event [OnUnrealize](Widget/OnUnrealize.md) |  |
| event [OnWindowStateEvent](Widget/OnWindowStateEvent.md) |  |
| [GetScreen](Widget/GetScreen.md)() |  |
| [GetStyleContext](Widget/GetStyleContext.md)() |  |
| [Show](Widget/Show.md)() |  |
| [ShowAll](Widget/ShowAll.md)() |  |
| static readonly [AccelClosuresChangedSignal](Widget/AccelClosuresChangedSignal.md) | Signal Descriptor for OnAccelClosuresChanged. |
| static readonly [ButtonPressEventSignal](Widget/ButtonPressEventSignal.md) | Signal Descriptor for OnButtonPressEvent. |
| static readonly [ButtonReleaseEventSignal](Widget/ButtonReleaseEventSignal.md) | Signal Descriptor for OnButtonReleaseEvent. |
| static readonly [CanActivateAccelSignal](Widget/CanActivateAccelSignal.md) | Signal Descriptor for OnCanActivateAccel. |
| static readonly [ChildNotifySignal](Widget/ChildNotifySignal.md) | Signal Descriptor for OnChildNotify. |
| static readonly [ConfigureEventSignal](Widget/ConfigureEventSignal.md) | Signal Descriptor for OnConfigureEvent. |
| static readonly [DamageEventSignal](Widget/DamageEventSignal.md) | Signal Descriptor for OnDamageEvent. |
| static readonly [DeleteEventSignal](Widget/DeleteEventSignal.md) | Signal Descriptor for OnDeleteEvent. |
| static readonly [DestroyEventSignal](Widget/DestroyEventSignal.md) | Signal Descriptor for OnDestroyEvent. |
| static readonly [DestroySignal](Widget/DestroySignal.md) | Signal Descriptor for OnDestroy. |
| static readonly [DirectionChangedSignal](Widget/DirectionChangedSignal.md) | Signal Descriptor for OnDirectionChanged. |
| static readonly [DragBeginSignal](Widget/DragBeginSignal.md) | Signal Descriptor for OnDragBegin. |
| static readonly [DragDataDeleteSignal](Widget/DragDataDeleteSignal.md) | Signal Descriptor for OnDragDataDelete. |
| static readonly [DragDataGetSignal](Widget/DragDataGetSignal.md) | Signal Descriptor for OnDragDataGet. |
| static readonly [DragDataReceivedSignal](Widget/DragDataReceivedSignal.md) | Signal Descriptor for OnDragDataReceived. |
| static readonly [DragDropSignal](Widget/DragDropSignal.md) | Signal Descriptor for OnDragDrop. |
| static readonly [DragEndSignal](Widget/DragEndSignal.md) | Signal Descriptor for OnDragEnd. |
| static readonly [DragFailedSignal](Widget/DragFailedSignal.md) | Signal Descriptor for OnDragFailed. |
| static readonly [DragLeaveSignal](Widget/DragLeaveSignal.md) | Signal Descriptor for OnDragLeave. |
| static readonly [DragMotionSignal](Widget/DragMotionSignal.md) | Signal Descriptor for OnDragMotion. |
| static readonly [DrawSignal](Widget/DrawSignal.md) | Signal Descriptor for OnDraw. |
| static readonly [EnterNotifyEventSignal](Widget/EnterNotifyEventSignal.md) | Signal Descriptor for OnEnterNotifyEvent. |
| static readonly [EventAfterSignal](Widget/EventAfterSignal.md) | Signal Descriptor for OnEventAfter. |
| static readonly [EventSignal](Widget/EventSignal.md) | Signal Descriptor for OnEvent. |
| static readonly [FocusInEventSignal](Widget/FocusInEventSignal.md) | Signal Descriptor for OnFocusInEvent. |
| static readonly [FocusOutEventSignal](Widget/FocusOutEventSignal.md) | Signal Descriptor for OnFocusOutEvent. |
| static readonly [FocusSignal](Widget/FocusSignal.md) | Signal Descriptor for OnFocus. |
| static readonly [GrabBrokenEventSignal](Widget/GrabBrokenEventSignal.md) | Signal Descriptor for OnGrabBrokenEvent. |
| static readonly [GrabFocusSignal](Widget/GrabFocusSignal.md) | Signal Descriptor for OnGrabFocus. |
| static readonly [GrabNotifySignal](Widget/GrabNotifySignal.md) | Signal Descriptor for OnGrabNotify. |
| static readonly [HAlignProperty](Widget/HAlignProperty.md) |  |
| static readonly [HeightRequestProperty](Widget/HeightRequestProperty.md) |  |
| static readonly [HExpandProperty](Widget/HExpandProperty.md) |  |
| static readonly [HideSignal](Widget/HideSignal.md) | Signal Descriptor for OnHide. |
| static readonly [HierarchyChangedSignal](Widget/HierarchyChangedSignal.md) | Signal Descriptor for OnHierarchyChanged. |
| static readonly [KeynavFailedSignal](Widget/KeynavFailedSignal.md) | Signal Descriptor for OnKeynavFailed. |
| static readonly [KeyPressEventSignal](Widget/KeyPressEventSignal.md) | Signal Descriptor for OnKeyPressEvent. |
| static readonly [KeyReleaseEventSignal](Widget/KeyReleaseEventSignal.md) | Signal Descriptor for OnKeyReleaseEvent. |
| static readonly [LeaveNotifyEventSignal](Widget/LeaveNotifyEventSignal.md) | Signal Descriptor for OnLeaveNotifyEvent. |
| static readonly [MapEventSignal](Widget/MapEventSignal.md) | Signal Descriptor for OnMapEvent. |
| static readonly [MapSignal](Widget/MapSignal.md) | Signal Descriptor for OnMap. |
| static readonly [MnemonicActivateSignal](Widget/MnemonicActivateSignal.md) | Signal Descriptor for OnMnemonicActivate. |
| static readonly [MotionNotifyEventSignal](Widget/MotionNotifyEventSignal.md) | Signal Descriptor for OnMotionNotifyEvent. |
| static readonly [MoveFocusSignal](Widget/MoveFocusSignal.md) | Signal Descriptor for OnMoveFocus. |
| static readonly [ParentSetSignal](Widget/ParentSetSignal.md) | Signal Descriptor for OnParentSet. |
| static readonly [PopupMenuSignal](Widget/PopupMenuSignal.md) | Signal Descriptor for OnPopupMenu. |
| static readonly [PropertyNotifyEventSignal](Widget/PropertyNotifyEventSignal.md) | Signal Descriptor for OnPropertyNotifyEvent. |
| static readonly [ProximityInEventSignal](Widget/ProximityInEventSignal.md) | Signal Descriptor for OnProximityInEvent. |
| static readonly [ProximityOutEventSignal](Widget/ProximityOutEventSignal.md) | Signal Descriptor for OnProximityOutEvent. |
| static readonly [QueryTooltipSignal](Widget/QueryTooltipSignal.md) | Signal Descriptor for OnQueryTooltip. |
| static readonly [RealizeSignal](Widget/RealizeSignal.md) | Signal Descriptor for OnRealize. |
| static readonly [ScreenChangedSignal](Widget/ScreenChangedSignal.md) | Signal Descriptor for OnScreenChanged. |
| static readonly [ScrollEventSignal](Widget/ScrollEventSignal.md) | Signal Descriptor for OnScrollEvent. |
| static readonly [SelectionClearEventSignal](Widget/SelectionClearEventSignal.md) | Signal Descriptor for OnSelectionClearEvent. |
| static readonly [SelectionGetSignal](Widget/SelectionGetSignal.md) | Signal Descriptor for OnSelectionGet. |
| static readonly [SelectionNotifyEventSignal](Widget/SelectionNotifyEventSignal.md) | Signal Descriptor for OnSelectionNotifyEvent. |
| static readonly [SelectionReceivedSignal](Widget/SelectionReceivedSignal.md) | Signal Descriptor for OnSelectionReceived. |
| static readonly [SelectionRequestEventSignal](Widget/SelectionRequestEventSignal.md) | Signal Descriptor for OnSelectionRequestEvent. |
| static readonly [ShowHelpSignal](Widget/ShowHelpSignal.md) | Signal Descriptor for OnShowHelp. |
| static readonly [ShowSignal](Widget/ShowSignal.md) | Signal Descriptor for OnShow. |
| static readonly [SizeAllocateSignal](Widget/SizeAllocateSignal.md) | Signal Descriptor for OnSizeAllocate. |
| static readonly [StateFlagsChangedSignal](Widget/StateFlagsChangedSignal.md) | Signal Descriptor for OnStateFlagsChanged. |
| static readonly [StyleUpdatedSignal](Widget/StyleUpdatedSignal.md) | Signal Descriptor for OnStyleUpdated. |
| static readonly [TouchEventSignal](Widget/TouchEventSignal.md) | Signal Descriptor for OnTouchEvent. |
| static readonly [UnmapEventSignal](Widget/UnmapEventSignal.md) | Signal Descriptor for OnUnmapEvent. |
| static readonly [UnmapSignal](Widget/UnmapSignal.md) | Signal Descriptor for OnUnmap. |
| static readonly [UnrealizeSignal](Widget/UnrealizeSignal.md) | Signal Descriptor for OnUnrealize. |
| static readonly [VAlignProperty](Widget/VAlignProperty.md) |  |
| static readonly [VExpandProperty](Widget/VExpandProperty.md) |  |
| static readonly [WidthRequestProperty](Widget/WidthRequestProperty.md) |  |
| static readonly [WindowStateEventSignal](Widget/WindowStateEventSignal.md) | Signal Descriptor for OnWindowStateEvent. |
| class [ButtonPressEventSignalArgs](Widget.ButtonPressEventSignalArgs.md) | Signal (Event) Arguments for OnButtonPressEvent |
| class [ButtonReleaseEventSignalArgs](Widget.ButtonReleaseEventSignalArgs.md) | Signal (Event) Arguments for OnButtonReleaseEvent |
| class [CanActivateAccelSignalArgs](Widget.CanActivateAccelSignalArgs.md) | Signal (Event) Arguments for OnCanActivateAccel |
| class [ChildNotifySignalArgs](Widget.ChildNotifySignalArgs.md) | Signal (Event) Arguments for OnChildNotify |
| class [ConfigureEventSignalArgs](Widget.ConfigureEventSignalArgs.md) | Signal (Event) Arguments for OnConfigureEvent |
| class [DamageEventSignalArgs](Widget.DamageEventSignalArgs.md) | Signal (Event) Arguments for OnDamageEvent |
| class [DeleteEventSignalArgs](Widget.DeleteEventSignalArgs.md) | Signal (Event) Arguments for OnDeleteEvent |
| class [DestroyEventSignalArgs](Widget.DestroyEventSignalArgs.md) | Signal (Event) Arguments for OnDestroyEvent |
| class [DirectionChangedSignalArgs](Widget.DirectionChangedSignalArgs.md) | Signal (Event) Arguments for OnDirectionChanged |
| class [DragBeginSignalArgs](Widget.DragBeginSignalArgs.md) | Signal (Event) Arguments for OnDragBegin |
| class [DragDataDeleteSignalArgs](Widget.DragDataDeleteSignalArgs.md) | Signal (Event) Arguments for OnDragDataDelete |
| class [DragDataGetSignalArgs](Widget.DragDataGetSignalArgs.md) | Signal (Event) Arguments for OnDragDataGet |
| class [DragDataReceivedSignalArgs](Widget.DragDataReceivedSignalArgs.md) | Signal (Event) Arguments for OnDragDataReceived |
| class [DragDropSignalArgs](Widget.DragDropSignalArgs.md) | Signal (Event) Arguments for OnDragDrop |
| class [DragEndSignalArgs](Widget.DragEndSignalArgs.md) | Signal (Event) Arguments for OnDragEnd |
| class [DragFailedSignalArgs](Widget.DragFailedSignalArgs.md) | Signal (Event) Arguments for OnDragFailed |
| class [DragLeaveSignalArgs](Widget.DragLeaveSignalArgs.md) | Signal (Event) Arguments for OnDragLeave |
| class [DragMotionSignalArgs](Widget.DragMotionSignalArgs.md) | Signal (Event) Arguments for OnDragMotion |
| class [DrawSignalArgs](Widget.DrawSignalArgs.md) | Signal (Event) Arguments for OnDraw |
| class [EnterNotifyEventSignalArgs](Widget.EnterNotifyEventSignalArgs.md) | Signal (Event) Arguments for OnEnterNotifyEvent |
| class [EventAfterSignalArgs](Widget.EventAfterSignalArgs.md) | Signal (Event) Arguments for OnEventAfter |
| class [EventSignalArgs](Widget.EventSignalArgs.md) | Signal (Event) Arguments for OnEvent |
| class [FocusInEventSignalArgs](Widget.FocusInEventSignalArgs.md) | Signal (Event) Arguments for OnFocusInEvent |
| class [FocusOutEventSignalArgs](Widget.FocusOutEventSignalArgs.md) | Signal (Event) Arguments for OnFocusOutEvent |
| class [FocusSignalArgs](Widget.FocusSignalArgs.md) | Signal (Event) Arguments for OnFocus |
| class [GrabBrokenEventSignalArgs](Widget.GrabBrokenEventSignalArgs.md) | Signal (Event) Arguments for OnGrabBrokenEvent |
| class [GrabNotifySignalArgs](Widget.GrabNotifySignalArgs.md) | Signal (Event) Arguments for OnGrabNotify |
| class [HierarchyChangedSignalArgs](Widget.HierarchyChangedSignalArgs.md) | Signal (Event) Arguments for OnHierarchyChanged |
| class [KeynavFailedSignalArgs](Widget.KeynavFailedSignalArgs.md) | Signal (Event) Arguments for OnKeynavFailed |
| class [KeyPressEventSignalArgs](Widget.KeyPressEventSignalArgs.md) | Signal (Event) Arguments for OnKeyPressEvent |
| class [KeyReleaseEventSignalArgs](Widget.KeyReleaseEventSignalArgs.md) | Signal (Event) Arguments for OnKeyReleaseEvent |
| class [LeaveNotifyEventSignalArgs](Widget.LeaveNotifyEventSignalArgs.md) | Signal (Event) Arguments for OnLeaveNotifyEvent |
| class [MapEventSignalArgs](Widget.MapEventSignalArgs.md) | Signal (Event) Arguments for OnMapEvent |
| class [MnemonicActivateSignalArgs](Widget.MnemonicActivateSignalArgs.md) | Signal (Event) Arguments for OnMnemonicActivate |
| class [MotionNotifyEventSignalArgs](Widget.MotionNotifyEventSignalArgs.md) | Signal (Event) Arguments for OnMotionNotifyEvent |
| class [MoveFocusSignalArgs](Widget.MoveFocusSignalArgs.md) | Signal (Event) Arguments for OnMoveFocus |
| class [ParentSetSignalArgs](Widget.ParentSetSignalArgs.md) | Signal (Event) Arguments for OnParentSet |
| class [PropertyNotifyEventSignalArgs](Widget.PropertyNotifyEventSignalArgs.md) | Signal (Event) Arguments for OnPropertyNotifyEvent |
| class [ProximityInEventSignalArgs](Widget.ProximityInEventSignalArgs.md) | Signal (Event) Arguments for OnProximityInEvent |
| class [ProximityOutEventSignalArgs](Widget.ProximityOutEventSignalArgs.md) | Signal (Event) Arguments for OnProximityOutEvent |
| class [QueryTooltipSignalArgs](Widget.QueryTooltipSignalArgs.md) | Signal (Event) Arguments for OnQueryTooltip |
| class [ScreenChangedSignalArgs](Widget.ScreenChangedSignalArgs.md) | Signal (Event) Arguments for OnScreenChanged |
| class [ScrollEventSignalArgs](Widget.ScrollEventSignalArgs.md) | Signal (Event) Arguments for OnScrollEvent |
| class [SelectionClearEventSignalArgs](Widget.SelectionClearEventSignalArgs.md) | Signal (Event) Arguments for OnSelectionClearEvent |
| class [SelectionGetSignalArgs](Widget.SelectionGetSignalArgs.md) | Signal (Event) Arguments for OnSelectionGet |
| class [SelectionNotifyEventSignalArgs](Widget.SelectionNotifyEventSignalArgs.md) | Signal (Event) Arguments for OnSelectionNotifyEvent |
| class [SelectionReceivedSignalArgs](Widget.SelectionReceivedSignalArgs.md) | Signal (Event) Arguments for OnSelectionReceived |
| class [SelectionRequestEventSignalArgs](Widget.SelectionRequestEventSignalArgs.md) | Signal (Event) Arguments for OnSelectionRequestEvent |
| class [ShowHelpSignalArgs](Widget.ShowHelpSignalArgs.md) | Signal (Event) Arguments for OnShowHelp |
| class [SizeAllocateSignalArgs](Widget.SizeAllocateSignalArgs.md) | Signal (Event) Arguments for OnSizeAllocate |
| class [StateChangedSignalArgs](Widget.StateChangedSignalArgs.md) | Signal (Event) Arguments for OnStateChanged |
| class [StateFlagsChangedSignalArgs](Widget.StateFlagsChangedSignalArgs.md) | Signal (Event) Arguments for OnStateFlagsChanged |
| class [StyleSetSignalArgs](Widget.StyleSetSignalArgs.md) | Signal (Event) Arguments for OnStyleSet |
| class [TouchEventSignalArgs](Widget.TouchEventSignalArgs.md) | Signal (Event) Arguments for OnTouchEvent |
| class [UnmapEventSignalArgs](Widget.UnmapEventSignalArgs.md) | Signal (Event) Arguments for OnUnmapEvent |
| class [VisibilityNotifyEventSignalArgs](Widget.VisibilityNotifyEventSignalArgs.md) | Signal (Event) Arguments for OnVisibilityNotifyEvent |
| class [WindowStateEventSignalArgs](Widget.WindowStateEventSignalArgs.md) | Signal (Event) Arguments for OnWindowStateEvent |

## See Also

* interface [Buildable](Buildable.md)
* namespace [Gtk](../Gtk3.md)

<!-- DO NOT EDIT: generated by xmldocmd for Gtk3.dll -->
