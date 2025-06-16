namespace AssetTool
{
    [JsonAsset("LegacyEdModeWrapper")]
    public class ULegacyEdModeWrapper : UEdMode
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}