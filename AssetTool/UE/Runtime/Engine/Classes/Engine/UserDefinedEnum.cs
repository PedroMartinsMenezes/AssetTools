namespace AssetTool
{
    [JsonAsset("UserDefinedEnum")]
    public class UUserDefinedEnum : UEnum
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}