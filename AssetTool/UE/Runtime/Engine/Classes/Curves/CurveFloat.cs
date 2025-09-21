namespace AssetTool
{
    [JsonAsset("CurveFloat")]
    public class UCurveFloat : UCurveBase
    {
        public UCurveFloat()
        {
            ArrayMovers.Add("Keys", (transfer, value) => value.ToObject<FRichCurveKey>(transfer).Move(transfer));
        }

        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}