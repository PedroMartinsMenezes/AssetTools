namespace AssetTool
{
    [JsonAsset("ModifierHierarchyAsset")]
    public class UModifierHierarchyAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}