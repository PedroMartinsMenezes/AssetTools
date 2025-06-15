namespace AssetTool
{
    [JsonAsset("SplineNavModifierComponent")]
    public class USplineNavModifierComponent : UNavModifierComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}