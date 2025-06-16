namespace AssetTool
{
    [JsonAsset("StaticMeshExporterFBX")]
    public class UStaticMeshExporterFBX : UExporterFBX
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}