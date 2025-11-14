namespace AssetTool
{
    [JsonAsset("TG_Expression")]
    public class UTG_Expression : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("TG_Expression_Null")]
    public class UTG_Expression_Null : UTG_Expression
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}