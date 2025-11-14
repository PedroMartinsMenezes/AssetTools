namespace AssetTool
{
    [JsonAsset("ObjectLibrary")]
    public class UObjectLibrary : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}