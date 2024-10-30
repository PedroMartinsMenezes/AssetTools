namespace AssetTool
{
    [JsonAsset("ObjectLibraryFactory")]
    public class UObjectLibraryFactory : UFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}