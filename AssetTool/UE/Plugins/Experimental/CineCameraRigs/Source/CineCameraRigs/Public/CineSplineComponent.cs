namespace AssetTool
{
    [JsonAsset("CineSplineComponent")]
    public class UCineSplineComponent : USplineComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}