namespace AssetTool
{
    [JsonAsset("LegacyEdModeWrapper")]
    public class ULegacyEdModeWrapper : UEdMode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}