namespace AssetTool
{
    [JsonAsset("SplineNavModifierComponent")]
    public class USplineNavModifierComponent : UNavModifierComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}