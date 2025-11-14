namespace AssetTool
{
    [JsonAsset("EditableGeometryCollectionAdapter")]
    public class UEditableGeometryCollectionAdapter : UEditableMeshAdapter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}