namespace AssetTool
{
    [JsonAsset("AnimBlueprintFactory")]
    public class UAnimBlueprintFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimLayerInterfaceFactory")]
    public class UAnimLayerInterfaceFactory : UAnimBlueprintFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}