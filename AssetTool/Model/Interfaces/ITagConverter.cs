namespace AssetTool
{
    public interface ITagConverter
    {
        int TagSize { get; }
        object TagRead(object elem);
    }
}
