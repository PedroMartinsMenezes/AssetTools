namespace AssetTool
{
    [JsonAsset("MassObstacleAvoidanceTrait")]
    public class UMassObstacleAvoidanceTrait : UMassEntityTraitBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}