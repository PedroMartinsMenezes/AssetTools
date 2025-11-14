namespace AssetTool
{
    [JsonAsset("WheeledVehiclePawn")]
    public class AWheeledVehiclePawn : APawn
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}