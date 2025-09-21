namespace AssetTool
{
    [JsonAsset("CurveFloat")]
    public class UCurveFloat : UCurveBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            if (ArrayMovers.Count == 0)
                ArrayMovers.Add("Keys", (transfer, value) => value.ToObject<FRichCurveKey>(transfer).Move(transfer));

            return base.Move(transfer);
        }
    }
}