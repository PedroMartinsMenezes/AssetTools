namespace AssetTool
{
    [JsonAsset("ChaosVehicleWheel")]
    public class UChaosVehicleWheel : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}