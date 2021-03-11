using System;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace Assignment5.Infrastructure
{
    //this is a tool to convert our cart data into a json string and back so that we can display it - can't store carts in a session.
    public static class SessionExtensions
    {
        public static void SetJson (this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetJson<T> (this ISession session, string key)
        {
            var sessionData = session.GetString(key);

            return sessionData == null ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
        }
    }
}
