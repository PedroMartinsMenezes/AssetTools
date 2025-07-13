namespace AssetTool
{
    [JsonAsset("MutableValidationSettings")]
    public class UMutableValidationSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}