namespace AssetTool
{
    [JsonAsset("UnrealEdOptions")]
    public class UUnrealEdOptions : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}