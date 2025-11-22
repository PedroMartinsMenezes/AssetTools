namespace AssetTool
{
    [JsonAsset("CurveFloat")]
    public class UCurveFloat : UObject
    {
        public UCurveFloat()
        {
            ArrayMovers.Add("Keys", (transfer, value) => value.ToObject<FRichCurveKey>(transfer).Move(transfer));
        }

        public override ITransferable Move(Transfer transfer)
        {
            if (ArrayMovers.Count == 0)
                ArrayMovers.Add("Keys", (transfer, value) => value.ToObject<FRichCurveKey>(transfer).Move(transfer));

            return base.Move(transfer);
        }
    }
}