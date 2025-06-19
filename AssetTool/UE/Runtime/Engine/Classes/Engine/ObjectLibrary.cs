namespace AssetTool
{
    [JsonAsset("ObjectLibrary")]
    public class UObjectLibrary : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}