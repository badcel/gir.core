# Window class

```csharp
public class Window : Bin
```

## Public Members

| name | description |
| --- | --- |
| [Window](Window/Window.md)(…) | Creates a new instance of [`Window`](Window.md). (2 constructors) |
| [AcceptFocus](Window/AcceptFocus.md) { get; set; } |  |
| [Application](Window/Application.md) { get; set; } |  |
| [AttachedTo](Window/AttachedTo.md) { get; set; } |  |
| [Decorated](Window/Decorated.md) { get; set; } |  |
| [DefaultHeight](Window/DefaultHeight.md) { get; set; } |  |
| [DefaultWidth](Window/DefaultWidth.md) { get; set; } |  |
| [Deletable](Window/Deletable.md) { get; set; } |  |
| [DestroyWithParent](Window/DestroyWithParent.md) { get; set; } |  |
| [FocusOnMap](Window/FocusOnMap.md) { get; set; } |  |
| [FocusVisible](Window/FocusVisible.md) { get; set; } |  |
| [Gravity](Window/Gravity.md) { get; set; } |  |
| [HasToplevelFocus](Window/HasToplevelFocus.md) { get; } |  |
| [HideTitlebarWhenMaximized](Window/HideTitlebarWhenMaximized.md) { get; set; } |  |
| [Icon](Window/Icon.md) { get; set; } |  |
| [IconName](Window/IconName.md) { get; set; } |  |
| [IsActive](Window/IsActive.md) { get; } |  |
| [IsMaximized](Window/IsMaximized.md) { get; } |  |
| [Item](Window/Item.md) { set; } | Indexer to connect with a SignalHandler&lt;Window&gt; (3 indexers) |
| [MnemonicsVisible](Window/MnemonicsVisible.md) { get; set; } |  |
| [Modal](Window/Modal.md) { get; set; } |  |
| [Resizable](Window/Resizable.md) { get; set; } |  |
| [Role](Window/Role.md) { get; set; } |  |
| [Screen](Window/Screen.md) { get; set; } |  |
| [SkipPagerHint](Window/SkipPagerHint.md) { get; set; } |  |
| [SkipTaskbarHint](Window/SkipTaskbarHint.md) { get; set; } |  |
| [StartupId](Window/StartupId.md) { set; } |  |
| [Title](Window/Title.md) { get; set; } |  |
| [TransientFor](Window/TransientFor.md) { get; set; } |  |
| [Type](Window/Type.md) { get; set; } |  |
| [TypeHint](Window/TypeHint.md) { get; set; } |  |
| [UrgencyHint](Window/UrgencyHint.md) { get; set; } |  |
| [WindowPosition](Window/WindowPosition.md) { get; set; } |  |
| event [OnActivateDefault](Window/OnActivateDefault.md) |  |
| event [OnActivateFocus](Window/OnActivateFocus.md) |  |
| event [OnEnableDebugging](Window/OnEnableDebugging.md) |  |
| event [OnKeysChanged](Window/OnKeysChanged.md) |  |
| event [OnSetFocus](Window/OnSetFocus.md) |  |
| [ActivateDefault](Window/ActivateDefault.md)() |  |
| [ActivateFocus](Window/ActivateFocus.md)() |  |
| [ActivateKey](Window/ActivateKey.md)(…) |  |
| [AddAccelGroup](Window/AddAccelGroup.md)(…) |  |
| [AddMnemonic](Window/AddMnemonic.md)(…) |  |
| [BeginMoveDrag](Window/BeginMoveDrag.md)(…) |  |
| [BeginResizeDrag](Window/BeginResizeDrag.md)(…) |  |
| [Close](Window/Close.md)() |  |
| [Deiconify](Window/Deiconify.md)() |  |
| [Fullscreen](Window/Fullscreen.md)() |  |
| [FullscreenOnMonitor](Window/FullscreenOnMonitor.md)(…) |  |
| [GetAcceptFocus](Window/GetAcceptFocus.md)() |  |
| [GetApplication](Window/GetApplication.md)() |  |
| [GetAttachedTo](Window/GetAttachedTo.md)() |  |
| [GetDecorated](Window/GetDecorated.md)() |  |
| [GetDefaultSize](Window/GetDefaultSize.md)(…) |  |
| [GetDeletable](Window/GetDeletable.md)() |  |
| [GetDestroyWithParent](Window/GetDestroyWithParent.md)() |  |
| [GetFocus](Window/GetFocus.md)() |  |
| [GetFocus&lt;T&gt;](Window/GetFocus.md)() |  |
| [GetFocusVisible](Window/GetFocusVisible.md)() |  |
| [GetGravity](Window/GetGravity.md)() |  |
| [GetHideTitlebarWhenMaximized](Window/GetHideTitlebarWhenMaximized.md)() |  |
| [GetIcon](Window/GetIcon.md)() |  |
| [GetIconList](Window/GetIconList.md)() |  |
| [GetIconName](Window/GetIconName.md)() |  |
| [GetMnemonicModifier](Window/GetMnemonicModifier.md)() |  |
| [GetMnemonicsVisible](Window/GetMnemonicsVisible.md)() |  |
| [GetModal](Window/GetModal.md)() |  |
| [GetPosition](Window/GetPosition.md)(…) |  |
| [GetResizable](Window/GetResizable.md)() |  |
| [GetRole](Window/GetRole.md)() |  |
| [GetScreen](Window/GetScreen.md)() |  |
| [GetSize](Window/GetSize.md)(…) |  |
| [GetSkipPagerHint](Window/GetSkipPagerHint.md)() |  |
| [GetSkipTaskbarHint](Window/GetSkipTaskbarHint.md)() |  |
| [GetTitle](Window/GetTitle.md)() |  |
| [GetTitlebar](Window/GetTitlebar.md)() |  |
| [GetTransientFor](Window/GetTransientFor.md)() |  |
| [GetTypeHint](Window/GetTypeHint.md)() |  |
| [GetUrgencyHint](Window/GetUrgencyHint.md)() |  |
| [GetWindowType](Window/GetWindowType.md)() |  |
| [Iconify](Window/Iconify.md)() |  |
| [ListToplevels](Window/ListToplevels.md)() |  |
| [Maximize](Window/Maximize.md)() |  |
| [MnemonicActivate](Window/MnemonicActivate.md)(…) |  |
| [Move](Window/Move.md)(…) |  |
| [Present](Window/Present.md)() |  |
| [PresentWithTime](Window/PresentWithTime.md)(…) |  |
| [PropagateKeyEvent](Window/PropagateKeyEvent.md)(…) |  |
| [RemoveAccelGroup](Window/RemoveAccelGroup.md)(…) |  |
| [RemoveMnemonic](Window/RemoveMnemonic.md)(…) |  |
| [Resize](Window/Resize.md)(…) |  |
| [SetAcceptFocus](Window/SetAcceptFocus.md)(…) |  |
| [SetApplication](Window/SetApplication.md)(…) |  |
| [SetAttachedTo](Window/SetAttachedTo.md)(…) |  |
| [SetDecorated](Window/SetDecorated.md)(…) |  |
| [SetDefault](Window/SetDefault.md)(…) |  |
| [SetDefaultSize](Window/SetDefaultSize.md)(…) |  |
| [SetDeletable](Window/SetDeletable.md)(…) |  |
| [SetDestroyWithParent](Window/SetDestroyWithParent.md)(…) |  |
| [SetFocus](Window/SetFocus.md)(…) |  |
| [SetFocusOnMap](Window/SetFocusOnMap.md)(…) |  |
| [SetFocusVisible](Window/SetFocusVisible.md)(…) |  |
| [SetGeometryHints](Window/SetGeometryHints.md)(…) |  |
| [SetGravity](Window/SetGravity.md)(…) |  |
| [SetHasUserRefCount](Window/SetHasUserRefCount.md)(…) |  |
| [SetHideTitlebarWhenMaximized](Window/SetHideTitlebarWhenMaximized.md)(…) |  |
| [SetIcon](Window/SetIcon.md)(…) |  |
| [SetIconFromFile](Window/SetIconFromFile.md)(…) |  |
| [SetIconList](Window/SetIconList.md)(…) |  |
| [SetIconName](Window/SetIconName.md)(…) |  |
| [SetKeepAbove](Window/SetKeepAbove.md)(…) |  |
| [SetKeepBelow](Window/SetKeepBelow.md)(…) |  |
| [SetMnemonicModifier](Window/SetMnemonicModifier.md)(…) |  |
| [SetMnemonicsVisible](Window/SetMnemonicsVisible.md)(…) |  |
| [SetModal](Window/SetModal.md)(…) |  |
| [SetPosition](Window/SetPosition.md)(…) |  |
| [SetResizable](Window/SetResizable.md)(…) |  |
| [SetRole](Window/SetRole.md)(…) |  |
| [SetScreen](Window/SetScreen.md)(…) |  |
| [SetSkipPagerHint](Window/SetSkipPagerHint.md)(…) |  |
| [SetSkipTaskbarHint](Window/SetSkipTaskbarHint.md)(…) |  |
| [SetStartupId](Window/SetStartupId.md)(…) |  |
| [SetTitle](Window/SetTitle.md)(…) |  |
| [SetTitlebar](Window/SetTitlebar.md)(…) |  |
| [SetTransientFor](Window/SetTransientFor.md)(…) |  |
| [SetTypeHint](Window/SetTypeHint.md)(…) |  |
| [SetUrgencyHint](Window/SetUrgencyHint.md)(…) |  |
| [Stick](Window/Stick.md)() |  |
| [Unfullscreen](Window/Unfullscreen.md)() |  |
| [Unmaximize](Window/Unmaximize.md)() |  |
| [Unstick](Window/Unstick.md)() |  |
| static readonly [AcceptFocusProperty](Window/AcceptFocusProperty.md) | Property descriptor for the [`AcceptFocus`](Window/AcceptFocus.md) property. |
| static readonly [ActivateDefaultSignal](Window/ActivateDefaultSignal.md) | Signal Descriptor for OnActivateDefault. |
| static readonly [ActivateFocusSignal](Window/ActivateFocusSignal.md) | Signal Descriptor for OnActivateFocus. |
| static readonly [ApplicationProperty](Window/ApplicationProperty.md) | Property descriptor for the [`Application`](Window/Application.md) property. |
| static readonly [AttachedToProperty](Window/AttachedToProperty.md) | Property descriptor for the [`AttachedTo`](Window/AttachedTo.md) property. |
| static readonly [DecoratedProperty](Window/DecoratedProperty.md) | Property descriptor for the [`Decorated`](Window/Decorated.md) property. |
| static readonly [DefaultHeightProperty](Window/DefaultHeightProperty.md) | Property descriptor for the [`DefaultHeight`](Window/DefaultHeight.md) property. |
| static readonly [DefaultWidthProperty](Window/DefaultWidthProperty.md) | Property descriptor for the [`DefaultWidth`](Window/DefaultWidth.md) property. |
| static readonly [DeletableProperty](Window/DeletableProperty.md) | Property descriptor for the [`Deletable`](Window/Deletable.md) property. |
| static readonly [DestroyWithParentProperty](Window/DestroyWithParentProperty.md) | Property descriptor for the [`DestroyWithParent`](Window/DestroyWithParent.md) property. |
| static readonly [EnableDebuggingSignal](Window/EnableDebuggingSignal.md) | Signal Descriptor for OnEnableDebugging. |
| static readonly [FocusOnMapProperty](Window/FocusOnMapProperty.md) | Property descriptor for the [`FocusOnMap`](Window/FocusOnMap.md) property. |
| static readonly [FocusVisibleProperty](Window/FocusVisibleProperty.md) | Property descriptor for the [`FocusVisible`](Window/FocusVisible.md) property. |
| static readonly [GravityProperty](Window/GravityProperty.md) | Property descriptor for the [`Gravity`](Window/Gravity.md) property. |
| static readonly [HasToplevelFocusProperty](Window/HasToplevelFocusProperty.md) | Property descriptor for the [`HasToplevelFocus`](Window/HasToplevelFocus.md) property. |
| static readonly [HideTitlebarWhenMaximizedProperty](Window/HideTitlebarWhenMaximizedProperty.md) | Property descriptor for the [`HideTitlebarWhenMaximized`](Window/HideTitlebarWhenMaximized.md) property. |
| static readonly [IconNameProperty](Window/IconNameProperty.md) | Property descriptor for the [`IconName`](Window/IconName.md) property. |
| static readonly [IconProperty](Window/IconProperty.md) | Property descriptor for the [`Icon`](Window/Icon.md) property. |
| static readonly [IsActiveProperty](Window/IsActiveProperty.md) | Property descriptor for the [`IsActive`](Window/IsActive.md) property. |
| static readonly [IsMaximizedProperty](Window/IsMaximizedProperty.md) | Property descriptor for the [`IsMaximized`](Window/IsMaximized.md) property. |
| static readonly [KeysChangedSignal](Window/KeysChangedSignal.md) | Signal Descriptor for OnKeysChanged. |
| static readonly [MnemonicsVisibleProperty](Window/MnemonicsVisibleProperty.md) | Property descriptor for the [`MnemonicsVisible`](Window/MnemonicsVisible.md) property. |
| static readonly [ModalProperty](Window/ModalProperty.md) | Property descriptor for the [`Modal`](Window/Modal.md) property. |
| static readonly [ResizableProperty](Window/ResizableProperty.md) | Property descriptor for the [`Resizable`](Window/Resizable.md) property. |
| static readonly [RoleProperty](Window/RoleProperty.md) | Property descriptor for the [`Role`](Window/Role.md) property. |
| static readonly [ScreenProperty](Window/ScreenProperty.md) | Property descriptor for the [`Screen`](Window/Screen.md) property. |
| static readonly [SetFocusSignal](Window/SetFocusSignal.md) | Signal Descriptor for OnSetFocus. |
| static readonly [SkipPagerHintProperty](Window/SkipPagerHintProperty.md) | Property descriptor for the [`SkipPagerHint`](Window/SkipPagerHint.md) property. |
| static readonly [SkipTaskbarHintProperty](Window/SkipTaskbarHintProperty.md) | Property descriptor for the [`SkipTaskbarHint`](Window/SkipTaskbarHint.md) property. |
| static readonly [StartupIdProperty](Window/StartupIdProperty.md) | Property descriptor for the [`StartupId`](Window/StartupId.md) property. |
| static readonly [TitleProperty](Window/TitleProperty.md) | Property descriptor for the [`Title`](Window/Title.md) property. |
| static readonly [TransientForProperty](Window/TransientForProperty.md) | Property descriptor for the [`TransientFor`](Window/TransientFor.md) property. |
| static readonly [TypeHintProperty](Window/TypeHintProperty.md) | Property descriptor for the [`TypeHint`](Window/TypeHint.md) property. |
| static readonly [TypeProperty](Window/TypeProperty.md) | Property descriptor for the [`Type`](Window/Type.md) property. |
| static readonly [UrgencyHintProperty](Window/UrgencyHintProperty.md) | Property descriptor for the [`UrgencyHint`](Window/UrgencyHint.md) property. |
| static readonly [WindowPositionProperty](Window/WindowPositionProperty.md) | Property descriptor for the [`WindowPosition`](Window/WindowPosition.md) property. |
| static [GetDefaultIconList](Window/GetDefaultIconList.md)() |  |
| static [GetDefaultIconName](Window/GetDefaultIconName.md)() |  |
| static [SetAutoStartupNotification](Window/SetAutoStartupNotification.md)(…) |  |
| static [SetDefaultIcon](Window/SetDefaultIcon.md)(…) |  |
| static [SetDefaultIconFromFile](Window/SetDefaultIconFromFile.md)(…) |  |
| static [SetDefaultIconList](Window/SetDefaultIconList.md)(…) |  |
| static [SetDefaultIconName](Window/SetDefaultIconName.md)(…) |  |
| static [SetInteractiveDebugging](Window/SetInteractiveDebugging.md)(…) |  |
| class [EnableDebuggingSignalArgs](Window.EnableDebuggingSignalArgs.md) | Signal (Event) Arguments for OnEnableDebugging |
| class [SetFocusSignalArgs](Window.SetFocusSignalArgs.md) | Signal (Event) Arguments for OnSetFocus |

## See Also

* class [Bin](Bin.md)
* namespace [Gtk](../Gtk3.md)

<!-- DO NOT EDIT: generated by xmldocmd for Gtk3.dll -->
