namespace AssetTool
{
    [JsonAsset("EditableStaticMeshAdapter")]
    public class UEditableStaticMeshAdapter : UEditableMeshAdapter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}