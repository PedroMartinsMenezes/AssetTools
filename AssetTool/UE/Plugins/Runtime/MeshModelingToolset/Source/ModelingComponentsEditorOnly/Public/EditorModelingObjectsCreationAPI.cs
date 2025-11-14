namespace AssetTool
{
    [JsonAsset("EditorModelingObjectsCreationAPI")]
    public class UEditorModelingObjectsCreationAPI : UModelingObjectsCreationAPI
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}