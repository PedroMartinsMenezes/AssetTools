namespace AssetTool
{
    public interface ITagConverter
    {
        //int TagSize(Transfer transfer);
        object DerivedToTag(object elem, Transfer transfer);
        //string GetType(int size);
        //object GetValue(object value, int size);
    }
}
