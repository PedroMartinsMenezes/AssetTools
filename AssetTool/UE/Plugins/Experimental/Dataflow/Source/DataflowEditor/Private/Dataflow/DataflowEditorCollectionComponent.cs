namespace AssetTool
{
    [JsonAsset("DataflowEditorCollectionComponent")]
    public class UDataflowEditorCollectionComponent : UDynamicMeshComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}