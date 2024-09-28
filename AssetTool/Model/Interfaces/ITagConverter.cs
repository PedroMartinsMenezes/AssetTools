namespace AssetTool
{
    public interface ITagConverter
    {
        string TagName { get; }
        int TagSize { get; }
        object TagRead(object elem);
    }
}
