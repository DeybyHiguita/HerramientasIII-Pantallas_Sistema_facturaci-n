using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class DataMapper
    {
        public static List<T> MapToList<T>(DataTable table) where T : new()
        {
            if (table == null || table.Rows.Count == 0) return new List<T>();

            List<T> list = new List<T>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(MapToObject<T>(row));
            }

            return list;
        }

        private static T MapToObject<T>(DataRow row) where T : new()
        {
            T val = new T();
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (PropertyInfo propertyInfo in properties)
            {
                PropertyInfo[] nestedProperties = propertyInfo.PropertyType.GetProperties();

                if (nestedProperties.Length != 0 && !propertyInfo.PropertyType.IsPrimitive
                    && propertyInfo.PropertyType != typeof(string)
                    && !IsNumericType(propertyInfo.PropertyType)
                    && propertyInfo.PropertyType != typeof(DateTime)
                    && propertyInfo.PropertyType != typeof(DateTime?))
                {
                    object obj = Activator.CreateInstance(propertyInfo.PropertyType);

                    foreach (PropertyInfo nestedProperty in nestedProperties)
                    {
                        string columnName = propertyInfo.Name + "_" + nestedProperty.Name;
                        if (row.Table.Columns.Contains(columnName) && row[columnName] != DBNull.Value)
                        {
                            object nestedValue = row[columnName];
                            Type nestedTargetType = Nullable.GetUnderlyingType(nestedProperty.PropertyType) ?? nestedProperty.PropertyType;

                            object nestedSafeValue;

                            if (nestedValue.GetType() == nestedTargetType || nestedTargetType.IsAssignableFrom(nestedValue.GetType()))
                            {
                                nestedSafeValue = nestedValue;
                            }
                            else
                            {
                                nestedSafeValue = Convert.ChangeType(nestedValue, nestedTargetType);
                            }

                            nestedProperty.SetValue(obj, nestedSafeValue, null);
                        }
                    }

                    propertyInfo.SetValue(val, obj, null);
                }
                else if (row.Table.Columns.Contains(propertyInfo.Name))
                {
                    object obj2 = row[propertyInfo.Name];
                    if (obj2 != DBNull.Value)
                    {
                        Type targetType = Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType;

                        object safeValue;

                        if (obj2.GetType() == targetType || targetType.IsAssignableFrom(obj2.GetType()))
                        {
                            safeValue = obj2;
                        }
                        else
                        {
                            safeValue = Convert.ChangeType(obj2, targetType);
                        }

                        propertyInfo.SetValue(val, safeValue);
                    }
                }
            }

            return val;
        }

        internal static bool IsNumericType(Type type)
        {
            if (!(type == typeof(byte)) && !(type == typeof(sbyte)) && !(type == typeof(short)) && !(type == typeof(ushort)) && !(type == typeof(int)) && !(type == typeof(uint)) && !(type == typeof(long)) && !(type == typeof(ulong)) && !(type == typeof(float)) && !(type == typeof(double)))
            {
                return type == typeof(decimal);
            }

            return true;
        }
    }
}