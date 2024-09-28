namespace AssetTool
{
    public interface ITagSelector
    {
        string GetType(int size);
        object GetValue(object value, int size);
    }
}
