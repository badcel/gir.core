# Variant class

```csharp
public class Variant : IDisposable
```

## Public Members

| name | description |
| --- | --- |
| [Variant](Variant/Variant.md)(…) |  (2 constructors) |
| static [Create](Variant/Create.md)(…) |  (4 methods) |
| static [CreateEmptyDictionary](Variant/CreateEmptyDictionary.md)(…) |  |
| [Handle](Variant/Handle.md) { get; } |  |
| [Dispose](Variant/Dispose.md)() |  |
| [GetString](Variant/GetString.md)() |  |
| [Print](Variant/Print.md)(…) |  |
| static [byteswap](Variant/byteswap.md)(…) |  |
| static [check_format_string](Variant/check_format_string.md)(…) |  |
| static [classify](Variant/classify.md)(…) |  |
| static [compare](Variant/compare.md)(…) |  |
| static [dup_bytestring](Variant/dup_bytestring.md)(…) |  |
| static [dup_bytestring_array](Variant/dup_bytestring_array.md)(…) |  |
| static [dup_objv](Variant/dup_objv.md)(…) |  |
| static [dup_string](Variant/dup_string.md)(…) |  |
| static [dup_strv](Variant/dup_strv.md)(…) |  |
| static [equal](Variant/equal.md)(…) |  |
| static [get_boolean](Variant/get_boolean.md)(…) |  |
| static [get_byte](Variant/get_byte.md)(…) |  |
| static [get_bytestring](Variant/get_bytestring.md)(…) |  |
| static [get_bytestring_array](Variant/get_bytestring_array.md)(…) |  |
| static [get_child_value](Variant/get_child_value.md)(…) |  |
| static [get_data](Variant/get_data.md)(…) |  |
| static [get_data_as_bytes](Variant/get_data_as_bytes.md)(…) |  |
| static [get_double](Variant/get_double.md)(…) |  |
| static [get_fixed_array](Variant/get_fixed_array.md)(…) |  |
| static [get_handle](Variant/get_handle.md)(…) |  |
| static [get_int16](Variant/get_int16.md)(…) |  |
| static [get_int32](Variant/get_int32.md)(…) |  |
| static [get_int64](Variant/get_int64.md)(…) |  |
| static [get_maybe](Variant/get_maybe.md)(…) |  |
| static [get_normal_form](Variant/get_normal_form.md)(…) |  |
| static [get_objv](Variant/get_objv.md)(…) |  |
| static [get_size](Variant/get_size.md)(…) |  |
| static [get_string](Variant/get_string.md)(…) |  |
| static [get_strv](Variant/get_strv.md)(…) |  |
| static [get_type](Variant/get_type.md)(…) |  |
| static [get_type_string](Variant/get_type_string.md)(…) |  |
| static [get_uint16](Variant/get_uint16.md)(…) |  |
| static [get_uint32](Variant/get_uint32.md)(…) |  |
| static [get_uint64](Variant/get_uint64.md)(…) |  |
| static [get_va](Variant/get_va.md)(…) |  |
| static [get_variant](Variant/get_variant.md)(…) |  |
| static [hash](Variant/hash.md)(…) |  |
| static [is_container](Variant/is_container.md)(…) |  |
| static [is_floating](Variant/is_floating.md)(…) |  |
| static [is_normal_form](Variant/is_normal_form.md)(…) |  |
| static [is_object_path](Variant/is_object_path.md)(…) |  |
| static [is_of_type](Variant/is_of_type.md)(…) |  |
| static [is_signature](Variant/is_signature.md)(…) |  |
| static [iter_new](Variant/iter_new.md)(…) |  |
| static [lookup_value](Variant/lookup_value.md)(…) |  |
| static [new_array](Variant/new_array.md)(…) |  |
| static [new_boolean](Variant/new_boolean.md)(…) |  |
| static [new_byte](Variant/new_byte.md)(…) |  |
| static [new_bytestring](Variant/new_bytestring.md)(…) |  |
| static [new_bytestring_array](Variant/new_bytestring_array.md)(…) |  |
| static [new_dict_entry](Variant/new_dict_entry.md)(…) |  |
| static [new_double](Variant/new_double.md)(…) |  |
| static [new_fixed_array](Variant/new_fixed_array.md)(…) |  |
| static [new_from_bytes](Variant/new_from_bytes.md)(…) |  |
| static [new_from_data](Variant/new_from_data.md)(…) |  |
| static [new_handle](Variant/new_handle.md)(…) |  |
| static [new_int16](Variant/new_int16.md)(…) |  |
| static [new_int32](Variant/new_int32.md)(…) |  |
| static [new_int64](Variant/new_int64.md)(…) |  |
| static [new_maybe](Variant/new_maybe.md)(…) |  |
| static [new_object_path](Variant/new_object_path.md)(…) |  |
| static [new_objv](Variant/new_objv.md)(…) |  |
| static [new_parsed_va](Variant/new_parsed_va.md)(…) |  |
| static [new_signature](Variant/new_signature.md)(…) |  |
| static [new_string](Variant/new_string.md)(…) |  |
| static [new_strv](Variant/new_strv.md)(…) |  |
| static [new_take_string](Variant/new_take_string.md)(…) |  |
| static [new_tuple](Variant/new_tuple.md)(…) |  |
| static [new_uint16](Variant/new_uint16.md)(…) |  |
| static [new_uint32](Variant/new_uint32.md)(…) |  |
| static [new_uint64](Variant/new_uint64.md)(…) |  |
| static [new_va](Variant/new_va.md)(…) |  |
| static [new_variant](Variant/new_variant.md)(…) |  |
| static [n_children](Variant/n_children.md)(…) |  |
| static [parse](Variant/parse.md)(…) |  |
| static [parse_error_print_context](Variant/parse_error_print_context.md)(…) |  |
| static [parse_error_quark](Variant/parse_error_quark.md)() |  |
| static [print](Variant/print.md)(…) |  |
| static [print_string](Variant/print_string.md)(…) |  |
| static [ref](Variant/ref.md)(…) |  |
| static [ref_sink](Variant/ref_sink.md)(…) |  |
| static [store](Variant/store.md)(…) |  |
| static [take_ref](Variant/take_ref.md)(…) |  |
| static [unref](Variant/unref.md)(…) |  |

## See Also

* namespace [GLib](../GLib.md)

<!-- DO NOT EDIT: generated by xmldocmd for GLib.dll -->
