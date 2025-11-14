namespace AssetTool
{
    [JsonAsset("CineSplineComponent")]
    public class UCineSplineComponent : USplineComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}