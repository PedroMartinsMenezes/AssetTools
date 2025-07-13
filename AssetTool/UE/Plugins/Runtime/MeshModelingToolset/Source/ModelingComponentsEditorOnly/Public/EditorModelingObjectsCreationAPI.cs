namespace AssetTool
{
    [JsonAsset("EditorModelingObjectsCreationAPI")]
    public class UEditorModelingObjectsCreationAPI : UModelingObjectsCreationAPI
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}