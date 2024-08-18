namespace AssetTool.Model.Singleton
{
    public static class GlobalCheck
    {
        public static void That(bool value, string msg)
        {
            if (!value)
                throw new ArgumentException(msg);
        }
    }
}
