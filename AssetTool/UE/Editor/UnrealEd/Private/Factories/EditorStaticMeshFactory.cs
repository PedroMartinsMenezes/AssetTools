namespace AssetTool
{
    [JsonAsset("EditorStaticMeshFactory")]
    public class UEditorStaticMeshFactory : UActorFactoryStaticMesh
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}