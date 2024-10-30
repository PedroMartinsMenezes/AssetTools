namespace AssetTool
{
    [JsonAsset("BlueprintInterfaceFactory")]
    public class UBlueprintInterfaceFactory : UBlueprintFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}