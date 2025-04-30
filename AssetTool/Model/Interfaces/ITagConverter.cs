namespace AssetTool
{
    public interface ITagConverter
    {
        object DerivedToTag(object elem, Transfer transfer);
    }
}
