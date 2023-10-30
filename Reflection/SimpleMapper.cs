using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

public class SimpleMapper
{
    public void Copy(object source, object destination)
    {
        CopyValues(source, destination);
    }

    private void CopyValues(object source, object destination)
    {
        Type sourceType = source.GetType();
        Type destinationType = destination.GetType();

        PropertyInfo[] sourceProperties = sourceType.GetProperties();
        PropertyInfo[] destinationProperties = destinationType.GetProperties();

        foreach (PropertyInfo sourceProperty in sourceProperties)
        {
            PropertyInfo destinationProperty = Array.Find(destinationProperties, prop => prop.Name == sourceProperty.Name);

            if (destinationProperty != null && sourceProperty.PropertyType == destinationProperty.PropertyType)
            {
                object sourceValue = sourceProperty.GetValue(source);
                object destinationValue = destinationProperty.GetValue(destination);

                if (sourceValue is IList sourceList && destinationValue is IList destinationList)
                {
                    CopyList(sourceList, destinationList);
                }
                else if (sourceValue != null && destinationValue != null && sourceValue.GetType().IsClass && destinationValue.GetType().IsClass)
                {
                    
                    CopyValues(sourceValue, destinationValue);
                }
                else if (destinationProperty.CanWrite) 
                {
                    destinationProperty.SetValue(destination, sourceValue);
                }
            }
        }
    }


    private void CopyList(IList sourceList, IList destinationList)
    {
        destinationList.Clear();

        foreach (var item in sourceList)
        {
            if (item != null && item.GetType().IsClass && destinationList.GetType().GetGenericArguments()[0].IsAssignableFrom(item.GetType()))
            {
                var destinationItem = Activator.CreateInstance(destinationList.GetType().GetGenericArguments()[0]);
                CopyValues(item, destinationItem);
                destinationList.Add(destinationItem);
            }
            else
            {
                destinationList.Add(item);
            }
        }
    }
}
