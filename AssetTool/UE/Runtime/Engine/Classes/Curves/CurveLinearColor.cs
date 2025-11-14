namespace AssetTool
{
    [JsonAsset("CurveLinearColor")]
    public class UCurveLinearColor : UCurveBase
    {
        public UCurveLinearColor()
        {
            ArrayMovers.Add("Keys", (transfer, value) => value.ToObject<FRichCurveKey>(transfer).Move(transfer));
        }

        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}