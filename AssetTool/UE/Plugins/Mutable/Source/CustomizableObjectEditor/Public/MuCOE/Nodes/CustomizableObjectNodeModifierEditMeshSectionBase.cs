namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeModifierEditMeshSectionBase")]
    public class UCustomizableObjectNodeModifierEditMeshSectionBase : UCustomizableObjectNodeModifierWithMaterial
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}