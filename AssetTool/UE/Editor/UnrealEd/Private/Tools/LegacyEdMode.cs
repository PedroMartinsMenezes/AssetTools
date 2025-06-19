namespace AssetTool
{
    [JsonAsset("LegacyEdModeWrapper")]
    public class ULegacyEdModeWrapper : UEdMode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}