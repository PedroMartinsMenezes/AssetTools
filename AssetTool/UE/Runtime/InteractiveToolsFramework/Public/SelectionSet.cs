namespace AssetTool
{
    [JsonAsset("SelectionSet")]
    public class USelectionSet : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshSelectionSet")]
    public class UMeshSelectionSet : USelectionSet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}