namespace AssetTool
{
    [JsonAsset("StaticMeshExporterFBX")]
    public class UStaticMeshExporterFBX : UExporterFBX
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}