namespace AssetTool
{
    [JsonAsset("PaperSprite")]
    public class UPaperSprite : UObject
    {
        public UPaperSprite()
        {
            ArrayMovers.Add("Vertices", (transfer, value) => value.ToObject<FVector2D>(transfer).Move(transfer));
            ArrayMovers.Add("BakedRenderData", (transfer, value) => value.ToObject<FVector4>(transfer).Move(transfer));
        }

        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}