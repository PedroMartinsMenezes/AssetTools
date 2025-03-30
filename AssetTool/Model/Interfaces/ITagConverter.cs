namespace AssetTool
{
    public interface ITagConverter
    {
        int TagSize(Transfer transfer);
        object TagRead(object elem, Transfer transfer);
    }
}
