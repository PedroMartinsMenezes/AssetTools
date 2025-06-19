namespace AssetTool
{
    [JsonAsset("ChaosVehicles")]
    public class UChaosVehicles : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}