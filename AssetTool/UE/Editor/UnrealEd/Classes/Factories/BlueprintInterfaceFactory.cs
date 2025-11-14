namespace AssetTool
{
    [JsonAsset("BlueprintInterfaceFactory")]
    public class UBlueprintInterfaceFactory : UBlueprintFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}