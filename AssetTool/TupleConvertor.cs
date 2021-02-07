using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using MessagePack;
using Newtonsoft.Json;

namespace D4DJ_Tools
{
    public class SBConverterIntInt<T> : JsonConverter<Dictionary<(int, int), T>>
    {
        /// <summary>
        /// Override ReadJson to read the dictionary key and value
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override Dictionary<(int, int), T> ReadJson(JsonReader reader, Type objectType, [AllowNull] Dictionary<(int, int), T> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var _dict = new Dictionary<(int, int), T>();

            //loop through the JSON string reader
            while (reader.Read())
            {
                // check whether it is a property
                if (reader.TokenType == JsonToken.PropertyName)
                {
                    string readerValue = reader.Value.ToString();
                    if (reader.Read())
                    {
                        // check if the property is tuple (Dictionary key)
                        if (readerValue.Contains('(') && readerValue.Contains(')'))
                        {
                            string[] result = ConvertTuple(readerValue);

                            if (result == null)
                                continue;

                            // Custom Deserialize the Dictionary key (Tuple)
                            var _tuple = (int.Parse(result[0].Trim()), int.Parse(result[1].Trim()));

                            // Custom Deserialize the Dictionary value
                            var _value = serializer.Deserialize<T>(reader);

                            _dict.Add(_tuple, _value);
                        }
                        else
                        {
                            // Deserialize the remaining data from the reader
                            serializer.Deserialize(reader);
                            break;
                        }
                    }
                }
            }
            return _dict;
        }

        /// <summary>
        /// To convert Tuple
        /// </summary>
        /// <param name="_string"></param>
        /// <returns></returns>
        public string[] ConvertTuple(string _string)
        {
            string tempStr = null;

            // remove the first character which is a brace '('
            if (_string.Contains('('))
                tempStr = _string.Remove(0, 1);

            // remove the last character which is a brace ')'
            if (_string.Contains(')'))
                tempStr = tempStr.Remove(tempStr.Length - 1, 1);

            // seperate the Item1 and Item2
            if (_string.Contains(','))
                return tempStr.Split(',');

            return null;
        }

        /// <summary>
        /// WriteJson needs to be implemented since it is an abstract function.
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, Dictionary<(int, int), T> value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }

    public class IntIntTuple
    {
        public int Item1;
        public int Item2;

        public static implicit operator IntIntTuple(string value)
        {
            var values = value.Trim('(', ')').Split(',', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            return new IntIntTuple { Item1 = int.Parse(values[0]), Item2 = int.Parse(values[1]) };
        }

        public static implicit operator string(IntIntTuple value)
        {
            return $"({value.Item1}, {value.Item2})";
        }

        public override string ToString()
        {
            return this;
        }
    }

    public class IntIntTupleDic<T> : Dictionary<(int,int), T>
    {

    }
}
