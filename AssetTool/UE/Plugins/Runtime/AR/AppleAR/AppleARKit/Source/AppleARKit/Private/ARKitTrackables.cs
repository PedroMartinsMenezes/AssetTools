namespace AssetTool
{
    [JsonAsset("ARKitMeshGeometry")]
    public class UARKitMeshGeometry : UARMeshGeometry
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}