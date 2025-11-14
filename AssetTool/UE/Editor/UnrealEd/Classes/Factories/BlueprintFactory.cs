namespace AssetTool
{
    [JsonAsset("BlueprintFactory")]
    public class UBlueprintFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}