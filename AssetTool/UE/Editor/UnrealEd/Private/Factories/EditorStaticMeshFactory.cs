namespace AssetTool
{
    [JsonAsset("EditorStaticMeshFactory")]
    public class UEditorStaticMeshFactory : UActorFactoryStaticMesh
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}