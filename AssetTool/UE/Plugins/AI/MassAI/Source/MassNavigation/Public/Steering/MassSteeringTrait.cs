namespace AssetTool
{
    [JsonAsset("MassSteeringTrait")]
    public class UMassSteeringTrait : UMassEntityTraitBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}