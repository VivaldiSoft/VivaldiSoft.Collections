<a name='assembly'></a>
# VivaldiSoft.Collections

## Contents

- [BidirHashtable](#T-VivaldiSoft-Collections-BidirHashtable 'VivaldiSoft.Collections.BidirHashtable')
  - [Add(key,val)](#M-VivaldiSoft-Collections-BidirHashtable-Add-System-Object,System-Object- 'VivaldiSoft.Collections.BidirHashtable.Add(System.Object,System.Object)')
  - [Clear()](#M-VivaldiSoft-Collections-BidirHashtable-Clear 'VivaldiSoft.Collections.BidirHashtable.Clear')
  - [Contains(key)](#M-VivaldiSoft-Collections-BidirHashtable-Contains-System-Object- 'VivaldiSoft.Collections.BidirHashtable.Contains(System.Object)')
  - [ContainsValue(val)](#M-VivaldiSoft-Collections-BidirHashtable-ContainsValue-System-Object- 'VivaldiSoft.Collections.BidirHashtable.ContainsValue(System.Object)')
  - [Count()](#M-VivaldiSoft-Collections-BidirHashtable-Count 'VivaldiSoft.Collections.BidirHashtable.Count')
  - [Get(key)](#M-VivaldiSoft-Collections-BidirHashtable-Get-System-Object- 'VivaldiSoft.Collections.BidirHashtable.Get(System.Object)')
  - [GetKey(val)](#M-VivaldiSoft-Collections-BidirHashtable-GetKey-System-Object- 'VivaldiSoft.Collections.BidirHashtable.GetKey(System.Object)')
  - [Remove(key)](#M-VivaldiSoft-Collections-BidirHashtable-Remove-System-Object- 'VivaldiSoft.Collections.BidirHashtable.Remove(System.Object)')
  - [RemoveValue(val)](#M-VivaldiSoft-Collections-BidirHashtable-RemoveValue-System-Object- 'VivaldiSoft.Collections.BidirHashtable.RemoveValue(System.Object)')
  - [Set(key,val)](#M-VivaldiSoft-Collections-BidirHashtable-Set-System-Object,System-Object- 'VivaldiSoft.Collections.BidirHashtable.Set(System.Object,System.Object)')
- [Heap\`1](#T-VivaldiSoft-Collections-Heap`1 'VivaldiSoft.Collections.Heap`1')
  - [#ctor(minSize)](#M-VivaldiSoft-Collections-Heap`1-#ctor-System-Int32- 'VivaldiSoft.Collections.Heap`1.#ctor(System.Int32)')
- [IHeap\`1](#T-VivaldiSoft-Collections-IHeap`1 'VivaldiSoft.Collections.IHeap`1')
  - [Count](#P-VivaldiSoft-Collections-IHeap`1-Count 'VivaldiSoft.Collections.IHeap`1.Count')
  - [IsEmpty](#P-VivaldiSoft-Collections-IHeap`1-IsEmpty 'VivaldiSoft.Collections.IHeap`1.IsEmpty')
  - [Insert(val)](#M-VivaldiSoft-Collections-IHeap`1-Insert-`0- 'VivaldiSoft.Collections.IHeap`1.Insert(`0)')
  - [Peek()](#M-VivaldiSoft-Collections-IHeap`1-Peek 'VivaldiSoft.Collections.IHeap`1.Peek')
  - [Remove()](#M-VivaldiSoft-Collections-IHeap`1-Remove 'VivaldiSoft.Collections.IHeap`1.Remove')
- [MaxHeap\`1](#T-VivaldiSoft-Collections-MaxHeap`1 'VivaldiSoft.Collections.MaxHeap`1')
  - [#ctor(minSize)](#M-VivaldiSoft-Collections-MaxHeap`1-#ctor-System-Int32- 'VivaldiSoft.Collections.MaxHeap`1.#ctor(System.Int32)')
- [MinHeap\`1](#T-VivaldiSoft-Collections-MinHeap`1 'VivaldiSoft.Collections.MinHeap`1')
  - [#ctor(minSize)](#M-VivaldiSoft-Collections-MinHeap`1-#ctor-System-Int32- 'VivaldiSoft.Collections.MinHeap`1.#ctor(System.Int32)')
- [TwoKeyHashtable](#T-VivaldiSoft-Collections-TwoKeyHashtable 'VivaldiSoft.Collections.TwoKeyHashtable')
  - [Add(key,key2,val)](#M-VivaldiSoft-Collections-TwoKeyHashtable-Add-System-Object,System-Object,System-Object- 'VivaldiSoft.Collections.TwoKeyHashtable.Add(System.Object,System.Object,System.Object)')
  - [Clear()](#M-VivaldiSoft-Collections-TwoKeyHashtable-Clear 'VivaldiSoft.Collections.TwoKeyHashtable.Clear')
  - [Contains(key,key2)](#M-VivaldiSoft-Collections-TwoKeyHashtable-Contains-System-Object,System-Object- 'VivaldiSoft.Collections.TwoKeyHashtable.Contains(System.Object,System.Object)')
  - [ContainsRow(key)](#M-VivaldiSoft-Collections-TwoKeyHashtable-ContainsRow-System-Object- 'VivaldiSoft.Collections.TwoKeyHashtable.ContainsRow(System.Object)')
  - [Count(key)](#M-VivaldiSoft-Collections-TwoKeyHashtable-Count-System-Object- 'VivaldiSoft.Collections.TwoKeyHashtable.Count(System.Object)')
  - [CountRow()](#M-VivaldiSoft-Collections-TwoKeyHashtable-CountRow 'VivaldiSoft.Collections.TwoKeyHashtable.CountRow')
  - [Item(key,key2)](#M-VivaldiSoft-Collections-TwoKeyHashtable-Item-System-Object,System-Object- 'VivaldiSoft.Collections.TwoKeyHashtable.Item(System.Object,System.Object)')
  - [Keys()](#M-VivaldiSoft-Collections-TwoKeyHashtable-Keys 'VivaldiSoft.Collections.TwoKeyHashtable.Keys')
  - [Remove(key,key2)](#M-VivaldiSoft-Collections-TwoKeyHashtable-Remove-System-Object,System-Object- 'VivaldiSoft.Collections.TwoKeyHashtable.Remove(System.Object,System.Object)')
  - [RemoveRow(key)](#M-VivaldiSoft-Collections-TwoKeyHashtable-RemoveRow-System-Object- 'VivaldiSoft.Collections.TwoKeyHashtable.RemoveRow(System.Object)')
  - [RowKeys(key)](#M-VivaldiSoft-Collections-TwoKeyHashtable-RowKeys-System-Object- 'VivaldiSoft.Collections.TwoKeyHashtable.RowKeys(System.Object)')

<a name='T-VivaldiSoft-Collections-BidirHashtable'></a>
## BidirHashtable `type`

##### Namespace

VivaldiSoft.Collections

##### Summary

Represents a collection of key/value pairs that are organized based on both hash code.

<a name='M-VivaldiSoft-Collections-BidirHashtable-Add-System-Object,System-Object-'></a>
### Add(key,val) `method`

##### Summary

Adds an element with the specified key and value into the BidirHashtable.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The key of the element to add. |
| val | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value of the element to add. |

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value"); 
```

<a name='M-VivaldiSoft-Collections-BidirHashtable-Clear'></a>
### Clear() `method`

##### Summary

Removes all elements from the BidirHashtable.

##### Parameters

This method has no parameters.

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
bidirHashtable.Clear(); 
```

<a name='M-VivaldiSoft-Collections-BidirHashtable-Contains-System-Object-'></a>
### Contains(key) `method`

##### Summary

Determines whether the BidirHashtable contains a specific key.

##### Returns

True if the BidirHashtable contains an element with the specified key; otherwise, false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The key to locate in the BidirHashtable. |

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
var result = bidirHashtable.Contains("key");
/*
result is true
*/ 
```

<a name='M-VivaldiSoft-Collections-BidirHashtable-ContainsValue-System-Object-'></a>
### ContainsValue(val) `method`

##### Summary

Determines whether the BidirHashtable contains a specific value.

##### Returns

True if the BidirHashtable contains an element with the specified value; otherwise, false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| val | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value to locate in the BidirHashtable. |

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
var result = bidirHashtable.ContainsValue("value");
/*
result is true
*/ 
```

<a name='M-VivaldiSoft-Collections-BidirHashtable-Count'></a>
### Count() `method`

##### Summary

Gets the number of key/value pairs contained in the BidirHashtable.

##### Returns

The number of key/value pairs contained in the BidirHashtable.

##### Parameters

This method has no parameters.

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
bidirHashtable.Add("key2", "value2");
var result = bidirHashtable.Count();
/*
result is 2
*/ 
```

<a name='M-VivaldiSoft-Collections-BidirHashtable-Get-System-Object-'></a>
### Get(key) `method`

##### Summary

Gets the value associated with the specified key.

##### Returns

The value associated with the specified key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The key whose value to get. |

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
var result = bidirHashtable.Get("key");
/*
result is "value"
*/ 
```

<a name='M-VivaldiSoft-Collections-BidirHashtable-GetKey-System-Object-'></a>
### GetKey(val) `method`

##### Summary

Gets the key associated with the specified value.

##### Returns

The key associated with the specified value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| val | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value whose key to get. |

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
var result = bidirHashtable.GetKey("value");
/*
result is "key"
*/ 
```

<a name='M-VivaldiSoft-Collections-BidirHashtable-Remove-System-Object-'></a>
### Remove(key) `method`

##### Summary

Removes the element with the specified key from the BidirHashtable.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The key of the element to remove. |

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
bidirHashtable.Remove("key"); 
```

<a name='M-VivaldiSoft-Collections-BidirHashtable-RemoveValue-System-Object-'></a>
### RemoveValue(val) `method`

##### Summary

Removes the element with the specified value from the BidirHashtable.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| val | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value of the element to remove. |

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
bidirHashtable.RemoveValue("value"); 
```

<a name='M-VivaldiSoft-Collections-BidirHashtable-Set-System-Object,System-Object-'></a>
### Set(key,val) `method`

##### Summary

Sets the value associated with the specified key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The key whose value to set. |
| val | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value of the element to set. |

##### Example

```csharp
var bidirHashtable = new BidirHashtable();
bidirHashtable.Add("key", "value");
bidirHashtable.Set("key", "foo");
var result = bidirHashtable.Get("key");
/*
result is "foo"
*/ 
```

<a name='T-VivaldiSoft-Collections-Heap`1'></a>
## Heap\`1 `type`

##### Namespace

VivaldiSoft.Collections

##### Summary

Array-based Heap implementation.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Kind of thing being stored in the heap. |

<a name='M-VivaldiSoft-Collections-Heap`1-#ctor-System-Int32-'></a>
### #ctor(minSize) `constructor`

##### Summary

Create a new heap.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| minSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The minimum number of elements the heap is expected to hold. |

<a name='T-VivaldiSoft-Collections-IHeap`1'></a>
## IHeap\`1 `type`

##### Namespace

VivaldiSoft.Collections

##### Summary

Array-based Heap implementation.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Kind of thing being stored in the heap. |

<a name='P-VivaldiSoft-Collections-IHeap`1-Count'></a>
### Count `property`

##### Summary

Current size of the Heap.

<a name='P-VivaldiSoft-Collections-IHeap`1-IsEmpty'></a>
### IsEmpty `property`

##### Summary

Test to see if the Heap is empty.

<a name='M-VivaldiSoft-Collections-IHeap`1-Insert-`0-'></a>
### Insert(val) `method`

##### Summary

Add a new value to the Heap.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| val | [\`0](#T-`0 '`0') | New value. |

<a name='M-VivaldiSoft-Collections-IHeap`1-Peek'></a>
### Peek() `method`

##### Summary

View the value currently at the top of the Heap.

##### Returns

Value at the top of the Heap.

##### Parameters

This method has no parameters.

<a name='M-VivaldiSoft-Collections-IHeap`1-Remove'></a>
### Remove() `method`

##### Summary

Remove the value currently at the top of the Heap and return it.

##### Returns

Value at the top of the Heap.

##### Parameters

This method has no parameters.

<a name='T-VivaldiSoft-Collections-MaxHeap`1'></a>
## MaxHeap\`1 `type`

##### Namespace

VivaldiSoft.Collections

##### Summary

Array-based Heap implementation.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Kind of thing being stored in the heap. |

<a name='M-VivaldiSoft-Collections-MaxHeap`1-#ctor-System-Int32-'></a>
### #ctor(minSize) `constructor`

##### Summary

Create a new heap.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| minSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The minimum number of elements the heap is expected to hold. |

<a name='T-VivaldiSoft-Collections-MinHeap`1'></a>
## MinHeap\`1 `type`

##### Namespace

VivaldiSoft.Collections

##### Summary

Array-based Heap implementation.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Kind of thing being stored in the heap. |

<a name='M-VivaldiSoft-Collections-MinHeap`1-#ctor-System-Int32-'></a>
### #ctor(minSize) `constructor`

##### Summary

Create a new heap.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| minSize | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The minimum number of elements the heap is expected to hold. |

<a name='T-VivaldiSoft-Collections-TwoKeyHashtable'></a>
## TwoKeyHashtable `type`

##### Namespace

VivaldiSoft.Collections

##### Summary

Represents a collection of 2-keys/value trios that are organized based on the hash code of the 2-keys.

<a name='M-VivaldiSoft-Collections-TwoKeyHashtable-Add-System-Object,System-Object,System-Object-'></a>
### Add(key,key2,val) `method`

##### Summary

Adds an element with the specified keys and value into the TwoKeyHashtable.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The first key of the element to add. |
| key2 | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The second key of the element to add. |
| val | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The value of the element to add. |

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value"); 
```

<a name='M-VivaldiSoft-Collections-TwoKeyHashtable-Clear'></a>
### Clear() `method`

##### Summary

Removes all elements from the TwoKeyHashtable.

##### Parameters

This method has no parameters.

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.Clear(); 
```

<a name='M-VivaldiSoft-Collections-TwoKeyHashtable-Contains-System-Object,System-Object-'></a>
### Contains(key,key2) `method`

##### Summary

Determines whether the TwoKeyHashtable contains the two specific key element.

##### Returns

True if contains the two specific key element, false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The first key to locate in the TwoKeyHashtable. |
| key2 | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The second key to locate in the TwoKeyHashtable. |

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.Contains("key", "key2");
/*
result is true
*/ 
```

<a name='M-VivaldiSoft-Collections-TwoKeyHashtable-ContainsRow-System-Object-'></a>
### ContainsRow(key) `method`

##### Summary

Determines whether the TwoKeyHashtable contains the specific row.

##### Returns

True if contains the specific key element, false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The key to locate in the TwoKeyHashtable. |

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.ContainsRow("key");
/*
result is true
*/ 
```

<a name='M-VivaldiSoft-Collections-TwoKeyHashtable-Count-System-Object-'></a>
### Count(key) `method`

##### Summary

Gets the number of key/value pairs contained in a dimension of the TwoKeyHashtable.

##### Returns

The number of elements contained in the TwoKeyHashtable for a specific dimension.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The dimension key of the TwoKeyHashtable. |

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.Count("key");
/*
result is 1
*/ 
```

<a name='M-VivaldiSoft-Collections-TwoKeyHashtable-CountRow'></a>
### CountRow() `method`

##### Summary

Gets the number of first key trios contained in the TwoKeyHashtable.

##### Returns

The number of elements contained in the TwoKeyHashtable.

##### Parameters

This method has no parameters.

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.CountRow();
/*
result is 1
*/ 
```

<a name='M-VivaldiSoft-Collections-TwoKeyHashtable-Item-System-Object,System-Object-'></a>
### Item(key,key2) `method`

##### Summary

Gets the value associated with the specified keys.

##### Returns

The value associated with the specified key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The first key whose value to get or set. |
| key2 | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The second key whose value to get or set. |

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.Item("key", "key2");
/*
result is "value"
*/ 
```

<a name='M-VivaldiSoft-Collections-TwoKeyHashtable-Keys'></a>
### Keys() `method`

##### Summary

Gets an ICollection containing the keys in the TwoKeyHashtable.

##### Returns

An ICollection containing the keys in the TwoKeyHashtable.

##### Parameters

This method has no parameters.

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.Keys(); 
```

<a name='M-VivaldiSoft-Collections-TwoKeyHashtable-Remove-System-Object,System-Object-'></a>
### Remove(key,key2) `method`

##### Summary

Removes the element with the two specified keys from the TwoKeyHashtable.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The first key of the element to remove. |
| key2 | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The second key of the element to remove. |

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
twoKeyHashtable.Remove("key", "key2"); 
```

<a name='M-VivaldiSoft-Collections-TwoKeyHashtable-RemoveRow-System-Object-'></a>
### RemoveRow(key) `method`

##### Summary

Removes the row with the specified key from the TwoKeyHashtable.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The key of the row to remove. |

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
twoKeyHashtable.RemoveRow("key"); 
```

<a name='M-VivaldiSoft-Collections-TwoKeyHashtable-RowKeys-System-Object-'></a>
### RowKeys(key) `method`

##### Summary

Gets an ICollection containing the keys of the specified row in the TwoKeyHashtable.

##### Returns

An ICollection containing the keys of the specified row in the TwoKeyHashtable.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The key of the row to gets the ICollection. |

##### Example

```csharp
var twoKeyHashtable = new TwoKeyHashtable();
twoKeyHashtable.Add("key", "key2", "value");
var result = twoKeyHashtable.RowKeys("key"); 
```
