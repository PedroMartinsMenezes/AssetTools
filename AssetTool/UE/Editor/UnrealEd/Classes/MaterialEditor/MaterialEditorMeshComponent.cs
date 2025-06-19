namespace AssetTool
{
    [JsonAsset("MaterialEditorMeshComponent")]
    public class UMaterialEditorMeshComponent : UStaticMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}