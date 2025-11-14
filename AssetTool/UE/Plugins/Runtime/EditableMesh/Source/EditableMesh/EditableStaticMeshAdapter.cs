namespace AssetTool
{
    [JsonAsset("EditableStaticMeshAdapter")]
    public class UEditableStaticMeshAdapter : UEditableMeshAdapter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}