namespace AssetTool
{
    [JsonAsset("BrushBuilder")]
    public class UBrushBuilder : UObject
    {
        public UBrushBuilder()
        {
            ArrayMovers.Add("Vertices", (transfer, value) => value.ToObject<FVector>(transfer).Move(transfer));
        }

        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
