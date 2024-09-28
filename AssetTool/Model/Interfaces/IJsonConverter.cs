namespace AssetTool
{
    public interface IJsonConverter
    {
        object JsonRead(object value);
        object JsonWrite();
    }
}
