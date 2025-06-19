namespace AssetTool
{
    [JsonAsset("WheeledVehiclePawn")]
    public class AWheeledVehiclePawn : APawn
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}