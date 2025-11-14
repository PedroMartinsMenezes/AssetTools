namespace AssetTool
{
    [JsonAsset("MassObstacleAvoidanceTrait")]
    public class UMassObstacleAvoidanceTrait : UMassEntityTraitBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}