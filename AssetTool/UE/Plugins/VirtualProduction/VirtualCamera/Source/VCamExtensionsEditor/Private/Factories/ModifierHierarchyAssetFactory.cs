namespace AssetTool
{
    [JsonAsset("ModifierHierarchyAssetFactory")]
    public class UModifierHierarchyAssetFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}