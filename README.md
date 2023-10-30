In this task I have to create an object copy class called “SimpleMapper”. There will be a
“Copy” method that takes two objects, one is source object and another is destination object.
And I have to copy all data from source to destination.

One important thing in this task is, there will be nested objects, list of objects in the source and
destination classes. But I can’t assign them using “=” because that will assign reference not
the actual value. I have to recursively go inside those types and copy the values.

For copying values, I have to check the names of the properties of source and destination
objects. If they match, and if the data type is also the same, then  copy the value, otherwise
 skip.
I have to use recursion and reflection to complete this task
