namespace AssetTool
{
    [JsonAsset("PCGRandomChoiceSettings")]
    public class UPCGRandomChoiceSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}