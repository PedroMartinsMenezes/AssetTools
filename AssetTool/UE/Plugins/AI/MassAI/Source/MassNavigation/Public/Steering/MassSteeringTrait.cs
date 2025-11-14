namespace AssetTool
{
    [JsonAsset("MassSteeringTrait")]
    public class UMassSteeringTrait : UMassEntityTraitBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}