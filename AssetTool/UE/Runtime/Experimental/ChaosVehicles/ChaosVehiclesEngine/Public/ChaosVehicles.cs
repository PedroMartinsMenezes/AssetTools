namespace AssetTool
{
    [JsonAsset("ChaosVehicles")]
    public class UChaosVehicles : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}