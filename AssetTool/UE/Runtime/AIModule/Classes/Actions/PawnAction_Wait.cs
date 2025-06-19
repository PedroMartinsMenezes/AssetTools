namespace AssetTool
{
    [JsonAsset("DEPRECATED_PawnAction_Wait")]
    public class UDEPRECATED_PawnAction_Wait : UDEPRECATED_PawnAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}