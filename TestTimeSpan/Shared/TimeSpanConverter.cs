using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TestTimeSpan.Shared
{
    public sealed class TimeSpanConverter : JsonConverter<TimeSpan>
    {
        public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.Read())
            {
                return TimeSpan.FromTicks(reader.GetInt64());
            }

            return TimeSpan.FromSeconds(0);
        }

        public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
