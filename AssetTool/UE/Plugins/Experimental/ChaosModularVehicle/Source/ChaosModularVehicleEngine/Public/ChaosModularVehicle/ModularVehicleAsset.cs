namespace AssetTool
{
    [JsonAsset("ModularVehicleAsset")]
    public class UModularVehicleAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}