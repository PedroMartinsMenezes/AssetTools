namespace AssetTool
{
    [JsonAsset("RecomputeUVsToolProperties")]
    public class URecomputeUVsToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}