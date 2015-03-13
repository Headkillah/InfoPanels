using System;
using System.Reflection;
using System.Text;

namespace ViceMayor.Util
{
    public static class DebugHelper
    {
        private static readonly StringBuilder Builder = new StringBuilder();

        public static string RecursiveSerialize(object obj, int maxDepth = 2)
        {
            Builder.Length = 0;
            PrintAllFields(obj, 0, maxDepth);

            return Builder.ToString();
        }

        private static void PrintAllFields(object obj, int indent = 0, int maxDepth = 2)
        {
            foreach (FieldInfo info in obj.GetType().GetFields())
            {
                object returnedValue = info.GetValue(obj);

                if (returnedValue.ToString() == info.FieldType.Name && indent <= maxDepth)
                {
                    PrintAllFields(returnedValue, indent + 1, maxDepth);
                    returnedValue = "v";
                }

                Builder.Append(new String('\t', indent));
                Builder.AppendFormat("{0} = {1}: {2}", info.Name, info.FieldType.Name, returnedValue);
                Builder.AppendLine();
            }
        }
    }
}
