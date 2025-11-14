namespace AssetTool
{
    [JsonAsset("StanceSettings")]
    public class UStanceSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}