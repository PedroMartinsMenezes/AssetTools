namespace AssetTool
{
    [JsonAsset("PCGRandomChoiceSettings")]
    public class UPCGRandomChoiceSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}