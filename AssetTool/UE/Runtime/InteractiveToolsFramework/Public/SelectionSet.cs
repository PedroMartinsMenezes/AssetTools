namespace AssetTool
{
    [JsonAsset("SelectionSet")]
    public class USelectionSet : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MeshSelectionSet")]
    public class UMeshSelectionSet : USelectionSet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}