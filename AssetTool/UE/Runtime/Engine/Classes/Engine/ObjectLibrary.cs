namespace AssetTool
{
    [JsonAsset("ObjectLibrary")]
    public class UObjectLibrary : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}