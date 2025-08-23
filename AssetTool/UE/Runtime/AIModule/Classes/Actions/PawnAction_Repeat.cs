namespace AssetTool
{
    [JsonAsset("PawnAction_Repeat")]
    public class UDEPRECATED_PawnAction_Repeat : UDEPRECATED_PawnAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}