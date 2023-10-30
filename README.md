In this task I  create an object copy class called “SimpleMapper”. There is a
“Copy” method that takes two objects, one is source object and another is destination object.
And copy all data from source to destination.

One important thing in this task is, there is  nested objects, list of objects in the source and
destination classes. But I can’t assign them using “=” because that will assign reference not
the actual value.so, I use Recursive to go inside those types and copy the values.

For copying values, I have to check the names of the properties of source and destination
objects. If they match, and if the data type is also the same, then  copy the value, otherwise
skip.

I use recursion and reflection to complete this task
