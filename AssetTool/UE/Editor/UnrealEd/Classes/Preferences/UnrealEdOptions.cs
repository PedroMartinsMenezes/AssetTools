namespace AssetTool
{
    [JsonAsset("UnrealEdOptions")]
    public class UUnrealEdOptions : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}