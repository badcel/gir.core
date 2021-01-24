# GObject assembly

## GObject namespace

| public type | description |
| --- | --- |
| static class [AssemblyExtension](GObject/AssemblyExtension.md) |  |
| delegate [BaseFinalizeFunc](GObject/BaseFinalizeFunc.md) |  |
| delegate [BaseInitFunc](GObject/BaseInitFunc.md) |  |
| class [Binding](GObject/Binding.md) |  |
| [Flags] enum [BindingFlags](GObject/BindingFlags.md) |  |
| delegate [BindingTransformFunc](GObject/BindingTransformFunc.md) |  |
| delegate [BoxedCopyFunc](GObject/BoxedCopyFunc.md) |  |
| delegate [BoxedFreeFunc](GObject/BoxedFreeFunc.md) |  |
| delegate [Callback](GObject/Callback.md) |  |
| struct [CClosure](GObject/CClosure.md) |  |
| delegate [ClassFinalizeFunc](GObject/ClassFinalizeFunc.md) |  |
| delegate [ClassInitFunc](GObject/ClassInitFunc.md) |  |
| struct [Closure](GObject/Closure.md) |  |
| delegate [ClosureMarshal](GObject/ClosureMarshal.md) |  |
| delegate [ClosureNotify](GObject/ClosureNotify.md) |  |
| struct [ClosureNotifyData](GObject/ClosureNotifyData.md) |  |
| [Flags] enum [ConnectFlags](GObject/ConnectFlags.md) |  |
| class [Constants](GObject/Constants.md) |  |
| class [ConstructParameter](GObject/ConstructParameter.md) | Define the value of GProperty which can be used at the construct time. |
| struct [EnumClass](GObject/EnumClass.md) |  |
| struct [EnumValue](GObject/EnumValue.md) |  |
| struct [FlagsClass](GObject/FlagsClass.md) |  |
| struct [FlagsValue](GObject/FlagsValue.md) |  |
| class [Global](GObject/Global.md) |  |
| class [InitiallyUnowned](GObject/InitiallyUnowned.md) |  |
| struct [InitiallyUnownedClass](GObject/InitiallyUnownedClass.md) |  |
| delegate [InstanceInitFunc](GObject/InstanceInitFunc.md) |  |
| delegate [InterfaceFinalizeFunc](GObject/InterfaceFinalizeFunc.md) |  |
| struct [InterfaceInfo](GObject/InterfaceInfo.md) |  |
| delegate [InterfaceInitFunc](GObject/InterfaceInitFunc.md) |  |
| interface [IObject](GObject/IObject.md) |  |
| class [Object](GObject/Object.md) |  |
| struct [ObjectClass](GObject/ObjectClass.md) |  |
| struct [ObjectConstructParam](GObject/ObjectConstructParam.md) |  |
| delegate [ObjectFinalizeFunc](GObject/ObjectFinalizeFunc.md) |  |
| delegate [ObjectGetPropertyFunc](GObject/ObjectGetPropertyFunc.md) |  |
| delegate [ObjectSetPropertyFunc](GObject/ObjectSetPropertyFunc.md) |  |
| struct [Parameter](GObject/Parameter.md) |  |
| [Flags] enum [ParamFlags](GObject/ParamFlags.md) |  |
| class [ParamSpec](GObject/ParamSpec.md) |  |
| class [ParamSpecBoolean](GObject/ParamSpecBoolean.md) |  |
| class [ParamSpecBoxed](GObject/ParamSpecBoxed.md) |  |
| class [ParamSpecChar](GObject/ParamSpecChar.md) |  |
| struct [ParamSpecClass](GObject/ParamSpecClass.md) |  |
| class [ParamSpecDouble](GObject/ParamSpecDouble.md) |  |
| class [ParamSpecEnum](GObject/ParamSpecEnum.md) |  |
| class [ParamSpecFlags](GObject/ParamSpecFlags.md) |  |
| class [ParamSpecFloat](GObject/ParamSpecFloat.md) |  |
| class [ParamSpecGType](GObject/ParamSpecGType.md) |  |
| class [ParamSpecInt](GObject/ParamSpecInt.md) |  |
| class [ParamSpecInt64](GObject/ParamSpecInt64.md) |  |
| class [ParamSpecLong](GObject/ParamSpecLong.md) |  |
| class [ParamSpecObject](GObject/ParamSpecObject.md) |  |
| class [ParamSpecOverride](GObject/ParamSpecOverride.md) |  |
| class [ParamSpecParam](GObject/ParamSpecParam.md) |  |
| class [ParamSpecPointer](GObject/ParamSpecPointer.md) |  |
| struct [ParamSpecPool](GObject/ParamSpecPool.md) |  |
| class [ParamSpecString](GObject/ParamSpecString.md) |  |
| struct [ParamSpecTypeInfo](GObject/ParamSpecTypeInfo.md) |  |
| class [ParamSpecUChar](GObject/ParamSpecUChar.md) |  |
| class [ParamSpecUInt](GObject/ParamSpecUInt.md) |  |
| class [ParamSpecUInt64](GObject/ParamSpecUInt64.md) |  |
| class [ParamSpecULong](GObject/ParamSpecULong.md) |  |
| class [ParamSpecUnichar](GObject/ParamSpecUnichar.md) |  |
| class [ParamSpecValueArray](GObject/ParamSpecValueArray.md) |  |
| class [ParamSpecVariant](GObject/ParamSpecVariant.md) |  |
| class [Property&lt;T&gt;](GObject/Property-1.md) | Describes a GProperty. |
| class [Signal&lt;TSender&gt;](GObject/Signal-1.md) | Describes a GSignal. |
| class [Signal&lt;TSender,TSignalArgs&gt;](GObject/Signal-2.md) | Describes a GSignal. |
| class [Signal](GObject/Signal.md) |  |
| delegate [SignalAccumulator](GObject/SignalAccumulator.md) |  |
| class [SignalArgs](GObject/SignalArgs.md) | Base class for signal based events. |
| delegate [SignalEmissionHook](GObject/SignalEmissionHook.md) |  |
| [Flags] enum [SignalFlags](GObject/SignalFlags.md) |  |
| delegate [SignalHandler&lt;TSender&gt;](GObject/SignalHandler-1.md) | SignalHandler for signals without any extra data. |
| delegate [SignalHandler&lt;TSender,TSignalArgs&gt;](GObject/SignalHandler-2.md) | SignalHandler for signals with extra data. |
| struct [SignalInvocationHint](GObject/SignalInvocationHint.md) |  |
| [Flags] enum [SignalMatchType](GObject/SignalMatchType.md) |  |
| struct [SignalQuery](GObject/SignalQuery.md) |  |
| delegate [ToggleNotify](GObject/ToggleNotify.md) |  |
| struct [Type](GObject/Type.md) |  |
| struct [TypeClass](GObject/TypeClass.md) |  |
| delegate [TypeClassCacheFunc](GObject/TypeClassCacheFunc.md) |  |
| struct [TypeCValue](GObject/TypeCValue.md) |  |
| [Flags] enum [TypeDebugFlags](GObject/TypeDebugFlags.md) |  |
| [Flags] enum [TypeFlags](GObject/TypeFlags.md) |  |
| [Flags] enum [TypeFundamentalFlags](GObject/TypeFundamentalFlags.md) |  |
| struct [TypeFundamentalInfo](GObject/TypeFundamentalInfo.md) |  |
| struct [TypeInfo](GObject/TypeInfo.md) |  |
| struct [TypeInstance](GObject/TypeInstance.md) |  |
| struct [TypeInterface](GObject/TypeInterface.md) |  |
| delegate [TypeInterfaceCheckFunc](GObject/TypeInterfaceCheckFunc.md) |  |
| class [TypeModule](GObject/TypeModule.md) |  |
| struct [TypeModuleClass](GObject/TypeModuleClass.md) |  |
| interface [TypePlugin](GObject/TypePlugin.md) |  |
| struct [TypePluginClass](GObject/TypePluginClass.md) |  |
| delegate [TypePluginCompleteInterfaceInfo](GObject/TypePluginCompleteInterfaceInfo.md) |  |
| delegate [TypePluginCompleteTypeInfo](GObject/TypePluginCompleteTypeInfo.md) |  |
| delegate [TypePluginUnuse](GObject/TypePluginUnuse.md) |  |
| delegate [TypePluginUse](GObject/TypePluginUse.md) |  |
| struct [TypeQuery](GObject/TypeQuery.md) |  |
| struct [TypeValueTable](GObject/TypeValueTable.md) |  |
| delegate [VaClosureMarshal](GObject/VaClosureMarshal.md) |  |
| struct [Value](GObject/Value.md) |  |
| struct [ValueArray](GObject/ValueArray.md) |  |
| delegate [ValueTransform](GObject/ValueTransform.md) |  |
| delegate [WeakNotify](GObject/WeakNotify.md) |  |
| struct [WeakRef](GObject/WeakRef.md) |  |
| struct [_Value__data__union](GObject/_Value__data__union.md) |  |

<!-- DO NOT EDIT: generated by xmldocmd for GObject.dll -->
