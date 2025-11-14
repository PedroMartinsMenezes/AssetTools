namespace AssetTool
{
    [JsonAsset("ModifierHierarchyAsset")]
    public class UModifierHierarchyAsset : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}