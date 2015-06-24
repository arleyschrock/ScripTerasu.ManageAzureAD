using System;
using System.IO;
using System.Linq.Expressions;
using System.Xml.Serialization;

namespace ScripTerasu.ManageAzureAD.Helpers
{
    public static class TypeExtension
    {
        ////a thread-safe way to hold default instances created at run-time
        //private static ConcurrentDictionary<Type, object> typeDefaults = new ConcurrentDictionary<Type, object>();

        //public static object GetDefaultValue(this Type type)
        //{
        //    return type.IsValueType ? typeDefaults.GetOrAdd(type, t => Activator.CreateInstance(t)) : null;
        //}

        public static T GetDefaultValue<T>()
        {
            // We want an Func<T> which returns the default.
            // Create that expression here.
            Expression<Func<T>> e = Expression.Lambda<Func<T>>(
                // The default value, always get what the *code* tells us.
                Expression.Default(typeof(T))
            );

            // Compile and return the value.
            return e.Compile()();
        }

        public static object GetDefaultValue(this Type type)
        {
            // Validate parameters.
            if (type == null) throw new ArgumentNullException("type");

            // We want an Func<object> which returns the default.
            // Create that expression here.
            Expression<Func<object>> e = Expression.Lambda<Func<object>>(
                // Have to convert to object.
                Expression.Convert(
                // The default value, always get what the *code* tells us.
                    Expression.Default(type), typeof(object)
                )
            );

            // Compile and return the value.
            return e.Compile()();
        }

        public static object GetNewObject(Type t)
        {
            try
            {
                return Activator.CreateInstance(t);
            }
            catch
            {
                return null;
            }
        }

        public static T GetNewObject<T>()
        {
            try
            {
                return (T)Activator.CreateInstance(typeof(T));
            }
            catch
            {
                return default(T);
            }
        }

        public static string Serialize(object dataToSerialize)
        {
            if (dataToSerialize == null) return null;

            using (StringWriter stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(dataToSerialize.GetType());
                serializer.Serialize(stringwriter, dataToSerialize);
                return stringwriter.ToString();
            }
        }

        public static T Deserialize<T>(string xmlText)
        {
            if (String.IsNullOrWhiteSpace(xmlText)) return default(T);

            using (StringReader stringReader = new System.IO.StringReader(xmlText))
            {
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stringReader);
            }
        }

        public static T ToObject<T>(object value)
        {
            string xmlText = Serialize(value);
            return (T)Deserialize<T>(xmlText);
        }

    }
}
