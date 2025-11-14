namespace AssetTool
{
    [JsonAsset("DataflowEditorCollectionComponent")]
    public class UDataflowEditorCollectionComponent : UDynamicMeshComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}