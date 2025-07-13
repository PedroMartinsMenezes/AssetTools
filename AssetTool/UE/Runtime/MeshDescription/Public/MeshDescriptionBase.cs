namespace AssetTool
{
    [JsonAsset("MeshDescriptionBase")]
    public class UMeshDescriptionBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}