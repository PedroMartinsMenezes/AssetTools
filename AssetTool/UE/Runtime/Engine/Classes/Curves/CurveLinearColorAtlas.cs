namespace AssetTool
{
    [JsonAsset("CurveLinearColorAtlas")]
    public class UCurveLinearColorAtlas : UTexture2D
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}