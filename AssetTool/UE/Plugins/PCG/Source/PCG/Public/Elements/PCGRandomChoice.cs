namespace AssetTool
{
    [JsonAsset("PCGRandomChoiceSettings")]
    public class UPCGRandomChoiceSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}