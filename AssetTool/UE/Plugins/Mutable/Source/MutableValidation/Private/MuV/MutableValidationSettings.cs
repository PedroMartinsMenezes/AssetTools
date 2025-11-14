namespace AssetTool
{
    [JsonAsset("MutableValidationSettings")]
    public class UMutableValidationSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}