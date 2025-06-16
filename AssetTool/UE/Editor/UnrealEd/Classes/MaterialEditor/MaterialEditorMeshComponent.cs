namespace AssetTool
{
    [JsonAsset("MaterialEditorMeshComponent")]
    public class UMaterialEditorMeshComponent : UStaticMeshComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}