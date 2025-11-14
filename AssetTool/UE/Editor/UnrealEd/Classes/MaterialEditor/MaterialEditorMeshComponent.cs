namespace AssetTool
{
    [JsonAsset("MaterialEditorMeshComponent")]
    public class UMaterialEditorMeshComponent : UStaticMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}