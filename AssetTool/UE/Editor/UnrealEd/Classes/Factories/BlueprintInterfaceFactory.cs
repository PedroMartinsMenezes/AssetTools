namespace AssetTool
{
    [JsonAsset("BlueprintInterfaceFactory")]
    public class UBlueprintInterfaceFactory : UBlueprintFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}