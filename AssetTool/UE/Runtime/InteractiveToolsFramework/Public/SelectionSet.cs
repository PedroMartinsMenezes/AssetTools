namespace AssetTool
{
    [JsonAsset("SelectionSet")]
    public class USelectionSet : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshSelectionSet")]
    public class UMeshSelectionSet : USelectionSet
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}