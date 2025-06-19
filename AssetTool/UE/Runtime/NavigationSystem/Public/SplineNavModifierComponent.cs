namespace AssetTool
{
    [JsonAsset("SplineNavModifierComponent")]
    public class USplineNavModifierComponent : UNavModifierComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}