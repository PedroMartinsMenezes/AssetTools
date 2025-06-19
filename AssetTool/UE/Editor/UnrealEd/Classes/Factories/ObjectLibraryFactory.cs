namespace AssetTool
{
    [JsonAsset("ObjectLibraryFactory")]
    public class UObjectLibraryFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}