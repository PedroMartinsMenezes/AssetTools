namespace AssetTool
{
    [JsonAsset("AnimBlueprintFactory")]
    public class UAnimBlueprintFactory : UFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AnimLayerInterfaceFactory")]
    public class UAnimLayerInterfaceFactory : UAnimBlueprintFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}