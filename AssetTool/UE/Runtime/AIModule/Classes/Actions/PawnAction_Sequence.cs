namespace AssetTool
{
    [JsonAsset("DEPRECATED_PawnAction_Sequence")]
    public class UDEPRECATED_PawnAction_Sequence : UDEPRECATED_PawnAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}