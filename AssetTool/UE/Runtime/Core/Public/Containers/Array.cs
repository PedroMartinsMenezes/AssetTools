namespace AssetTool
{
    public static class TCanBulkSerialize
    {
        public static bool Value<T>()
        {
            if (typeof(T) == typeof(TInt8)) return true;
            if (typeof(T) == typeof(TInt16)) return true;
            if (typeof(T) == typeof(TInt32)) return true;
            if (typeof(T) == typeof(TInt64)) return true;
            if (typeof(T) == typeof(TUInt8)) return true;
            if (typeof(T) == typeof(TUInt16)) return true;
            if (typeof(T) == typeof(TUInt32)) return true;
            if (typeof(T) == typeof(TUInt64)) return true;
            if (typeof(T) == typeof(TFloat)) return true;
            if (typeof(T) == typeof(TDouble)) return true;
            return false;
        }
    }
}
