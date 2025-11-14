namespace AssetTool
{
    [JsonAsset("BlueprintHeaderViewSettings")]
    public class UBlueprintHeaderViewSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}