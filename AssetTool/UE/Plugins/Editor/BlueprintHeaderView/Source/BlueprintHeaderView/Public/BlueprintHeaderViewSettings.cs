namespace AssetTool
{
    [JsonAsset("BlueprintHeaderViewSettings")]
    public class UBlueprintHeaderViewSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}