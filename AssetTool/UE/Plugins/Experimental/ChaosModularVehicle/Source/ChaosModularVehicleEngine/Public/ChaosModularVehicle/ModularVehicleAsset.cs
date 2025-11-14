namespace AssetTool
{
    [JsonAsset("ModularVehicleAsset")]
    public class UModularVehicleAsset : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}