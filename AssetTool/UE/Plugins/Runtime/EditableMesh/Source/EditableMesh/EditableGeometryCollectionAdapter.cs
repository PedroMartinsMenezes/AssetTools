namespace AssetTool
{
    [JsonAsset("EditableGeometryCollectionAdapter")]
    public class UEditableGeometryCollectionAdapter : UEditableMeshAdapter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}