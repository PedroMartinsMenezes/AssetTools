namespace AssetTool
{
    [JsonAsset("ChaosVehicles")]
    public class UChaosVehicles : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}