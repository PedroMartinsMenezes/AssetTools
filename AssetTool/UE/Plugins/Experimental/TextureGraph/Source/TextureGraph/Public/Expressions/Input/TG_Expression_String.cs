namespace AssetTool
{
    [JsonAsset("TG_Expression_String")]
    public class UTG_Expression_String : UTG_Expression_InputParam
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}