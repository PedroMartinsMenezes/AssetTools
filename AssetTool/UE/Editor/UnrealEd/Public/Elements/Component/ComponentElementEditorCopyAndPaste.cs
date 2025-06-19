namespace AssetTool
{
    [JsonAsset("ComponentElementsCopy")]
    public class UComponentElementsCopy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ComponentElementsExporterT3D")]
    public class UComponentElementsExporterT3D : UExporter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}