namespace AssetTool
{
    [JsonAsset("UserDefinedEnum")]
    public class UUserDefinedEnum : UEnum
    {
        public UUserDefinedEnum()
        {
            ArrayMovers.Add("DisplayNames", (transfer, value) => value.ToObject<FText>(transfer).Move(transfer));
        }

        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}