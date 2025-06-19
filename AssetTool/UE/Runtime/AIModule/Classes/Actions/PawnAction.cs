namespace AssetTool
{
    [JsonAsset("DEPRECATED_PawnAction")]
    public class UDEPRECATED_PawnAction : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}